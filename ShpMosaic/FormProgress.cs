using ShpMosaic.Model;
using System.ComponentModel;
using System.Windows.Forms;

namespace ShpMosaic
{
    public partial class FormProgress : Form
    {
        public FormProgress(BackgroundWorker backgroundWorkerProgress)
        {
            InitializeComponent();

            this.backgroundWorkerProgress = backgroundWorkerProgress;
            this.backgroundWorkerProgress.ProgressChanged += new ProgressChangedEventHandler(backgroundWorkerProgress_ProgressChanged);
            this.backgroundWorkerProgress.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerProgress_RunWorkerCompleted);
        }

        private void backgroundWorkerProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }

        private void backgroundWorkerProgress_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarProgress.Value = e.ProgressPercentage;
            ProgressInfo progressInfo = (ProgressInfo)e.UserState;
            progressBarSub.Value = progressInfo.SubComplete;
            labelSub.Text = progressInfo.SubInfo;
            labelProgress.Text = progressInfo.Info;
        }
    }
}
