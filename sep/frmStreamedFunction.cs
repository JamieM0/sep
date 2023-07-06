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
    public partial class frmStreamedFunction : Form
    {
        DateTime current = new DateTime();
        string filePath;
        string fileName;

        public frmStreamedFunction()
        {
            InitializeComponent();
            CenterToScreen();
            filePath = OtherOperations.filePath;
            fileName = Path.GetFileName(filePath);
            if(fileName.EndsWith(".aes"))
                btnFunction.Text = "Decrypt";
        }

        private void btnGenPassword_Click(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=-<?>:{}[]";
            var stringChars = new char[16];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            txtPassword.Text = finalString;
        }
        
        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            //OtherOperations.SaveToLibrary(fileName, txtPassword.Text);
            Clipboard.SetText(txtPassword.Text);
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (btnFunction.Text == "Encrypt")
            {
                frmHome.a.FileEncrypt(filePath, txtPassword.Text);
                if (!cbSaveOriginal.Checked)
                {
                    File.Delete(filePath);
                }

                MessageBox.Show("The file has been encrypted!", "Encrypted!");
            }
            else
            {
                if (!cbSaveOriginal.Checked)
                {
                    if (MessageBox.Show("Entering the incorrect password WILL result in a corrupted file!\r\n\r\nYou should keep the encrypted copy as well, just in case.\r\n\r\nClicking 'Yes' may be risky. If you're unsure, click 'No', and choose to keep the encrypted file!\r\n\r\nDo you wish to proceed?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        txtPassword.Enabled = false;
                        string filePathUnencrypted;
                        filePathUnencrypted = filePath.Substring(0, filePath.Length - 4);

                        frmHome.a.FileDecrypt(filePath, filePathUnencrypted, txtPassword.Text);

                        if (!cbSaveOriginal.Checked)
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
                    txtPassword.Enabled = false;
                    string filePathUnencrypted;
                    filePathUnencrypted = filePath.Substring(0, filePath.Length - 4);

                    frmHome.a.FileDecrypt(filePath, filePathUnencrypted, txtPassword.Text);

                    MessageBox.Show("The file has been decrypted!", "Decrypted!");

                    Hide();
                    new frmHome().Show();
                }
            }
        }
    }
}
