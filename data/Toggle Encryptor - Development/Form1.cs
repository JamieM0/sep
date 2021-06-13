using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toggle_Encryptor___Development
{
    public partial class Form1 : Form
    {
        string pass;
        string inputtoencrypt;
        string key;
        string savepassworda;
        string saveetexta;

        public Form1()
        {
            InitializeComponent();
            gbAbout__disable();
            gbMain__enable();
            lbIns3.Visible = false;
            btnSaveEncryptedText.Visible = false;
            lbEncryptOutput.Visible = false;
            btnConfirmInputEncrypt.Enabled = false;
            btnConfirmInputEncrypt.Visible = false;
            lbIns2.Visible = false;
            txtEncryptInput.Visible = false;
            lbPassLengthWarn.Visible = false;
            gbConfirmPasswordSave.Visible = false;
            gbSaveETextConfirm.Visible = false;
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
            if (txtPass.TextLength == 16)
            {
                key = txtPass.Text;
                txtPass.Enabled = false;
                btnConfirmPass.Enabled = false;
                btnConfirmInputEncrypt.Enabled = true;
                lbPassLengthWarn.Visible = false;
                btnGenPass.Enabled = false;
                lbIns2.Visible = true;
                txtEncryptInput.Visible = true;
                btnConfirmInputEncrypt.Visible = true;
            }

            else
            {
                lbPassLengthWarn.Visible = true;
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

            var encryptedString = AesOperation.EncryptString(key, str);

            lbEncryptOutput.Text = encryptedString;
            lbIns3.Visible = true;
            btnSaveEncryptedText.Visible = true;
            lbEncryptOutput.Visible = true;

            saveetexta = encryptedString;
        }

        private void btnGenPass_Click(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[16];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            txtPass.PasswordChar = '\0';
            txtPass.Text = finalString;
            savepassworda = finalString;
        }

        //public static async Task ExampleAsync()
        //{
        //    string textacode = ("a");

        //    await File.WriteAllTextAsync("PasswordForEncryption.txt", savepassworda);
        //}

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            gbConfirmPasswordSave.Visible = true;

            //string savepasswordconfirmmessage = ("You are about to save a text (.txt) file in your documents folder which is called your password and contains your password.");
            //string savepasswordconfirmtitle = ("Save password?");

            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show(savepasswordconfirmmessage, savepasswordconfirmtitle);

            //if (result == DialogResult.Yes)
            //{
            //    this.Close();
            //    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, $"{savepassworda}.txt")))
            //    {
            //        outputFile.WriteLine(savepassworda);
            //    }

            //    btnSavePass.Enabled = false;
            //}
            
            //else
            //{
            //    this.Close();
            //}
            
        }

        private void btnSaveEncryptedText_Click(object sender, EventArgs e)
        {
            gbSaveETextConfirm.Visible = true;
            //string savepasswordconfirmmessage = ("You are about to save a text (.txt) file in your documents folder which is called TEPPetext and contains your encrypted text.");
            //string savepasswordconfirmtitle = ("Save password?");

            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show(savepasswordconfirmmessage, savepasswordconfirmtitle);

            //if (result == DialogResult.Yes)
            //{
            //    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "TEPPetext.txt")))
            //    {
            //        outputFile.WriteLine(saveetexta);
            //    }

            //    btnSaveEncryptedText.Enabled = false;
            //}

            //else
            //{
            //    this.Close();
            //}


        }

        private void btnSavePasswordConfirmYes_Click(object sender, EventArgs e)
        {
            gbConfirmPasswordSave.Visible = false;
            
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, $"{savepassworda}.txt")))
            {
                outputFile.WriteLine(savepassworda);
            }

            btnSavePass.Enabled = false;
        }

        private void btnSavePasswordConfirmNo_Click(object sender, EventArgs e)
        {
            gbConfirmPasswordSave.Visible = false;
        }

        private void btnSaveETextConfirmNo_Click(object sender, EventArgs e)
        {
            gbSaveETextConfirm.Visible = false;
        }

        private void btnSaveETextConfirmYes_Click(object sender, EventArgs e)
        {
            gbSaveETextConfirm.Visible = false;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "TEPPEText.txt")))
            {
                outputFile.WriteLine(saveetexta);
            }

            btnSaveEncryptedText.Enabled = false;
        }
    }
}
