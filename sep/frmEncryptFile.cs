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
using Google.Authenticator;
using QRCoder;

namespace sep
{
    public partial class frmEncryptFile : Form
    {
        DateTime current;
        string savepassworda;
        string password;
        bool usingMFA = false;

        public frmEncryptFile()
        {
            InitializeComponent();
            //btnOpen.Enabled = false;
            btnGo.Enabled = false;
            CenterToScreen();
            BringToFront();
            pnlAuthApp.Visible = false;
        }

        private void frmEncryptFile_Load(object sender, EventArgs e)
        {

        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            OtherOperations.SaveToLibrary(safeFilePath, password);
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
            if(usingMFA)
            {
                string secretKey = File.ReadAllText(OtherOperations.storeLoc + $"\\privateKeys\\{lbFilePath.Text}.key");
                password += "⌀"+secretKey;
            }
            frmHome.a.FileEncrypt(filePath, password,usingMFA,0);
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
        string safeFilePath;

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
                    filePath = openFileDialog.FileName;
                    safeFilePath = openFileDialog.SafeFileName;
                }
            }

            lbFilePath.Text = safeFilePath;
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPasswordInput_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordInput.Text.Length > 0)
            {
                btnOpen.Enabled = true;
                password = txtPasswordInput.Text;
                btnAuthenticator.Enabled = true;
                btnGo.Enabled = true;
            }
        }

        private void gbMain_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(pnlAuthApp.Visible)
            {
                pnlAuthApp.Visible = false;
                gbMain.Visible = true;
            }
            else
            {
                Hide();
                new frmHome().Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("SEP uses the GoogleAuthenticator library to help link the encrypted file and your authenticator (MFA) app.\r\nA private key is generated and provided to your mobile device via the QR code. It is stored securely on your local PC using DPAPI, usually a servic like Google or Twitter will store this key on their servers.\r\nThis means that the file cannot be decrypted without having this key, so you cannot share it. It also means that anyone with access to your Windows PC has the potential to access this key.\r\nDo not use this as a replacement for a strong password, both are important.", "How do authenticator (MFA) apps work in SEP?");
            if(MessageBox.Show("Files using authenticator (MFA) apps cannot be shared.\r\nAnyone with access to your Windows PC can access the private key.\r\nDo Not use as replacement for strong password.\r\nLearn More: https://go.jmatthews.uk/sep/mfa\r\n\r\nWould you like to continue?", "How do authenticator (MFA) apps work in SEP?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
            {
                if (!Directory.Exists(Path.Combine(OtherOperations.storeLoc, "privateKeys")))
                {
                    Directory.CreateDirectory(Path.Combine(OtherOperations.storeLoc, "privateKeys"));
                }
                pnlAuthApp.Visible = true;
                gbMain.Visible = false;

                string uuid = $"{lbFilePath.Text}";
                string secretKey = GenerateRandomSecretKey();
                if (File.Exists(Path.Combine(OtherOperations.storeLoc, "privateKeys", lbFilePath.Text)))
                {
                    MessageBox.Show("Sorry - this file name is already encrypted. Please change this file's name and try again.","File name in use");
                }
                else
                {
                    File.WriteAllText(Path.Combine(OtherOperations.storeLoc, "privateKeys", lbFilePath.Text+".key"), secretKey);
                }
                string uri = CreateAuthenticatorUri(uuid, secretKey);
                GenerateQRCode(uri);
            }
        }

        private void label1_Click(object sender, EventArgs e){}
        string GenerateRandomSecretKey()
        {
            //char[] acceptableChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            //string final="";
            //for (int i = 0; i < 16; i++)
            //{
            //    final += acceptableChars[new Random().Next(acceptableChars.Length)];
            //}
            //return final;
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
            //var authenticator = new TwoFactorAuthenticator();
            //return authenticator.ValidateTwoFactorPIN(secretKey, userOTP);
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            return tfa.ValidateTwoFactorPIN(secretKey, userOTP, true);
        }

        private void btnConfirmAuthSetup_Click(object sender, EventArgs e)
        {
            string testCode = txtAuthSetupVerify.Text;
            string secretKey = File.ReadAllText(OtherOperations.storeLoc + @"\privateKeys\" + lbFilePath.Text + ".key");
            bool validCode = VerifyOTP(secretKey, testCode);
            if (!validCode)
                MessageBox.Show("Sorry, that didn't work, please try again later!", "Invalid Code!");
            else
            {
                pnlAuthApp.Visible = false;
                gbMain.Visible = true;
                usingMFA = true;
            }
        }
    }
}
