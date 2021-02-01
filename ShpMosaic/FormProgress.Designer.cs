
namespace ShpMosaic
{
    partial class FormProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSub = new System.Windows.Forms.Label();
            this.progressBarSub = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBarProgress = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerProgress = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Location = new System.Drawing.Point(8, 6);
            this.labelSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(56, 17);
            this.labelSub.TabIndex = 0;
            this.labelSub.Text = "查询影像";
            // 
            // progressBarSub
            // 
            this.progressBarSub.Location = new System.Drawing.Point(8, 26);
            this.progressBarSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarSub.Name = "progressBarSub";
            this.progressBarSub.Size = new System.Drawing.Size(480, 24);
            this.progressBarSub.TabIndex = 1;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(8, 52);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(56, 17);
            this.labelProgress.TabIndex = 2;
            this.labelProgress.Text = "已完成：";
            // 
            // progressBarProgress
            // 
            this.progressBarProgress.Location = new System.Drawing.Point(8, 71);
            this.progressBarProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarProgress.Name = "progressBarProgress";
            this.progressBarProgress.Size = new System.Drawing.Size(480, 24);
            this.progressBarProgress.TabIndex = 3;
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 104);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarProgress);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBarSub);
            this.Controls.Add(this.labelSub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "正在镶嵌";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.ProgressBar progressBarSub;
        private System.Windows.Forms.Label labelProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorkerProgress;
        private System.Windows.Forms.ProgressBar progressBarProgress;
    }
}