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

        bool funcEncrypt = true;
        public frmStreamedFunction()
        {
            InitializeComponent();
            CenterToScreen();
            filePath = OtherOperations.filePath;
            fileName = Path.GetFileName(filePath);
            if (Path.GetExtension(filePath).Contains("lib"))
            {
                funcEncrypt = false;
            }
            
            if (!funcEncrypt)
            {
                btnFunction.Text = "Decrypt";
                btnPWLibFunc.Text = "Open Password";
            }
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
            if (funcEncrypt)
            {
                if(savingPW)
                {
                    string nextID = "0⌀" + pwIdentifier;
                    AES.FileEncrypt(filePath, txtPassword.Text, false, nextID);
                }
                else
                {
                    AES.FileEncrypt(filePath, txtPassword.Text, false, "0");
                }
                
                if (!cbSaveOriginal.Checked)
                {
                    File.Delete(filePath);
                }

                MessageBox.Show("The file has been encrypted!", "Encrypted!");
                Application.Exit();
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

                        AES.FileDecrypt(filePath, filePathUnencrypted, txtPassword.Text);

                        if (!cbSaveOriginal.Checked)
                        {
                            File.Delete(filePath);
                        }

                        MessageBox.Show("The file has been decrypted!", "Decrypted!");

                        Application.Exit();
                    }
                }
                else
                {
                    txtPassword.Enabled = false;
                    string filePathUnencrypted;
                    filePathUnencrypted = filePath.Substring(0, filePath.Length - 4);

                    AES.FileDecrypt(filePath, filePathUnencrypted, txtPassword.Text);

                    MessageBox.Show("The file has been decrypted!", "Decrypted!");

                    Application.Exit();

                }
            }
        }

        private void frmStreamedFunction_Load(object sender, EventArgs e)
        {

        }

        int pwIdentifier;
        string pwlibmaster;
        bool savingPW=false;
        private void btnPWLibFunc_Click(object sender, EventArgs e)
        {
            if (!funcEncrypt)
            {
                //Open prompt to enter master password for the Password Library using Message Box
                pwlibmaster = Microsoft.VisualBasic.Interaction.InputBox("Enter the master password for the Password Library.", "Password Library", "", -1, -1);

                try
                {
                    if (File.Exists(DatabaseHelperPL.EncryptedDatabaseFilePath))
                    {
                        DatabaseHelperPL.DecryptPWLib(pwlibmaster);
                        if (DatabaseHelperPL.CountPasswordData() == -1)
                        {
                            throw new Exception("password_incorrect");
                        }
                    }
                    pwIdentifier = Convert.ToInt32(Path.GetExtension(filePath).Substring(4));
                    txtPassword.Text = DatabaseHelperPL.GetPassword(pwIdentifier);
                    DatabaseHelperPL.EncryptPWLib(pwlibmaster);
                }
                catch (Exception ex)
                {
                    if (ex.Message == "password_incorrect")
                    {
                        MessageBox.Show("The master password you entered was incorrect!", "Error!");
                        File.Delete(DatabaseHelperPL.DatabaseFileName);
                    }
                    else
                    {
                        MessageBox.Show("Sorry, there was a problem with the password library. Please try again.\r\nMore Details: " + ex.Message, "Error!");
                    }
                }
            }
            else
            {
                //Open prompt to enter master password for the Password Library using Message Box
                pwlibmaster = Microsoft.VisualBasic.Interaction.InputBox("Enter the master password for the Password Library.", "Password Library", "", -1, -1);

                try
                {
                    if (File.Exists(DatabaseHelperPL.EncryptedDatabaseFilePath))
                    {
                        DatabaseHelperPL.DecryptPWLib(pwlibmaster);
                        //Check if decrypted database is valid (has correct pw)
                        if (DatabaseHelperPL.CountPasswordData() == -1)
                        {
                            throw new Exception("password_incorrect");
                        }
                    }
                    pwIdentifier = DatabaseHelperPL.CountPasswordData();
                    DatabaseHelperPL.InsertPWLib(filePath, txtPassword.Text);
                    DatabaseHelperPL.EncryptPWLib(pwlibmaster);
                    btnPWLibFunc.Enabled = false;
                    btnGenPassword.Enabled = false;
                    savingPW = true;
                }
                catch (Exception ex)
                {
                    if (ex.Message == "password_incorrect")
                    {
                        MessageBox.Show("The master password you entered was incorrect!", "Error!");
                    }
                    else
                    {
                        MessageBox.Show("Sorry, there was a problem with the password library. Please try again.\r\nMore Details: " + ex.Message, "Error!");
                    }
                }
            }
        }
    }
}
