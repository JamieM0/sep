using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toggle_Encryptor___Development
{
    public partial class Form1 : Form
    {
        string pass;
        string inputtoencrypt;
        string key;

        public Form1()
        {
            InitializeComponent();
            gbAbout__enable();
            gbMain__disable();
            lbIns3.Visible = false;
            lbEncryptOutput.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void gbAbout__disable()
        {
            gbAbout.Visible = false;
            gbAbout.Enabled = false;
        }

        private void gbAbout__enable()
        {
            gbAbout.Visible = true;
            gbAbout.Enabled = true;
        }

        private void gbMain__disable()
        {
            gbMain.Visible = false;
            gbMain.Enabled = false;
        }

        private void gbMain__enable()
        {
            gbMain.Visible = true;
            gbMain.Enabled = true;
        }

        private void btnContinueFromAbout_Click(object sender, EventArgs e)
        {
            gbAbout__disable();
            gbMain__enable();
        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            key = txtPass.Text;
            txtPass.Enabled = false;
            btnConfirmPass.Enabled = false;
        }

        private void btnConfirmInputEncrypt_Click(object sender, EventArgs e)
        {
            var str = txtEncryptInput.Text;
            txtEncryptInput.Enabled = false;
            btnConfirmInputEncrypt.Enabled = false;

            var encryptedString = AesOperation.EncryptString(key, str);

            lbEncryptOutput.Text = encryptedString;
            lbIns3.Visible = true;
            lbEncryptOutput.Visible = true;
        }
    }
}
