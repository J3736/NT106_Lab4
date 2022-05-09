namespace NT106_Lab4
{
    partial class frmB4
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
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnDl = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.bWed = new System.Windows.Forms.WebBrowser();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(12, 11);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(1502, 31);
            this.tbAddress.TabIndex = 0;
            this.tbAddress.Text = "https://www.google.com/";
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddr_TextChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(2173, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(100, 32);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDl
            // 
            this.btnDl.Location = new System.Drawing.Point(2067, 60);
            this.btnDl.Name = "btnDl";
            this.btnDl.Size = new System.Drawing.Size(206, 32);
            this.btnDl.TabIndex = 3;
            this.btnDl.Text = "DOWNLOAD";
            this.btnDl.UseVisualStyleBackColor = true;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(12, 58);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(1502, 31);
            this.tbUrl.TabIndex = 4;
            this.tbUrl.Text = "C:\\uit\\nt106\\lab4\\bai4.html";
            // 
            // bWed
            // 
            this.bWed.Location = new System.Drawing.Point(12, 148);
            this.bWed.MinimumSize = new System.Drawing.Size(20, 20);
            this.bWed.Name = "bWed";
            this.bWed.Size = new System.Drawing.Size(2261, 1303);
            this.bWed.TabIndex = 5;
            this.bWed.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(2067, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 32);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmB4
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2285, 1463);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.bWed);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.btnDl);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbAddress);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmB4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀI 4 WEB BROWSER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmB4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnDl;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.WebBrowser bWed;
        private System.Windows.Forms.Button btnBack;
    }
}