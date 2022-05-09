namespace NT106_Lab4
{
    partial class frmB3
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbFileUrl = new System.Windows.Forms.TextBox();
            this.btnDl = new System.Windows.Forms.Button();
            this.rtbHtml = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(65, 58);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(656, 31);
            this.tbUrl.TabIndex = 0;
            this.tbUrl.Text = "https://www.uit.edu.vn/";
            // 
            // tbFileUrl
            // 
            this.tbFileUrl.Location = new System.Drawing.Point(65, 118);
            this.tbFileUrl.Name = "tbFileUrl";
            this.tbFileUrl.Size = new System.Drawing.Size(656, 31);
            this.tbFileUrl.TabIndex = 1;
            this.tbFileUrl.Text = "C:\\uit\\nt106\\lab4\\bai3.html";
            this.tbFileUrl.TextChanged += new System.EventHandler(this.tbFileUrl_TextChanged);
            // 
            // btnDl
            // 
            this.btnDl.Location = new System.Drawing.Point(790, 58);
            this.btnDl.Name = "btnDl";
            this.btnDl.Size = new System.Drawing.Size(144, 91);
            this.btnDl.TabIndex = 2;
            this.btnDl.Text = "Download";
            this.btnDl.UseVisualStyleBackColor = true;
            this.btnDl.Click += new System.EventHandler(this.btnDl_Click);
            // 
            // rtbHtml
            // 
            this.rtbHtml.Location = new System.Drawing.Point(70, 224);
            this.rtbHtml.Name = "rtbHtml";
            this.rtbHtml.Size = new System.Drawing.Size(863, 577);
            this.rtbHtml.TabIndex = 3;
            this.rtbHtml.Text = "";
            // 
            // frmB3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 858);
            this.Controls.Add(this.rtbHtml);
            this.Controls.Add(this.btnDl);
            this.Controls.Add(this.tbFileUrl);
            this.Controls.Add(this.tbUrl);
            this.Name = "frmB3";
            this.Text = "BÀI 3";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnDl;
        private System.Windows.Forms.TextBox tbFileUrl;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.RichTextBox rtbHtml;
    }
}