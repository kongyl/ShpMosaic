
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
            this.labelSub.Location = new System.Drawing.Point(12, 9);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(82, 24);
            this.labelSub.TabIndex = 0;
            this.labelSub.Text = "查询影像";
            // 
            // progressBarSub
            // 
            this.progressBarSub.Location = new System.Drawing.Point(12, 36);
            this.progressBarSub.Name = "progressBarSub";
            this.progressBarSub.Size = new System.Drawing.Size(754, 34);
            this.progressBarSub.TabIndex = 1;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(12, 73);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(82, 24);
            this.labelProgress.TabIndex = 2;
            this.labelProgress.Text = "已完成：";
            // 
            // progressBarProgress
            // 
            this.progressBarProgress.Location = new System.Drawing.Point(12, 100);
            this.progressBarProgress.Name = "progressBarProgress";
            this.progressBarProgress.Size = new System.Drawing.Size(754, 34);
            this.progressBarProgress.TabIndex = 3;
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 150);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarProgress);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBarSub);
            this.Controls.Add(this.labelSub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerProgress;
        private System.Windows.Forms.ProgressBar progressBarProgress;
    }
}