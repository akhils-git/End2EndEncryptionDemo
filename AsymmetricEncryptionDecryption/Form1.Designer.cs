namespace AsymmetricEncryptionDecryption
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublic = new System.Windows.Forms.TextBox();
            this.txtPrivate = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDecrypedData = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtOutputData = new System.Windows.Forms.TextBox();
            this.btnPublicKeyExport = new System.Windows.Forms.Button();
            this.btnPrivateKeyExport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExportData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(33, 420);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(309, 32);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-178, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Public Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Public Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Private Key";
            // 
            // txtPublic
            // 
            this.txtPublic.Location = new System.Drawing.Point(30, 35);
            this.txtPublic.Multiline = true;
            this.txtPublic.Name = "txtPublic";
            this.txtPublic.Size = new System.Drawing.Size(346, 141);
            this.txtPublic.TabIndex = 11;
            this.txtPublic.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtPrivate
            // 
            this.txtPrivate.Location = new System.Drawing.Point(393, 35);
            this.txtPrivate.Multiline = true;
            this.txtPrivate.Name = "txtPrivate";
            this.txtPrivate.Size = new System.Drawing.Size(346, 141);
            this.txtPrivate.TabIndex = 10;
            this.txtPrivate.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(33, 219);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(706, 20);
            this.txtData.TabIndex = 14;
            this.txtData.Text = "SachinTendulker";
            this.txtData.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(430, 420);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(309, 32);
            this.btnDecrypt.TabIndex = 17;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Decryped Data";
            // 
            // txtDecrypedData
            // 
            this.txtDecrypedData.Location = new System.Drawing.Point(33, 390);
            this.txtDecrypedData.Name = "txtDecrypedData";
            this.txtDecrypedData.Size = new System.Drawing.Size(706, 20);
            this.txtDecrypedData.TabIndex = 18;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(348, 420);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 32);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtOutputData
            // 
            this.txtOutputData.Location = new System.Drawing.Point(33, 260);
            this.txtOutputData.Multiline = true;
            this.txtOutputData.Name = "txtOutputData";
            this.txtOutputData.Size = new System.Drawing.Size(706, 84);
            this.txtOutputData.TabIndex = 21;
            // 
            // btnPublicKeyExport
            // 
            this.btnPublicKeyExport.Location = new System.Drawing.Point(292, 182);
            this.btnPublicKeyExport.Name = "btnPublicKeyExport";
            this.btnPublicKeyExport.Size = new System.Drawing.Size(75, 23);
            this.btnPublicKeyExport.TabIndex = 22;
            this.btnPublicKeyExport.Text = "Export";
            this.btnPublicKeyExport.UseVisualStyleBackColor = true;
            this.btnPublicKeyExport.Click += new System.EventHandler(this.btnPublicKeyExport_Click);
            // 
            // btnPrivateKeyExport
            // 
            this.btnPrivateKeyExport.Location = new System.Drawing.Point(664, 182);
            this.btnPrivateKeyExport.Name = "btnPrivateKeyExport";
            this.btnPrivateKeyExport.Size = new System.Drawing.Size(75, 23);
            this.btnPrivateKeyExport.TabIndex = 23;
            this.btnPrivateKeyExport.Text = "Export";
            this.btnPrivateKeyExport.UseVisualStyleBackColor = true;
            this.btnPrivateKeyExport.Click += new System.EventHandler(this.btnPrivateKeyExport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Encrypted Data";
            // 
            // btnExportData
            // 
            this.btnExportData.Location = new System.Drawing.Point(664, 351);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(75, 23);
            this.btnExportData.TabIndex = 25;
            this.btnExportData.Text = "Export";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 471);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPrivateKeyExport);
            this.Controls.Add(this.btnPublicKeyExport);
            this.Controls.Add(this.txtOutputData);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDecrypedData);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPublic);
            this.Controls.Add(this.txtPrivate);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asymmetric Encryption Decryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublic;
        private System.Windows.Forms.TextBox txtPrivate;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDecrypedData;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtOutputData;
        private System.Windows.Forms.Button btnPublicKeyExport;
        private System.Windows.Forms.Button btnPrivateKeyExport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExportData;
    }
}

