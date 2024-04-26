using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using Google.Authenticator;
using QRCoder;
using System.Data.SqlClient;
using System.Data;
using sep.Models;

namespace sep
{
    public partial class frmFunctionScreen : Form
    {
        bool funcEncrypt = OtherOperations.funcEncrypt;
        string funcText = "Encrypt";
        string[] filePath;
        string[] fileName;
        string password;
        bool saveToLibrary = false;
        bool usingMFA = false;
        int pwIdentifier;
        public frmFunctionScreen()
        {
            InitializeComponent();
            CenterToScreen();
            if (!funcEncrypt)
            {
                this.Text = "SEP: Decrypt File";
                funcText = "Decrypt";
                btnGenPassword.Text = "Use Guessr";
                btnPWLibFunc.Text = "Open Password";
                cbDeleteAsk.Text = "Delete the selected file after \ndecryption.";
                btnGo.Text = "Decrypt";
            }
            lbTitle.Text = $"Simple Encryption Program: {funcText} File";
            lbIns1.Text = $"Please select a file to {funcText.ToLower()}";
            lbIns2.Text = $"Enter a password to {funcText.ToLower()} the file";
            lbIns3.Text = $"Ready to {funcText.ToLower()}!";
            pnlFileSelect.Location = new Point(350, 92);
            pnlPasswordInput.Location = new Point(570, 92);
            pnlFinalSteps.Location = new Point(760, 92);
            pbCopyIcon.Image = Properties.Resources.copy_icon;
            //pnlShareFile.Visible = false;
            lbFileName.TextAlign = ContentAlignment.MiddleCenter;
            this.AllowDrop = true;
            Options options = new Options();
            options = options.ReadFromFile();
            if (!options.DebugMode)
            {
                btnPWLibFunc.Enabled = false;
            }
        }

        private void frmFunctionScreen_Load(object sender, EventArgs e)
        {
            Options options = new Options();
            options = options.ReadFromFile();
            if (options.EncryptFileNames)
                btnPWLibFunc.Enabled = false;
        }

