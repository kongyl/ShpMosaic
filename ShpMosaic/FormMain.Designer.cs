
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
            this.labelShp = new System.Windows.Forms.Label();
            this.textBoxShp = new System.Windows.Forms.TextBox();
            this.buttonShp = new System.Windows.Forms.Button();
            this.openFileDialogShp = new System.Windows.Forms.OpenFileDialog();
            this.labelIn = new System.Windows.Forms.Label();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.buttonIn = new System.Windows.Forms.Button();
            this.folderBrowserDialogIn = new System.Windows.Forms.FolderBrowserDialog();
            this.labelOut = new System.Windows.Forms.Label();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonOut = new System.Windows.Forms.Button();
            this.folderBrowserDialogOut = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelShp
            // 
            this.labelShp.AutoSize = true;
            this.labelShp.Location = new System.Drawing.Point(12, 17);
            this.labelShp.Name = "labelShp";
            this.labelShp.Size = new System.Drawing.Size(100, 24);
            this.labelShp.TabIndex = 0;
            this.labelShp.Text = "选择矢量：";
            // 
            // textBoxShp
            // 
            this.textBoxShp.Location = new System.Drawing.Point(118, 14);
            this.textBoxShp.Name = "textBoxShp";
            this.textBoxShp.ReadOnly = true;
            this.textBoxShp.Size = new System.Drawing.Size(930, 30);
            this.textBoxShp.TabIndex = 1;
            // 
            // buttonShp
            // 
            this.buttonShp.Location = new System.Drawing.Point(1054, 12);
            this.buttonShp.Name = "buttonShp";
            this.buttonShp.Size = new System.Drawing.Size(112, 34);
            this.buttonShp.TabIndex = 2;
            this.buttonShp.Text = "浏览";
            this.buttonShp.UseVisualStyleBackColor = true;
            // 
            // openFileDialogShp
            // 
            this.openFileDialogShp.FileName = "openFileDialog1";
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Location = new System.Drawing.Point(12, 57);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(100, 24);
            this.labelIn.TabIndex = 3;
            this.labelIn.Text = "影像路径：";
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(118, 54);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.ReadOnly = true;
            this.textBoxIn.Size = new System.Drawing.Size(930, 30);
            this.textBoxIn.TabIndex = 4;
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(1054, 52);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(112, 34);
            this.buttonIn.TabIndex = 5;
            this.buttonIn.Text = "浏览";
            this.buttonIn.UseVisualStyleBackColor = true;
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(12, 97);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(100, 24);
            this.labelOut.TabIndex = 6;
            this.labelOut.Text = "输出路径：";
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(118, 94);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(930, 30);
            this.textBoxOut.TabIndex = 7;
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(1054, 92);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(112, 34);
            this.buttonOut.TabIndex = 8;
            this.buttonOut.Text = "浏览";
            this.buttonOut.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(936, 132);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 34);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "开始";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1054, 132);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 183);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.buttonShp);
            this.Controls.Add(this.textBoxShp);
            this.Controls.Add(this.labelShp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "镶嵌";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonShp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxShp;
        private System.Windows.Forms.OpenFileDialog openFileDialogShp;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogIn;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOut;
        private System.Windows.Forms.Button buttonCancel;
    }
}

