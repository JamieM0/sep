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
using System.Linq;

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
            //btnOpen.Enabled = false;
            btnGo.Enabled = false;
            CenterToScreen();
        }

        private void frmEncryptFile_Load(object sender, EventArgs e)
        {

        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            string libEN = "pwLib.conf.aes";
            string libDE = "pwLib.conf";

            if(File.Exists(libEN))
            {
                string pw = Microsoft.VisualBasic.Interaction.InputBox("Input password library master password: ", "Password Library Decryption");
                frmHome.a.FileDecrypt(libEN, libDE, pw);
                current = DateTime.Now;
                string currentWritable = current.ToString("d");
                File.AppendAllText(libDE, $"\r\n{currentWritable}~{filePath}~{password}");
                frmHome.a.FileEncrypt(libDE, pw);
                File.Delete(libDE);
                btnSavePass.Enabled = false;
            }
            else
            {
                string pw = Microsoft.VisualBasic.Interaction.InputBox("Create a password for your password library: ", "Password Library Decryption");
                current = DateTime.Now;
                string currentWritable = current.ToString("d");
                File.WriteAllText(libDE, $"{currentWritable}~{filePath}~{password}");
                frmHome.a.FileEncrypt(libDE, pw);
                File.Delete(libDE);
                btnSavePass.Enabled = false;
            }
        }

        private void btnGenPass_Click(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=-<?>:{}[]";
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
            btnGenPass.Enabled = true;
            txtPasswordInput.Enabled = true;
            btnSavePass.Enabled = true;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = ($@"{Environment.SpecialFolder.MyDocuments}");
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.SafeFileName;
                    
                }
            }

            lbFilePath.Text = filePath;
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPasswordInput_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordInput.Text.Length > 0)
            {
                btnOpen.Enabled = true;
                //txtPasswordInput.Enabled = false;
                //btnGenPass.Enabled = false;
                //btnSavePass.Enabled = false;
                //btnConfirmPassword.Enabled = false;
                password = txtPasswordInput.Text;
                btnGo.Enabled = true;
            }
        }

        private void gbMain_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }
    }
}
