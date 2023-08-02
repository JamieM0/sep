using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.Win32;

namespace sep
{
    public partial class frmHome : Form
    {

        public static AES a = new AES();
        bool sent = false;
        
        public frmHome()
        {
            InitializeComponent();
            CenterToScreen();

            OtherOperations.storeLoc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SEP");
            if (File.Exists(Path.Combine(OtherOperations.storeLoc, "autotakeover")))
                automaticTakeoverToolStripMenuItem.Visible = false;
            if (!File.Exists(Path.Combine(OtherOperations.storeLoc, "first.load")))
            {
                MessageBox.Show("Warning: This project is still in development. Please use at your own risk.\r\n\r\nThis message will not show again (until the first.load file is removed).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Directory.CreateDirectory(OtherOperations.storeLoc);
                File.Create(Path.Combine(OtherOperations.storeLoc, "first.load"));
            }

            if (!File.Exists("pwLib.conf.aes"))
            {
                btnPWLib.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new frmEncryptString().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new frmDecryptString().Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            tmrTick.Start();
            string[] passArgs = Environment.GetCommandLineArgs();
            if (passArgs.Contains("-e"))
            {
                sent = true;
                OtherOperations.filePath = passArgs[2];
                Hide();
                new frmStreamedFunction().Show();
            }
            else if (passArgs.Contains("-d"))
            {
                sent = true;
                OtherOperations.filePath = passArgs[2];
                Hide();
                new frmStreamedFunction().Show();
            }
            else if (passArgs.Contains("-l"))
            {
                File.AppendAllText(Path.Combine(OtherOperations.storeLoc, "lockersInfo.conf"), $"{Path.GetDirectoryName(passArgs[2])}~{Path.GetFileName(passArgs[2])}~0\r\n");
                MessageBox.Show("Locker added to list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sent = true; //(movetoend)
            }
        }

        private void pbGithub_Click(object sender, EventArgs e)
        {
            //ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/jamiem0/sep");
            //Process.Start(sInfo);
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/jamiem0/sep",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            Hide();
            new frmEncryptFile().Show();
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            Hide();
            new frmDecryptFile().Show();
        }

        private void btnPWLib_Click(object sender, EventArgs e)
        {
            Hide();
            new frmPasswordLibrary().Show();
        }

        private void btnLockers_Click(object sender, EventArgs e)
        {
            Hide();
            new frmLockers().Show();
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void encryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmEncryptFile().Show();
        }

        private void encryptStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEncryptString().Show();
        }

        private void decryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmDecryptFile().Show();
        }

        private void decryptStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDecryptString().Show();
        }

        private void lockersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmLockers().Show();
        }

        private void passwordLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmPasswordLibrary().Show();
        }

        private void githubPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/jamiem0/sep",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            if (sent)
            {
                Hide();
            }
        }

        private void installToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void automaticTakeoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display messagebox warning user about changing registry values and ask if agreed
            DialogResult result = MessageBox.Show("Automatic Takeover allows you to right click a file and select Encrypt or Decrypt right from the Windows context menu." +
                "\nYou can also right click an entire folder and convert it to a locker, allowing you to encrypt its contents easily!" +
                "\r\nThis will change registry values and may cause problems with your computer. \r\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result==DialogResult.Yes)
            {
                try
                {
                    File.Create(Path.Combine(OtherOperations.storeLoc, "autotakeover"));
                    RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"*\shell", true);
                    key.CreateSubKey("SEP Encrypt");
                    key = key.OpenSubKey("SEP Encrypt", true);
                    key.SetValue("icon", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "enclogo.ico"));
                    key.CreateSubKey("command");
                    key = key.OpenSubKey("command", true);
                    key.SetValue("", "\"" + Application.ExecutablePath + "\" -e \"%1\"");

                    key = Registry.ClassesRoot.OpenSubKey(@"Directory\shell", true);
                    key.CreateSubKey("SEP Convert to Locker");
                    key = key.OpenSubKey("SEP Convert to Locker", true);
                    key.SetValue("icon", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "enclogo.ico"));
                    key.CreateSubKey("command");
                    key = key.OpenSubKey("command", true);
                    key.SetValue("", "\"" + Application.ExecutablePath + "\" -l \"%V\"");

                    MessageBox.Show("Automatic Takeover has been installed. \r\nYou can now right click a file and select SEP Encrypt, which allows you to\r\neither Ecrypt or Decrypt the file.\r\nYou can also convert an entire folder to a locker.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An error occured while installing Automatic Takeover. \r\nDid you run SEP as an administrator?\r\nPlease try again later.\r\n\r\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            new frmFunctionScreen().Show();
        }
    }
}
