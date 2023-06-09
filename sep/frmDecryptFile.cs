using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sep
{
    public partial class frmDecryptFile : Form
    {

        string filePath;
        string password;
        string fileName = "";

        public frmDecryptFile()
        {
            InitializeComponent();
            txtPasswordInput.Enabled = false;
            btnOpen.Enabled = true;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = ($@"{Environment.SpecialFolder.MyDocuments}");
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    fileName = openFileDialog.SafeFileName;
                    btnGo.Enabled = true;
                    btnGuesser.Enabled = true;
                }
            }

            lbFilePath.Text = fileName;

            if (filePath.Length > 0)
            {
                btnConfirmPassword.Enabled = false;
                txtPasswordInput.Enabled = true;
                btnOpen.Enabled = true;
            }
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!cbKeepOriginal.Checked)
            {
                if (MessageBox.Show("Entering the incorrect password WILL result in a corrupted file!\r\n\r\nYou should keep the encrypted copy as well, just in case.\r\n\r\nClicking 'Yes' may be risky. If you're unsure, click 'No', and choose to keep the encrypted file!\r\n\r\nDo you wish to proceed?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    txtPasswordInput.Enabled = false;

                    password = txtPasswordInput.Text;

                    string filePathUnencrypted;

                    filePathUnencrypted = filePath.Substring(0, filePath.Length - 4);

                    frmHome.a.FileDecrypt(filePath, filePathUnencrypted, password);

                    if (!cbKeepOriginal.Checked)
                    {
                        File.Delete(filePath);
                    }

                    MessageBox.Show("The file has been decrypted!", "Decrypted!");

                    Hide();
                    new frmHome().Show();
                }
            }
            else
            {
                txtPasswordInput.Enabled = false;

                password = txtPasswordInput.Text;

                string filePathUnencrypted;

                filePathUnencrypted = filePath.Substring(0, filePath.Length - 4);

                frmHome.a.FileDecrypt(filePath, filePathUnencrypted, password);

                MessageBox.Show("The file has been decrypted!", "Decrypted!");

                Hide();
                new frmHome().Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }

        private void btnGuesser_Click(object sender, EventArgs e)
        {
            gbMain.Visible = false;
            pnlGuesser.Visible = true;
            btnBackToMain.Visible = true;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            pnlGuesser.Visible = false;
            gbMain.Visible = true;
            btnBackToMain.Visible = false;
        }

        //Choose a directory
        string dirPath;
        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dirPath = fbd.SelectedPath;
                    lbSelectedFolder.Text = dirPath;
                }
            }
        }

        private void btnSkipFolder_Click(object sender, EventArgs e)
        {
            //Set dirPath as Documents/SEP/Guesser/fileName
            dirPath = $@"Guesser\{fileName}";
            Directory.CreateDirectory($@"Guesser\{fileName}\");
            lbSelectedFolder.Text = dirPath;
        }

        private void btnGuessGo_Click(object sender, EventArgs e)
        {
            if(dirPath!=null)
            {
                string[] guesses = txtGuesses.Lines;
                try
                {
                    foreach (string guess in guesses)
                    {
                        string output = $@"{dirPath}\{guess}_{fileName.Substring(0, fileName.Length - 4)}";
                        frmHome.a.FileDecrypt(filePath, output, guess);
                    }
                    MessageBox.Show($"The file has been decrypted, and {guesses.Length} copies were made!", "Decrypted!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Hide();
                    new frmHome().Show();
                }
            }
            else
            {
                MessageBox.Show("Please select a folder to save the decrypted files to!", "Error!");
            }
        }
    }
}
