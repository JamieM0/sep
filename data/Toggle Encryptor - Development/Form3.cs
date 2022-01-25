using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Toggle_Encryptor___Development
{
    public partial class Form3 : Form
    {
        string password;
        string inputtoencrypt;
        string key;
        string savepassworda;
        string saveetexta;

        public Form3()
        {
            InitializeComponent();
            //gbAbout__disable();
            //gbMain__enable();
            lbIns3.Visible = false;
            btnSaveEncryptedText.Visible = false;
            lbCleartext.Visible = false;
            btnConfirmInputEncrypt.Enabled = false;
            btnConfirmInputEncrypt.Visible = false;
            lbIns2.Visible = false;
            txtEncryptInput.Visible = false;
            lbPasswordLengthWarn.Visible = false;
            gbConfirmPasswordSave.Visible = false;
            gbSaveETextConfirm.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            if (txtPasswordInput.TextLength == 16)
            {
                key = txtPasswordInput.Text;
                txtPasswordInput.Enabled = false;
                btnConfirmPassword.Enabled = false;
                btnConfirmInputEncrypt.Enabled = true;
                lbPasswordLengthWarn.Visible = false;
                btnGenPass.Enabled = false;
                lbIns2.Visible = true;
                txtEncryptInput.Visible = true;
                btnConfirmInputEncrypt.Visible = true;
            }

            else
            {
                lbPasswordLengthWarn.Visible = true;
                //lbIns1.Text = ("Please choose a password that is 16 characters in length.");
                //txtPass.Enabled = false;
                //Thread.Sleep(1000000);
                //txtPass.Enabled = false;
                //lbIns1.Text = ("1. Enter a password to encrypt the string with.");
                //lbPassLengthWarn.Visible = false;
            }
        }

        private void btnConfirmInputEncrypt_Click(object sender, EventArgs e)
        {
            var str = txtEncryptInput.Text;
            txtEncryptInput.Enabled = false;
            btnConfirmInputEncrypt.Enabled = false;

            var encryptedString = AesOperation.DecryptString(key, str);

            lbCleartext.Text = encryptedString;
            lbIns3.Visible = true;
            btnSaveEncryptedText.Visible = true;
            lbCleartext.Visible = true;

            saveetexta = encryptedString;
        }
    }
}
