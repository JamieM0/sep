﻿using System;
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
                string pw = Microsoft.VisualBasic.Interaction.InputBox("Enter the password for your locker:", "Password Library", "", -1, -1);
                DatabaseHelperLK.InsertNewLocker(Path.GetFileName(passArgs[2]), Path.GetDirectoryName(passArgs[2]), pw, false);

                //File.AppendAllText(Path.Combine(OtherOperations.storeLoc, "lockersInfo.conf"), $"{}~{}~0\r\n");
                MessageBox.Show("Locker added to list.\nLock it through the \"Lockers\" screen in the main program.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            OtherOperations.funcEncrypt = true;
            Hide();
            new frmFunctionScreen().Show();
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            OtherOperations.funcEncrypt = false;
            Hide();
            new frmFunctionScreen().Show();
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
            OtherOperations.funcEncrypt = true;
            Hide();
            new frmFunctionScreen().Show();
        }

        private void encryptStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEncryptString().Show();
        }

        private void decryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherOperations.funcEncrypt = false;
            Hide();
            new frmFunctionScreen().Show();
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while installing Automatic Takeover. \r\nPlease try again later.\r\n\r\nError Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void oldEncryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Warn about old screen being very buggy and offer yes or no choice
            DialogResult result = MessageBox.Show("This screen is very buggy and may not work properly. \r\nIt is recommended to use the new Encrypt File screen. \r\n\r\nDo you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Hide();
                new frmEncryptFile().Show();
            }
        }

        private void oldDecryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Warn about old screen being very buggy and offer yes or no choice
            DialogResult result = MessageBox.Show("This screen is very buggy and may not work properly. \r\nIt is recommended to use the new Decrypt File screen. \r\n\r\nDo you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Hide();
                new frmDecryptFile().Show();
            }
        }

        private void removeFromContextMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"*\shell", true);
                //key = key.OpenSubKey("SEP Encrypt", true);
                //key.DeleteSubKeyTree("SEP Encrypt");

                //key = Registry.ClassesRoot.OpenSubKey(@"Directory\shell", true);
                //key = key.OpenSubKey("SEP Convert to Locker", true);
                //key.DeleteSubKeyTree("SEP Convert to Locker");

                //File.Delete(Path.Combine(OtherOperations.storeLoc, "autotakeover"));
                //MessageBox.Show("Automatic Takeover has been uninstalled. \r\nYou will no longer see any refrences to SEP in your context menu.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("This feature is not yet implemented.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while uninstalling Automatic Takeover. \r\nPlease try again later.\r\n\r\nError Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wipeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prompt user to input file to wipe, and number of passes
            Hide();
            new frmWipeFile().Show();
        }

        private void btnSecureDelete_Click(object sender, EventArgs e)
        {
            Hide();
            new frmWipeFile().Show();
        }
    }
}
