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
using Octokit;
using sep.Models;
using System.Threading.Tasks;
using System.Reflection;

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
            if (!File.Exists(Path.Combine(OtherOperations.storeLoc, "options.json")))
            {
                Options.SaveToFile();
            }
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

            menuStrip1.Anchor = AnchorStyles.Top;
            menuStrip1.Left = this.ClientSize.Width / 2 - menuStrip1.Width / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hide();
            //new frmDecryptString().Show();
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
                System.Windows.Forms.Application.Exit();
                sent = true; //(movetoend)
            }
            else if (passArgs.Contains("-w"))
            {
                sent = true;
                OtherOperations.filePath = passArgs[2];
                OtherOperations.folderMode = false;
                OtherOperations.contextMenu = true;
                Hide();
                new frmWipeFile().Show();
            }
            else if (passArgs.Contains("-f"))
            {
                sent = true; //(movetoend)
                OtherOperations.filePath = passArgs[2];
                OtherOperations.folderMode = true;
                OtherOperations.contextMenu = true;
                Hide();
                new frmWipeFile().Show();
            }
            //UpdateVersionLabel();

            //if (OtherOperations.debug == true)
            //{
            //    enableDebugModeToolStripMenuItem.Text = "Disable Debug Mode";

            //}
            //else if (OtherOperations.debug == false)
            //{
            //    enableDebugModeToolStripMenuItem.Text = "Enable Debug Mode";

            //}
        }

        //private async void UpdateVersionLabel()
        //{
        //    // Assuming 'lbVersionNumber' is your label on the form
        //    lbVersionNumber.Text = "Loading...";
        //    //lbVersionNumber.Text = "Unknown SEP Version";
        //    lbVersionNumber.Text = await VersionGetter();
        //}
        //static async Task<String> VersionGetter()
        //{
        //    // Initialize a new instance of the GitHubClient with a ProductHeaderValue
        //    var client = new GitHubClient(new ProductHeaderValue("SEP"));

        //    // Replace 'owner' with the username and 'repo' with the repository name
        //    var releases = await client.Repository.Release.GetAll("JamieM0", "sep");

        //    // The first item in the list will be the latest release
        //    var latestRelease = releases[0];
        //    var currentRelease=releases[0];
        //    DateTime compileTimeTracker = new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime;

        //    if (latestRelease.PublishedAt > compileTimeTracker)
        //    {
        //        return "New version available: " + latestRelease.TagName;
        //    }
        //    else
        //    {
        //        //bool validReleaseDate = false;
        //        //while(!validReleaseDate)
        //        //{
        //        //    if (Convert.ToDateTime(latestRelease.PublishedAt).Date == compileTimeTracker.Date)
        //        //    {
        //        //        validReleaseDate = true;
        //        //        currentRelease=latestRelease;
        //        //    }
        //        //    else
        //        //    {
        //        //        compileTimeTracker.AddDays(-1);
        //        //    }
        //        //}

        //        return ($"SEP {currentRelease.TagName}");
        //    }
        //}

        //public static DateTime GetLinkerTime(this Assembly assembly, TimeZoneInfo target = null)
        //{
        //    var filePath = assembly.Location;
        //    const int c_PeHeaderOffset = 60;
        //    const int c_LinkerTimestampOffset = 8;
        //    var buffer = new byte[2048];

        //    using (var stream = new FileStream(filePath, System.IO.FileMode.Open, FileAccess.Read))
        //    {
        //        stream.Read(buffer, 0, 2048);
        //    }

        //    var offset = BitConverter.ToInt32(buffer, c_PeHeaderOffset);
        //    var secondsSince1970 = BitConverter.ToInt32(buffer, offset + c_LinkerTimestampOffset);
        //    var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        //    var linkTimeUtc = epoch.AddSeconds(secondsSince1970);

        //    var tz = target ?? TimeZoneInfo.Local;
        //    var localTime = TimeZoneInfo.ConvertTimeFromUtc(linkTimeUtc, tz);
        //    return localTime;
        //}

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
            //Hide();
            //new frmLockers().Show();
            //MessageBox.Show("Lockers are disabled until the browser can be properly implemented.\r\nFor more info, visit the Github Issues page. (#20)", "Disabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            new frmLockerBrowser().Show();
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
            Hide();
            new frmFunctionString(true).Show();
        }

        private void decryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherOperations.funcEncrypt = false;
            Hide();
            new frmFunctionScreen().Show();
        }

        private void decryptStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmDecryptString().Show();
            Hide();
            new frmFunctionString(false).Show();
        }

        private void lockersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hide();
            //new frmLockers().Show();
            Hide();
            new frmLockerBrowser().Show();
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
                key.SetValue("", "\"" + System.Windows.Forms.Application.ExecutablePath + "\" -e \"%1\"");

                key = Registry.ClassesRoot.OpenSubKey(@"Directory\shell", true);
                key.CreateSubKey("SEP Convert to Locker");
                key = key.OpenSubKey("SEP Convert to Locker", true);
                key.SetValue("icon", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "enclogo.ico"));
                key.CreateSubKey("command");
                key = key.OpenSubKey("command", true);
                key.SetValue("", "\"" + System.Windows.Forms.Application.ExecutablePath + "\" -l \"%V\"");

                key = Registry.ClassesRoot.OpenSubKey(@"*\shell", true);
                key.CreateSubKey("SEP Wipe File");
                key = key.OpenSubKey("SEP Wipe File", true);
                key.SetValue("icon", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "enclogo.ico"));
                key.CreateSubKey("command");
                key = key.OpenSubKey("command", true);
                key.SetValue("", "\"" + System.Windows.Forms.Application.ExecutablePath + "\" -w \"%1\"");

                key = Registry.ClassesRoot.OpenSubKey(@"Directory\shell", true);
                key.CreateSubKey("SEP Wipe Directory");
                key = key.OpenSubKey("SEP Wipe Directory", true);
                key.SetValue("icon", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "enclogo.ico"));
                key.CreateSubKey("command");
                key = key.OpenSubKey("command", true);
                key.SetValue("", "\"" + System.Windows.Forms.Application.ExecutablePath + "\" -f \"%V\"");

                MessageBox.Show("Context Menu has been updated. \r\nYou can now right click a file and select SEP Encrypt, which allows you to\r\neither Ecrypt or Decrypt the file.\r\nYou can also convert an entire folder to a locker, or wipe a file or directory.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while updating Context Menu. \r\nPlease try again later.\r\n\r\nError Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //DialogResult result = MessageBox.Show("This screen is very buggy and may not work properly. \r\nIt is recommended to use the new Encrypt File screen. \r\n\r\nDo you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    Hide();
            //    new frmEncryptFile().Show();
            //}
        }

        private void oldDecryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Warn about old screen being very buggy and offer yes or no choice
            //DialogResult result = MessageBox.Show("This screen is very buggy and may not work properly. \r\nIt is recommended to use the new Decrypt File screen. \r\n\r\nDo you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    Hide();
            //    new frmDecryptFile().Show();
            //}
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

        }

        private void btnSecureDelete_Click(object sender, EventArgs e)
        {
            Hide();
            new frmWipeFile().Show();
        }

        private void wipeFileSecureDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prompt user to input file to wipe, and number of passes
            Hide();
            new frmWipeFile().Show();
        }

        //private void enableDebugModeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (OtherOperations.debug)
        //    {
        //        OtherOperations.debug = false;
        //        enableDebugModeToolStripMenuItem.Text = "Enable Debug Mode";
        //        MessageBox.Show("Debug Mode has been disabled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        OtherOperations.debug = true;
        //        enableDebugModeToolStripMenuItem.Text = "Disable Debug Mode";
        //        MessageBox.Show("Debug Mode has been enabled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmOptions().Show();
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            new frmOptions().Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            
        }
    }
}
