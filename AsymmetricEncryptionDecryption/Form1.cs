using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsymmetricEncryptionDecryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtOutputData.Text = AsymmetricCryptoEngine.Encryption(txtData.Text, txtPublic.Text);
            btnDecrypt.Enabled = true;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtDecrypedData.Text = AsymmetricCryptoEngine.Decryption(txtOutputData.Text, txtPrivate.Text);
            btnDecrypt.Enabled = false;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            btnEncrypt.Enabled = btnEncrypt.Enabled = !String.IsNullOrWhiteSpace(txtPublic.Text)
                && !String.IsNullOrWhiteSpace(txtPrivate.Text)
              && !String.IsNullOrWhiteSpace(txtData.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtData.Text = txtPrivate.Text = txtPublic.Text = txtOutputData.Text= string.Empty;
            btnDecrypt.Enabled = btnEncrypt.Enabled = false;
        }

        private void btnPublicKeyExport_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(AsymmetricCryptoEngine.ConvertXmlToBase64(txtPublic.Text, false));
        }

        private void btnPrivateKeyExport_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(AsymmetricCryptoEngine.ConvertXmlToBase64(txtPrivate.Text, true));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024);

            txtPublic.Text = RSA.ToXmlString(false);
            txtPrivate.Text = RSA.ToXmlString(true);
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtOutputData.Text);
        }
    }
}
