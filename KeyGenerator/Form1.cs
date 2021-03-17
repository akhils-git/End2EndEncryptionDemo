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

namespace KeyGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            
            txtPublic.Text = RSA.ToXmlString(false);
            txtPrivate.Text = RSA.ToXmlString(true);

        }

        private void txtPrivate_MouseEnter(object sender, EventArgs e)
        {
            if (txtPrivate.Text != "")
            {

                Clipboard.SetText(txtPrivate.Text, TextDataFormat.Text);
                this.Text = "Private Key Copyed";
            }
        }



        private void btnPrivateKey_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            if (!String.IsNullOrWhiteSpace(txtPrivate.Text))
            {

                Clipboard.SetText(txtPrivate.Text, TextDataFormat.Text);
                this.Text = "Private Key Copyed";
            }
        }

        private void btnPublicKey_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            if (!String.IsNullOrWhiteSpace(txtPublic.Text))
            {
                Clipboard.SetText(txtPublic.Text, TextDataFormat.Text);
                this.Text = "Public Key Copyed";
            }
        }

        private void txtPublic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