        private void animateSection(Panel panel, Point newPoint, int speed)
        {
            //Co-Ordinates
            //Panel 1: 350,170; 170,170; 6,170
            //Panel 2:      //; 570,170; 383,170
            //Panel 3:      //;      //; 760,170
            Point current = panel.Location;
            int diffX = current.X - newPoint.X;
            for (int i = 0; i < diffX; i++)
            {
                panel.Location = new Point(panel.Location.X - 1, panel.Location.Y);
                panel.Refresh();
            }
        }
        private void animateSection(Panel pnl1, Point pt1, int sp1, Panel pnl2, Point pt2, int sp2)
        {
            Point cur1 = pnl1.Location;
            int diffX1 = cur1.X - pt1.X;
            Point cur2 = pnl2.Location;
            int diffX2 = cur2.X - pt2.X;
            for (int i = 0; i < diffX1; i += 3)
            {
                pnl1.Location = new Point(pnl1.Location.X - 3, pnl1.Location.Y);
                if (i < diffX2)
                    pnl2.Location = new Point(pnl2.Location.X - 3, pnl2.Location.Y);
                pnl1.Refresh();
                pnl2.Refresh();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";
            ofd.Title = $"Choose file(s) to {funcText.ToLower()}";
            ofd.Multiselect = true;
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (!funcEncrypt && ofd.FileNames.Length > 1)
                    {
                        MessageBox.Show("You can only decrypt one file at a time.", "SEP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        filePath = ofd.FileNames;
                        fileName = ofd.SafeFileNames;
                    }
                }
                lbFileName.Text = "";
                if (filePath.Length <= 3)
                {

                    foreach (string item in fileName)
                    {
                        int itemSize = TextRenderer.MeasureText(item, lbFileName.Font).Width;
                        string itemToAdd = item;
                        lbFileName.Text += itemToAdd + "\r\n";
                    }
                    lbFileName.Text += ". . .\r\n" + filePath.Length + " files selected.";
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        string item = fileName[i];
                        int itemSize = TextRenderer.MeasureText(item, lbFileName.Font).Width;
                        string itemToAdd = item;
                        lbFileName.Text += itemToAdd + "\r\n";
                    }
                    lbFileName.Text += ". . .\r\n" + filePath.Length + " files selected.";
                }
                int sizeOfFileName = TextRenderer.MeasureText(fileName.OrderByDescending(s => s.Length).First(), lbFileName.Font).Width;
                //lbFileName.Location = new Point((pnlFileSelect.Width / 2) - sizeOfFileName / 2, 150);
                lbFileName.Visible = true;

                //Center the label in the panel
                lbFileName.Location = new Point((pnlFileSelect.Width / 2) - (lbFileName.Width / 2), 164);

                if (fileName.Length > 1)
                    btnUseAuthenticator.Enabled = false;

                if (lbFileName.Text.Length > 0)
                {
                    //Animate to left (2 sections)
                    animateSection(pnlFileSelect, new Point(170, 92), 10);
                    pnlPasswordInput.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry about that! There was a problem selecting this file. Please try again. \r\n More Details: " + ex.Message, "SEP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbPWReveal_MouseDown(object sender, MouseEventArgs e)
        {
            pbPWReveal.Image = Properties.Resources.password_reveal_active;
            txtPassword.PasswordChar = '\0';
        }

        private void pbPWReveal_MouseUp(object sender, MouseEventArgs e)
        {
            pbPWReveal.Image = Properties.Resources.password_reveal_default;
            txtPassword.PasswordChar = '*';
        }

        private void EncryptConfirmPassword()
        {
            password = txtPassword.Text;
            int extensionPoint = fileName[0].LastIndexOf('.');
            if ((fileName[0].EndsWith(".mfa") || DatabaseHelper.SearchDatabase(fileName[0].Substring(0, extensionPoint))) && !funcEncrypt)
            {
                pnlAuthDecrypt.Visible = true;
                hideMainElements();
            }
            else
            {
                animateSection(pnlFileSelect, new Point(6, 92), 20, pnlPasswordInput, new Point(383, 92), 20);
                pnlFinalSteps.Visible = true;
            }

            if (!funcEncrypt)
            {
                btnUseAuthenticator.Visible = false;
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            txtPassword.Enabled = false;
            EncryptConfirmPassword();
        }

        private void btnGenPassword_Click(object sender, EventArgs e)
        {
            if (funcEncrypt)
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=-<?>:{}[]";
                var stringChars = new char[16];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                txtPassword.Text = new String(stringChars);
            }
            else
            {
                hideMainElements();
                pnlGuesser.Visible = true;
            }
        }

        private void btnPWLibFunc_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options = options.ReadFromFile();
            if (funcEncrypt && !options.DebugMode)
            {
                saveToLibrary = true;
                txtPassword.Enabled = false;

                hideMainElements();
                pnlLibraryPassword.Visible = true;
            }
            else
            {
                //Open Password
                hideMainElements();
                pnlLibraryPassword.Visible = true;
            }

        }

        string secretKey;
        private void btnUseAuthenticator_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("SEP uses the GoogleAuthenticator library to help link the encrypted file and your authenticator (MFA) app.\r\nA private key is generated and provided to your mobile device via the QR code. It is stored securely on your local PC using DPAPI, usually a servic like Google or Twitter will store this key on their servers.\r\nThis means that the file cannot be decrypted without having this key, so you cannot share it. It also means that anyone with access to your Windows PC has the potential to access this key.\r\nDo not use this as a replacement for a strong password, both are important.", "How do authenticator (MFA) apps work in SEP?");
            if (MessageBox.Show("Files using authenticator (MFA) apps cannot be shared.\r\nAnyone with access to your Windows PC can access the private key.\r\nDo Not use as replacement for strong password.\r\nLearn More: https://go.jmatthews.uk/sep/mfa\r\n\r\nWould you like to continue?", "How do authenticator (MFA) apps work in SEP?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                btnUseAuthenticator.Enabled = false;
                pnlAuthApp.Visible = true;
                hideMainElements();

                string uuid = $"{fileName}";
                secretKey = GenerateRandomSecretKey();
                string uri = CreateAuthenticatorUri(uuid, secretKey);
                GenerateQRCode(uri);
            }
        }

        string GenerateRandomSecretKey()
        {
            const int secretKeyLength = 16; // Choose the desired length, e.g., 20 characters (160 bits).
            const string base32Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567"; // Base32 character set.

            byte[] buffer = new byte[secretKeyLength];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(buffer);
            }

            char[] secretKeyChars = new char[secretKeyLength];
            for (int i = 0; i < secretKeyLength; i++)
            {
                secretKeyChars[i] = base32Characters[buffer[i] % base32Characters.Length];
            }

            return new string(secretKeyChars);
        }
        string CreateAuthenticatorUri(string userName, string secretKey)
        {
            // The URI follows the format: otpauth://totp/{UserName}?secret={SecretKey}&issuer={YourAppName}
            //return $"otpauth://totp/{Uri.EscapeDataString("testuser")}?secret={Uri.EscapeDataString(secretKey)}&issuer={Uri.EscapeDataString($"SEP")}";
            return $"otpauth://totp/{userName}?secret={secretKey}&issuer=SEP";
        }
        void GenerateQRCode(string uri)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(uri, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20); // Adjust the size of the QR code as needed.

