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

namespace sep
{
    public partial class frmFunctionScreen : Form
    {
        bool funcEncrypt = true;
        string funcText = "Encrypt";
        string filePath;
        string fileName;
        string password;
        bool saveToLibrary = false;
        bool usingMFA = false;
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
            }
            lbTitle.Text = $"Simple Encryption Program: {funcText} File";
            lbIns1.Text = $"Please select a file to {funcText.ToLower()}";
            lbIns2.Text = $"Enter a password to {funcText.ToLower()} the file";
            lbIns3.Text = $"Ready to {funcText.ToLower()}!";
        }

        private void frmFunctionScreen_Load(object sender, EventArgs e)
        {

        }

        private void animateSection(Panel panel, Point newPoint, int speed)
        {
            //Co-Ordinates
            //Panel 1: 350,170; 170,170; 6,170
            //Panel 2:      //; 570,170; 383,170
            //Panel 3:      //;      //; 760,170
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
            ofd.Title = $"Select a file to {funcText.ToLower()}";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
            lbFileName.Text = fileName;
            int sizeOfFileName = TextRenderer.MeasureText(fileName, lbFileName.Font).Width/2;
            lbFileName.Location = new Point((pnlFileSelect.Width/2)-sizeOfFileName, 150);
            lbFileName.Visible = true;

            //Animate to left (2 sections)
            
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            password = txtPassword.Text;
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
            
            txtPassword.Text = new String(stringChars);
        }

        private void btnPWLibFunc_Click(object sender, EventArgs e)
        {
            saveToLibrary = true;
            //OtherOperations.SaveToLibrary(fileName, password);
        }

        private void btnUseAuthenticator_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("SEP uses the GoogleAuthenticator library to help link the encrypted file and your authenticator (MFA) app.\r\nA private key is generated and provided to your mobile device via the QR code. It is stored securely on your local PC using DPAPI, usually a servic like Google or Twitter will store this key on their servers.\r\nThis means that the file cannot be decrypted without having this key, so you cannot share it. It also means that anyone with access to your Windows PC has the potential to access this key.\r\nDo not use this as a replacement for a strong password, both are important.", "How do authenticator (MFA) apps work in SEP?");
            if (MessageBox.Show("Files using authenticator (MFA) apps cannot be shared.\r\nAnyone with access to your Windows PC can access the private key.\r\nDo Not use as replacement for strong password.\r\nLearn More: https://go.jmatthews.uk/sep/mfa\r\n\r\nWould you like to continue?", "How do authenticator (MFA) apps work in SEP?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (!Directory.Exists(Path.Combine(OtherOperations.storeLoc, "privateKeys")))
                {
                    Directory.CreateDirectory(Path.Combine(OtherOperations.storeLoc, "privateKeys"));
                }
                pnlAuthApp.Visible = true;
                pnlFileSelect.Visible = false;
                pnlFinalSteps.Visible = false;
                btnBack.Visible = false;

                string uuid = $"{fileName}";
                string secretKey = GenerateRandomSecretKey();
                if (File.Exists(Path.Combine(OtherOperations.storeLoc, "privateKeys", fileName)))
                {
                    MessageBox.Show("Sorry - this file name is already encrypted. Please change this file's name and try again.", "File name in use");
                }
                else
                {
                    File.WriteAllText(Path.Combine(OtherOperations.storeLoc, "privateKeys", fileName + ".key"), secretKey);
                }
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
            //var authenticator = new TwoFactorAuthenticator();
            //return authenticator.ValidateTwoFactorPIN(secretKey, userOTP);
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            return tfa.ValidateTwoFactorPIN(secretKey, userOTP, true);
        }

        private void btnCancelMFASetup_Click(object sender, EventArgs e)
        {
            pnlAuthApp.Visible = false;
            pnlFileSelect.Visible = true;
            pnlFinalSteps.Visible = true;
            btnBack.Visible = true;
        }

        private void btnConfirmAuthSetup_Click(object sender, EventArgs e)
        {
            string testCode = txtAuthSetupVerify.Text;
            string secretKey = File.ReadAllText(OtherOperations.storeLoc + @"\privateKeys\" + fileName + ".key");
            bool validCode = VerifyOTP(secretKey, testCode);
            if (!validCode)
                MessageBox.Show("Sorry, that didn't work, please try again later!", "Invalid Code!");
            else
            {
                pnlAuthApp.Visible = false;
                pnlFileSelect.Visible = true;
                pnlFinalSteps.Visible = true;
                btnBack.Visible = true;
                usingMFA = true;
            }
        }
    }
}
