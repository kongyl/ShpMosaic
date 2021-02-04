using ShpMosaic.Model;
using System.ComponentModel;
using System.Windows.Forms;

namespace ShpMosaic
{
    public partial class FormProgress : Form
    {
        public FormProgress(BackgroundWorker backgroundWorkerMain)
        {
            InitializeComponent();

            this.backgroundWorkerMain = backgroundWorkerMain;
            this.backgroundWorkerMain.ProgressChanged += new ProgressChangedEventHandler(backgroundWorkerMain_ProgressChanged);
            this.backgroundWorkerMain.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerMain_RunWorkerCompleted);
        }

        private void backgroundWorkerMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }

        private void backgroundWorkerMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarMain.Value = e.ProgressPercentage;
            ProgressInfo progressInfo = (ProgressInfo)e.UserState;
            progressBarSub.Value = progressInfo.SubComplete;
            labelSub.Text = progressInfo.SubTitle + progressInfo.SubInfo;
            labelMain.Text = progressInfo.Info;
        }
    }
}
