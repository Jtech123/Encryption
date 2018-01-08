namespace Encryption2
{
    partial class Form1
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
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.stringbox = new System.Windows.Forms.TextBox();
            this.encryptedString = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.encryptedBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encryptBtn
            // 
            this.encryptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.encryptBtn.Location = new System.Drawing.Point(12, 218);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(114, 23);
            this.encryptBtn.TabIndex = 0;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptBtn.Location = new System.Drawing.Point(154, 218);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(116, 23);
            this.decryptBtn.TabIndex = 1;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // stringbox
            // 
            this.stringbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stringbox.Location = new System.Drawing.Point(12, 12);
            this.stringbox.Name = "stringbox";
            this.stringbox.Size = new System.Drawing.Size(258, 22);
            this.stringbox.TabIndex = 0;
            // 
            // encryptedString
            // 
            this.encryptedString.AutoSize = true;
            this.encryptedString.Location = new System.Drawing.Point(12, 82);
            this.encryptedString.Name = "encryptedString";
            this.encryptedString.Size = new System.Drawing.Size(60, 17);
            this.encryptedString.TabIndex = 5;
            this.encryptedString.Text = "STRING";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(12, 128);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(60, 17);
            this.Result.TabIndex = 6;
            this.Result.Text = "STRING";
            // 
            // encryptedBox
            // 
            this.encryptedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptedBox.Location = new System.Drawing.Point(12, 40);
            this.encryptedBox.Name = "encryptedBox";
            this.encryptedBox.Size = new System.Drawing.Size(258, 22);
            this.encryptedBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.encryptedBox);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.encryptedString);
            this.Controls.Add(this.stringbox);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.TextBox stringbox;
        private System.Windows.Forms.Label encryptedString;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox encryptedBox;
    }
}

