namespace NT106_Lab4
{
    partial class frmB2
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
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbResponse
            // 
            this.rtbResponse.Location = new System.Drawing.Point(71, 127);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(841, 507);
            this.rtbResponse.TabIndex = 5;
            this.rtbResponse.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(790, 41);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(122, 68);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(71, 41);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(639, 31);
            this.tbAddress.TabIndex = 3;
            this.tbAddress.Text = "http://www.contoso.com/PostAccepter.aspx";
            // 
            // tbPost
            // 
            this.tbPost.Location = new System.Drawing.Point(71, 78);
            this.tbPost.Name = "tbPost";
            this.tbPost.Size = new System.Drawing.Size(639, 31);
            this.tbPost.TabIndex = 6;
            this.tbPost.Text = "NGO+VO+VIET+KHOA";
            // 
            // frmB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 688);
            this.Controls.Add(this.tbPost);
            this.Controls.Add(this.rtbResponse);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.tbAddress);
            this.Name = "frmB2";
            this.Text = "BÀI 2";
            this.Load += new System.EventHandler(this.B2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPost;
    }
}