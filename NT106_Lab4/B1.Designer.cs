namespace NT106_Lab4
{
    partial class frmB1
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
            this.components = new System.ComponentModel.Container();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(80, 45);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(639, 31);
            this.tbAddress.TabIndex = 0;
            this.tbAddress.Text = "https://www.uit.edu.vn/";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(799, 33);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(122, 55);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // rtbResponse
            // 
            this.rtbResponse.Location = new System.Drawing.Point(80, 106);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(841, 507);
            this.rtbResponse.TabIndex = 2;
            this.rtbResponse.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmB1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 660);
            this.Controls.Add(this.rtbResponse);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.tbAddress);
            this.Name = "frmB1";
            this.Text = "BÀI 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}