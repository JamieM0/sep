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

        public frmDecryptFile()
        {
            InitializeComponent();
            txtPasswordInput.Enabled = false;
            btnOpen.Enabled = true;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string fileName = "";
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
    }
}
