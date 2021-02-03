using OSGeo.GDAL;
using OSGeo.OGR;
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
        private int year;
        private string outPath;
        private ProgressInfo progressInfo;
        private int totalProgress;

        public FormMain()
        {
            InitializeComponent();

            comboBoxYear.SelectedIndex = 0;
            year = 2000;
            outPath = "";
            progressInfo = new ProgressInfo(0, "", "已完成：0");
            Gdal.AllRegister();            
            totalProgress = 0;
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            outPath = textBoxOut.Text = "";
            if (folderBrowserDialogOut.ShowDialog() == DialogResult.OK)
            {
                outPath = textBoxOut.Text = folderBrowserDialogOut.SelectedPath;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (outPath == null || outPath.Trim().Equals(""))
            {
                MessageBox.Show("请选择输出路径");
                return;
            }

            backgroundWorkerMain.RunWorkerAsync();
            FormProgress formProgress = new FormProgress(backgroundWorkerMain);
            formProgress.ShowDialog(this);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = 2000 + 10 * comboBoxYear.SelectedIndex;
        }

        private void backgroundWorkerMain_DoWork(object sender, DoWorkEventArgs e)
        {
            progressInfo.SubInfo = "读取矢量";
            reportProgress();
            List<long> codeList = CountryDao.FindAllCode();
            if (codeList == null || codeList.Count == 0)
            {
                MessageBox.Show("矢量没有正确的code_new信息，请重新注册");
                return;
            }
            DataSource dataSource = Ogr.Open("data\\shp\\dst\\country.shp", 0);

            int codeNum = codeList.Count;
            progressInfo.Info = string.Format("已完成：0/{0}", codeNum);
            for (int i = 0; i < codeNum; i++)
            {
                progressInfo.SubComplete = 0;
                progressInfo.SubInfo = "查询数据";
                reportProgress();

                long code = codeList[i];
                List<string> nameList = ImgDao.findNameByYearAndCode(year, code);
                if (nameList == null || nameList.Count == 0)
                {
                    continue;
                }

                Layer layer = dataSource.ExecuteSQL(string.Format("select * from country where Code_new={0}", code), null, null);
                if (layer.GetFeatureCount(1) == 0)
                {
                    continue;
                }
                layer.ResetReading();
                Feature feature = layer.GetNextFeature();
                Geometry geometry = feature.GetGeometryRef();
                Envelope envelope = new Envelope();
                geometry.GetEnvelope(envelope);

                int nameCount = nameList.Count;
                Dataset[] inDss = new Dataset[nameCount];
                for (int j = 0; j < nameCount; j++)
                {
                    inDss[j] = Gdal.Open(string.Format("data\\img\\r{0}\\{1}", year, nameList[j]), Access.GA_ReadOnly);
                }
                string outFile = string.Format("{0}\\{1:D3}.tif", outPath, code);
                

                try
                {
                    string[] options = new string[]
                    {
                          "-t_srs", "data\\shp\\dst\\country.prj",
                          "-tr", "30", "30",
                          "-srcnodata", "128",
                          "-dstnodata", "0",
                          "-ot", "Byte",
                          "-co", "COMPRESS=LZW",
                          "-co", "TILED=YES",
                          "-te", envelope.MinX.ToString(), envelope.MinY.ToString(), envelope.MaxX.ToString(), envelope.MaxY.ToString()
                    };
                    GDALWarpAppOptions gdalOptions = new GDALWarpAppOptions(options);
                    Dataset outDs = Gdal.Warp(outFile, inDss, gdalOptions, gdalProgressFunc, null);
                    outDs.FlushCache();
                    outDs.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }

                progressInfo.Info = string.Format("已完成：{0}/{1}", i + 1, codeNum);
                totalProgress = (i + 1) * 100 / codeNum;
                reportProgress();
            }

            MessageBox.Show("镶嵌完成");
        }

        private void reportProgress()
        {
            backgroundWorkerMain.ReportProgress(totalProgress, progressInfo);
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
    }
}
