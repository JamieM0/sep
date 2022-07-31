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

namespace Toggle_Encryptor___Development
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
            if (filePath.Length>0)
            {
                btnConfirmPassword.Enabled = false;
                txtPasswordInput.Enabled = true;
                btnOpen.Enabled = true;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!cbKeepOriginal.Checked)
            {
                if (MessageBox.Show("Entering the incorrect password WILL result in a corrupted file!\r\nIt is strongly recommended to keep the encrypted file in case you make a mistake!\r\nClicking 'Yes' will proceed WITHOUT keeping the encrypted copy.\r\nIf you are unsure of what to do, click 'No', then check the box and click 'Decrypt' again!", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
        }
    }
}