            // Now you can display the qrCodeImage to the user.
            pbQRAuthSetup.Image = qrCodeImage;
        }
        bool VerifyOTP(string secretKey, string userOTP)
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            return tfa.ValidateTwoFactorPIN(secretKey, userOTP, true);
        }

        private void btnCancelMFASetup_Click(object sender, EventArgs e)
        {
            pnlAuthApp.Visible = false;
            showMainElements();
        }
        //string nextID = "";
        private void btnConfirmAuthSetup_Click(object sender, EventArgs e)
        {
            string testCode = txtAuthSetupVerify.Text;
            bool validCode = VerifyOTP(secretKey, testCode);
            if (!validCode)
                MessageBox.Show("Sorry, that didn't work, please try again later!", "Invalid Code!");
            else
            {
                //nextID = Convert.ToString(DatabaseHelper.CountFileData() + 1);
                //fileName[0] = nextID + "-" + fileName;
                DatabaseHelper.InsertFileData(fileName[0], secretKey);

                pnlAuthApp.Visible = false;
                showMainElements();
                usingMFA = true;
            }
        }

        private void btnAuthDecryptSubmit_Click(object sender, EventArgs e)
        {
            string testCode = txtAuthConfirmDecrypt.Text;
            string secretKey = DatabaseHelper.GetSecretKey(Convert.ToInt32(fileName[0].Split('-')[0]));
            bool validCode = VerifyOTP(secretKey, testCode);
            if (!validCode)
                MessageBox.Show("Sorry, that didn't work, please try again later!", "Invalid Code!");
            else
            {
                pnlAuthDecrypt.Visible = false;
                showMainElements();
                animateSection(pnlFileSelect, new Point(6, 92), 20, pnlPasswordInput, new Point(383, 92), 20);
                usingMFA = true;
            }
        }

        private void btnAuthDecryptCancel_Click(object sender, EventArgs e)
        {
            pnlAuthDecrypt.Visible = false;
            showMainElements();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcEncrypt)
                {
                    if (usingMFA)
                    {
                        string secretKey = DatabaseHelper.GetSecretKey(Convert.ToInt32(fileName[0].Split('-')[0]));
                        password += "⌀" + secretKey;
                    }
                    //if (saveToLibrary)
                    //{
                    //    nextID += "⌀" + pwIdentifier;
                    //}

                    for (int i = 0; i < fileName.Length; i++)
                    {
                        AES.FileEncrypt(filePath[i], password, usingMFA, "0");

                        if (cbDeleteAsk.Checked)
                        {
                            AesOperation.SecureDelete(filePath[i], 3);
                        }
                    }

                    password = "";
                    MessageBox.Show("The file(s) have been encrypted successfully!", "Encrypted!");
                    //pnlShareFile.Visible = true;
                    Hide();
                    new frmHome().Show();
                }
                else
                {
                    txtPassword.Enabled = false;
                    if (usingMFA)
                    {
                        string secretKey = DatabaseHelper.GetSecretKey(Convert.ToInt32(fileName[0].Split('-')[0]));
                        password += "⌀" + secretKey;
                    }

                    for (int i = 0; i < fileName.Length; i++)
                    {
                        string filePathUnencrypted;
                        filePathUnencrypted = filePath[i].Substring(0, filePath[i].Length - 4);
                        string directory = Path.GetDirectoryName(filePathUnencrypted);
                        string oldFileName = Path.GetFileName(filePathUnencrypted);
                        int firstDashIndex = oldFileName.IndexOf("-");
                        string newFileName = $"{oldFileName.Substring(firstDashIndex + 1)}";

                        filePathUnencrypted = Path.Combine(directory, newFileName);
                        AES.FileDecrypt(filePath[i], filePathUnencrypted, password);
                    }
                    MessageBox.Show("The file(s) has been decrypted successfully!", "Decrypted!");

                    if (cbDeleteAsk.Checked)
                    {
                        if (MessageBox.Show("File decryption attempted. If you entered the incorrect password, the decrypted file WILL be corrupted and is likely unrecoverable.\r\nClick \"Yes\" to delete the encypted file (send it to the recycle bin)\r\nDo you want to delete the encrypted file?", "Warning! Entering the incorrect password WILL result in a corrupted file!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            for (int i = 0; i < fileName.Length; i++)
                            {
                                Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(filePath[i], Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                            }
                        }
                    }
                    
                    Hide();
                    new frmHome().Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was a problem completing the operation!\r\n\r\nMore Details: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hideMainElements()
        {
            pnlFileSelect.Visible = false;
            pnlPasswordInput.Visible = false;
            pnlFinalSteps.Visible = false;
            btnBack.Visible = false;
            pnlLibraryPassword.Visible = false;
        }
        private void showMainElements()
        {
            pnlFileSelect.Visible = true;
            pnlPasswordInput.Visible = true;
            pnlFinalSteps.Visible = true;
            btnBack.Visible = true;
            pnlLibraryPassword.Visible = true;
        }

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
            if (dirPath != null)
            {
                string[] guesses = txtGuesses.Lines;
                try
                {
                    foreach (string guess in guesses)
                    {
                        string output = $@"{dirPath}\{guess}_{fileName[0].Substring(0, fileName[0].Length - 4)}";
                        AES.FileDecrypt(filePath[0], output, guess);
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

        private void btnCancelGuesser_Click(object sender, EventArgs e)
        {
            pnlGuesser.Visible = false;
            showMainElements();
            pnlFinalSteps.Visible = false;
            pnlLibraryPassword.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                btnPWLibFunc.Enabled = true;
            }
            else
            {
                btnPWLibFunc.Enabled = false;
            }
        }

        private void pbCopyIcon_MouseDown(object sender, MouseEventArgs e)
        {
            pbCopyIcon.Image = Properties.Resources.copy_icon_active;
        }

        private void pbCopyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            pbCopyIcon.Image = Properties.Resources.copy_icon;
        }

        private void pbCopyIcon_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);
        }

        private void btnPWLibReveal_MouseDown(object sender, MouseEventArgs e)
        {
            txtPWLib.PasswordChar = '\0';
        }

        private void btnPWLibReveal_MouseUp(object sender, MouseEventArgs e)
        {
            txtPWLib.PasswordChar = '*';
        }
        string pwlibmaster = "";
        private void button1_Click(object sender, EventArgs e)
        {
            showMainElements();
            pnlFinalSteps.Visible = false;
            pnlLibraryPassword.Visible = false;
            pwlibmaster = txtPWLib.Text;
            if (funcEncrypt)
            {
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
                    for (int i = 0; i < fileName.Length; i++)
                    {
                        pwIdentifier = DatabaseHelperPL.CountPasswordData();
                        DatabaseHelperPL.InsertPWLib(fileName[i] + "~" + File.GetCreationTime(filePath[i]), txtPassword.Text);
                    }
                    DatabaseHelperPL.EncryptPWLib(pwlibmaster);
                    btnPWLibFunc.Enabled = false;
                    btnGenPassword.Enabled = false;
                    btnConfirm.Enabled = false;
                    btnOpenFile.Enabled = false;
                    EncryptConfirmPassword();
                }
                catch (Exception ex)
                {
                    if (ex.Message == "password_incorrect")
                    {
                        MessageBox.Show("The master password you entered was incorrect!", "Error!");
                        txtPassword.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Sorry, there was a problem with the password library. Please try again.\r\nMore Details: " + ex.Message, "Error!");
                        txtPassword.Enabled = true;
                    }
                }
            }
            else
            {
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
                    txtPassword.Text = DatabaseHelperPL.GetPassword(fileName[0].Substring(0, fileName[0].Length - 4) + "~" + File.GetCreationTime(filePath[0]));
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
        }

        private void cbDeleteAsk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDeleteAsk.Checked)
            {
                if (MessageBox.Show($"Are you sure you want to delete this file?\r\n\r\nThe original file will be securely deleted after it has been {funcText.ToLower()}ed.\r\n\r\nIt will be overwritten 3 times, and become unrecoverable.\r\nThis is the only warning.", "Delete original file?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    cbDeleteAsk.Checked = false;
                }
            }
        }

        private void lbFileName_DragDrop(object sender, DragEventArgs e)
        {
            // Check if the data being dragged in is a file (or files)
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && lbFileName.Text == "")
                e.Effect = DragDropEffects.Copy; // Show a "copy" cursor
            else
                e.Effect = DragDropEffects.None; // Show a "stop" cursor
        }

        private void frmFunctionScreen_DragDrop(object sender, DragEventArgs e)
        {
            // Get the filenames of all files being dragged into the form
            filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
            fileName = (string[])e.Data.GetData(DataFormats.FileDrop);

            for (int i = 0; i < fileName.Length; i++)
            {
                fileName[i] = Path.GetFileName(filePath[i]);
            }

            lbFileName.Text = "";
            if (filePath.Length <= 3)
            {

                foreach (string item in fileName)
                {
                    int itemSize = TextRenderer.MeasureText(item, lbFileName.Font).Width;
                    string itemToAdd = item;
                    lbFileName.Text += itemToAdd + "\r\n";
                }
                lbFileName.Text += ". . .\r\n" + filePath.Length + " files selected.";
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    string item = fileName[i];
                    int itemSize = TextRenderer.MeasureText(item, lbFileName.Font).Width;
                    string itemToAdd = item;
                    lbFileName.Text += itemToAdd + "\r\n";
                }
                lbFileName.Text += ". . .\r\n" + filePath.Length + " files selected.";
            }
            int sizeOfFileName = TextRenderer.MeasureText(fileName.OrderByDescending(s => s.Length).First(), lbFileName.Font).Width;
            //lbFileName.Location = new Point((pnlFileSelect.Width / 2) - sizeOfFileName / 2, 150);
            lbFileName.Visible = true;

            //Center the label in the panel
            lbFileName.Location = new Point((pnlFileSelect.Width / 2) - (lbFileName.Width / 2), 164);

            if (fileName.Length > 1)
                btnUseAuthenticator.Enabled = false;

            if (lbFileName.Text.Length > 0)
            {
                //Animate to left (2 sections)
                animateSection(pnlFileSelect, new Point(170, 92), 10);
                pnlPasswordInput.Visible = true;
            }
        }

        private void frmFunctionScreen_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the data being dragged in is a file (or files)
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && pnlPasswordInput.Visible == false)
                e.Effect = DragDropEffects.Copy; // Show a "copy" cursor
            else
                e.Effect = DragDropEffects.None; // Show a "stop" cursor
        }
    }
}
