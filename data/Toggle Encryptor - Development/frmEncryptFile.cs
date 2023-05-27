using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;

namespace sep
{
    public partial class frmEncryptFile : Form
    {
        DateTime current;
        string savepassworda;
        string password;

        public frmEncryptFile()
        {
            InitializeComponent();
            btnOpen.Enabled = false;
            btnGo.Enabled = false;
            CenterToScreen();
        }

        private void frmEncryptFile_Load(object sender, EventArgs e)
        {

        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to save a text (.txt) file in your documents folder which is called your password and contains your password.\r\nNever share this with the encrypted file as this will allow any recipients to decrypt the file.", "Save Password", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                current = DateTime.Now;
                string currentWritable = current/*.*/.ToString("yyyy.MM.dd.HH.mm.ss");
                string locationPath = ($@"{docPath}\TEPPSaves\{currentWritable}");
                string locationPathIncFile = (/* +  + */$@"{locationPath}\{savepassworda}.txt");

                if (!Directory.Exists(locationPath))
                {
                    Directory.CreateDirectory(locationPath);
                }

                using (StreamWriter outputFile = new StreamWriter(locationPathIncFile))
                {
                    outputFile.WriteLine(savepassworda);
                }

                btnSavePass.Enabled = false;
            }
            else
            {
                
            }
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

            txtPasswordInput.PasswordChar = '\0';
            txtPasswordInput.Text = finalString;
            savepassworda = finalString;
        }

        private void btnConfirmInputEncrypt_Click(object sender, EventArgs e)
        {
            frmHome.a.FileEncrypt(filePath, password);
            password = "";
            if (!cbKeepOriginal.Checked)
            {
                File.Delete(filePath);
            }

            MessageBox.Show("The file has been encrypted!", "Encrypted!");

            Hide();
            new frmHome().Show();
        }

        string filePath;

        private void btnSavePasswordOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = ($@"{Environment.SpecialFolder.MyDocuments}");
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    btnGo.Enabled = true;
                }
            }

            lbFilePath.Text = filePath;
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            if(txtPasswordInput.Text.Length>0)
            {
                btnOpen.Enabled = true;
                txtPasswordInput.Enabled = false;
                btnGenPass.Enabled = false;
                btnSavePass.Enabled = false;
                btnConfirmPassword.Enabled = false;
                password = txtPasswordInput.Text;
            }
        }
    }
}
