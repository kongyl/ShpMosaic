
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
            this.labelMain = new System.Windows.Forms.Label();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerMain = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Location = new System.Drawing.Point(12, 9);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(53, 12);
            this.labelSub.TabIndex = 0;
            this.labelSub.Text = "开始镶嵌";
            // 
            // progressBarSub
            // 
            this.progressBarSub.Location = new System.Drawing.Point(12, 24);
            this.progressBarSub.Name = "progressBarSub";
            this.progressBarSub.Size = new System.Drawing.Size(560, 23);
            this.progressBarSub.TabIndex = 1;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(12, 50);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(59, 12);
            this.labelMain.TabIndex = 2;
            this.labelMain.Text = "已完成：0";
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(14, 65);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(558, 23);
            this.progressBarMain.TabIndex = 3;
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 100);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarMain);
            this.Controls.Add(this.labelMain);
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
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMain;
    }
}