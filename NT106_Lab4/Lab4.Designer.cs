namespace NT106_Lab4
{
    partial class frmL4
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
            this.btnB1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnB4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnB1
            // 
            this.btnB1.Location = new System.Drawing.Point(101, 67);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(126, 57);
            this.btnB1.TabIndex = 0;
            this.btnB1.Text = "BÀI 1";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "BÀI 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "BÀI 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnB4
            // 
            this.btnB4.Location = new System.Drawing.Point(275, 161);
            this.btnB4.Name = "btnB4";
            this.btnB4.Size = new System.Drawing.Size(126, 57);
            this.btnB4.TabIndex = 3;
            this.btnB4.Text = "BÀI 4";
            this.btnB4.UseVisualStyleBackColor = true;
            this.btnB4.Click += new System.EventHandler(this.btnB4_Click);
            // 
            // frmL4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 393);
            this.Controls.Add(this.btnB4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnB1);
            this.Name = "frmL4";
            this.Text = "LAB 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnB4;
    }
}

