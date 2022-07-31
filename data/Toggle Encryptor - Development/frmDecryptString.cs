using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Toggle_Encryptor___Development
{
    public partial class frmDecryptString : Form
    {
        string password;
        string inputtoencrypt;
        string key;
        string savepassworda;
        string saveetexta;
        string fileContentOpen = string.Empty;
        string filePathOpen = string.Empty;
        string Documents/* = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)*/;
        string TEPPSavesDirectory/* = ($@"{Documents}\TEPPSaves")*/;

        public frmDecryptString()
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
            /*string*/ Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            /*string*/ TEPPSavesDirectory = ($@"{Documents}\TEPPSaves");
            btnOpenEncrypt.Visible = false;
            btnCopy.Enabled = false;
            CenterToScreen();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            btnOpenEncrypt.Visible = true;
            btnSavePasswordOpen.Enabled = false;
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
            btnOpenEncrypt.Enabled = false;
            btnGoToMainMenu.Enabled = true;
            btnCopy.Enabled = true;
        }

        private void btnSavePasswordOpen_Click(object sender, EventArgs e)
        {
            //var fileContentOpen = string.Empty;
            //var filePathOpen = string.Empty;
            //string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string TEPPSavesDirectory = ($@"{Documents}\TEPPSaves");

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //From https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0
                //openFileDialog.InitialDirectory = @"c:\\";
                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = ($@"{TEPPSavesDirectory}");
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePathOpen = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContentOpen = reader.ReadToEnd();
                    }
                }
            }

            string fileContentOpenSubstring = fileContentOpen.Substring(0, 16);

            //MessageBox.Show(fileContentOpen, "File Content at path: " + filePathOpen, MessageBoxButtons.OK);
            txtPasswordInput.Text = fileContentOpenSubstring;
        }

        private void btnOpenEncrypt_Click(object sender, EventArgs e)
        {
            //var fileContentOpen = string.Empty;
            //var filePathOpen = string.Empty;
            //string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string TEPPSavesDirectory = ($@"{Documents}\TEPPSaves");

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //From https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0
                //openFileDialog.InitialDirectory = @"c:\\";
                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = ($@"{TEPPSavesDirectory}");
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePathOpen = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContentOpen = reader.ReadToEnd();
                    }
                }
            }

            //MessageBox.Show(fileContentOpen, "File Content at path: " + filePathOpen, MessageBoxButtons.OK);
            txtEncryptInput.Text = fileContentOpen;
        }

        private void btnGoToMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText($"{lbCleartext.Text}");
            MessageBox.Show($"Copied {lbCleartext.Text} to clipboard!");

       
        }
    }
}
