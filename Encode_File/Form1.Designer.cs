namespace Encode_File
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtencrypt = new System.Windows.Forms.TextBox();
            this.txtdecrypt = new System.Windows.Forms.TextBox();
            this.txtPlaintextFile = new System.Windows.Forms.TextBox();
            this.txtCiphertextFile = new System.Windows.Forms.TextBox();
            this.txtDecipheredFile = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu:";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(513, 24);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(94, 27);
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.Text = "Chọn file ...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(85, 24);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(389, 27);
            this.txt_pass.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(85, 82);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(389, 27);
            this.txtUrl.TabIndex = 4;
            // 
            // txtencrypt
            // 
            this.txtencrypt.Location = new System.Drawing.Point(513, 82);
            this.txtencrypt.Multiline = true;
            this.txtencrypt.Name = "txtencrypt";
            this.txtencrypt.Size = new System.Drawing.Size(389, 27);
            this.txtencrypt.TabIndex = 5;
            // 
            // txtdecrypt
            // 
            this.txtdecrypt.Location = new System.Drawing.Point(941, 82);
            this.txtdecrypt.Multiline = true;
            this.txtdecrypt.Name = "txtdecrypt";
            this.txtdecrypt.Size = new System.Drawing.Size(389, 27);
            this.txtdecrypt.TabIndex = 6;
            // 
            // txtPlaintextFile
            // 
            this.txtPlaintextFile.Location = new System.Drawing.Point(85, 143);
            this.txtPlaintextFile.Multiline = true;
            this.txtPlaintextFile.Name = "txtPlaintextFile";
            this.txtPlaintextFile.ReadOnly = true;
            this.txtPlaintextFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPlaintextFile.Size = new System.Drawing.Size(389, 410);
            this.txtPlaintextFile.TabIndex = 7;
            // 
            // txtCiphertextFile
            // 
            this.txtCiphertextFile.Location = new System.Drawing.Point(513, 143);
            this.txtCiphertextFile.Multiline = true;
            this.txtCiphertextFile.Name = "txtCiphertextFile";
            this.txtCiphertextFile.ReadOnly = true;
            this.txtCiphertextFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCiphertextFile.Size = new System.Drawing.Size(389, 410);
            this.txtCiphertextFile.TabIndex = 8;
            // 
            // txtDecipheredFile
            // 
            this.txtDecipheredFile.Location = new System.Drawing.Point(941, 143);
            this.txtDecipheredFile.Multiline = true;
            this.txtDecipheredFile.Name = "txtDecipheredFile";
            this.txtDecipheredFile.ReadOnly = true;
            this.txtDecipheredFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDecipheredFile.Size = new System.Drawing.Size(389, 410);
            this.txtDecipheredFile.TabIndex = 9;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(663, 24);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(94, 27);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Mã hóa";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(808, 24);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(94, 27);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 590);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtDecipheredFile);
            this.Controls.Add(this.txtCiphertextFile);
            this.Controls.Add(this.txtPlaintextFile);
            this.Controls.Add(this.txtdecrypt);
            this.Controls.Add(this.txtencrypt);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtencrypt;
        private System.Windows.Forms.TextBox txtdecrypt;
        private System.Windows.Forms.TextBox txtPlaintextFile;
        private System.Windows.Forms.TextBox txtCiphertextFile;
        private System.Windows.Forms.TextBox txtDecipheredFile;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

