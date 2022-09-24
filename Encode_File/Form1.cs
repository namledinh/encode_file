using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encode_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Chọn tập tin cần mã hóa";
            dialog.Filter = "Text files|*.txt";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string file_path = dialog.FileName;
                file_path = new FileInfo(file_path).FullName;

                txtUrl.Text = file_path;
                txtencrypt.Text = Path.GetDirectoryName(file_path) + @"ciphertext.dat";
                txtdecrypt.Text = Path.GetDirectoryName(file_path) + @"deciphered.txt";

                txtPlaintextFile.Text = File.ReadAllText(file_path);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            CryptoStuff.EncryptFile(txt_pass.Text, txtUrl.Text, txtencrypt.Text);
            txtCiphertextFile.Text = File.ReadAllBytes(txtencrypt.Text).ToHex(' ');

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            CryptoStuff.DecryptFile(txt_pass.Text, txtencrypt.Text, txtdecrypt.Text);
            txtDecipheredFile.Text = File.ReadAllText(txtdecrypt.Text);
        }
    }
}
