using OSGeo.GDAL;
using ShpMosaic.Dao;
using ShpMosaic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ShpMosaic
{
    public partial class FormMain : Form
    {
        private ProgressInfo progressInfo;
        private GDALWarpAppOptions gdalOptions;
        private int totalProgress;
        private int year;
        private string outPath;

        public FormMain()
        {
            InitializeComponent();

            comboBoxYear.SelectedIndex = 0;
            year = 2000;
            outPath = "";
            progressInfo = new ProgressInfo(0, "", "已完成：0");
            Gdal.AllRegister();
            string[] options = new string[]
            {
                "-t_srs", "dst.prj",
                "-tr", "30", "30",
                "-srcnodata", "128",
                "-dstnodata", "0",
                "-ot", "Byte",
                "-co", "COMPRESS=LZW",
                "-co", "TILED=YES"
            };
            gdalOptions = new GDALWarpAppOptions(options);
            totalProgress = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = "";
            outPath = "";
            if (folderBrowserDialogOut.ShowDialog() == DialogResult.OK)
            {
                textBoxOut.Text = folderBrowserDialogOut.SelectedPath;
                outPath = folderBrowserDialogOut.SelectedPath;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (outPath == null || outPath.Trim().Equals(""))
            {
                MessageBox.Show("请选择输出路径");
                return;
            }

            backgroundWorkerProgress.RunWorkerAsync();
            FormProgress formProgress = new FormProgress(backgroundWorkerProgress);
            formProgress.ShowDialog(this);
        }

        private void backgroundWorkerProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            progressInfo.SubInfo = "获取矢量信息";
            reportProgress();
            List<long> codeList = CountryDao.FindAllCode();
            if (codeList == null || codeList.Count == 0)
            {
                MessageBox.Show("矢量没有正确的code_new信息，请重新挂载");
                return;
            }

            int codeNum = codeList.Count;
            progressInfo.Info = string.Format("已完成：0/{0}", codeNum);
            for (int i = 0; i < codeNum; i++)
            {
                progressInfo.SubComplete = 0;
                progressInfo.SubInfo = "查询影像";
                reportProgress();

                long code = codeList[i];
                List<string> nameList = ImgDao.findNameByYearAndCode(year, code);
                int nameCount = nameList.Count;
                if (nameCount > 0)
                {
                    Dataset[] inDss = new Dataset[nameCount];
                    for (int j = 0; j < nameCount; j++)
                    {
                        inDss[j] = Gdal.Open("r2000\\" + nameList[j], Access.GA_ReadOnly);
                    }
                    string outFile = string.Format("{0}\\{1:D3}.tif", outPath, code);
                    try
                    {
                        Dataset outDs = Gdal.Warp(outFile, inDss, gdalOptions, gdalProgressFunc, null);
                        outDs.FlushCache();
                        outDs.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

                progressInfo.Info = string.Format("已完成：{0}/{1}", i + 1, codeNum);
                totalProgress = (i + 1) * 100 / codeNum;
                reportProgress();
            }

            MessageBox.Show("镶嵌完成");
        }

        private void reportProgress()
        {
            backgroundWorkerProgress.ReportProgress(totalProgress, progressInfo);
        }

        private int gdalProgressFunc(double complete, IntPtr message, IntPtr data)
        {
            int com = (int)(complete * 100);
            if (com != progressInfo.SubComplete)
            {
                progressInfo.SubComplete = com;
                if (message != IntPtr.Zero)
                {
                    progressInfo.SubInfo = Marshal.PtrToStringAnsi(message);
                }
                reportProgress();
            }
            return 1;
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = 2000 + 10 * comboBoxYear.SelectedIndex;
        }
    }
}
