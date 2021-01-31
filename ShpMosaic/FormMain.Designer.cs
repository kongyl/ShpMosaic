
namespace ShpMosaic
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelYear = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonOut = new System.Windows.Forms.Button();
            this.folderBrowserDialogOut = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.backgroundWorkerProgress = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(12, 17);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(100, 24);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "选择年份：";
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(12, 55);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(100, 24);
            this.labelOut.TabIndex = 6;
            this.labelOut.Text = "输出路径：";
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(118, 52);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(930, 30);
            this.textBoxOut.TabIndex = 7;
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(1054, 50);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(112, 34);
            this.buttonOut.TabIndex = 8;
            this.buttonOut.Text = "浏览";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(936, 90);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 34);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "开始";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1054, 90);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2000",
            "2010",
            "2020"});
            this.comboBoxYear.Location = new System.Drawing.Point(118, 14);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(182, 32);
            this.comboBoxYear.TabIndex = 11;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // backgroundWorkerProgress
            // 
            this.backgroundWorkerProgress.WorkerReportsProgress = true;
            this.backgroundWorkerProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerProgress_DoWork);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 138);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.labelYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "镶嵌";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOut;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.ComponentModel.BackgroundWorker backgroundWorkerProgress;
    }
}

