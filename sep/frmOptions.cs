using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using sep.Models;

namespace sep
{
    public partial class frmOptions : Form
    {
        bool updateReady = false;
        public frmOptions()
        {
            InitializeComponent();
            GetOptions();
            CenterToScreen();
        }
        private void GetOptions()
        {
            cbDebugMode.Checked = Options.DebugMode == true ? true : false;
            cbEncryptFileNames.Checked = Options.EncryptFileNames == true ? true : false;
            cbRemoveDirectoryStructure.Checked = Options.RemoveDirectoryStructure == true ? true : false;
            cmbEncryptionAlgorithm.SelectedItem = Options.EncryptionAlgorithm;
            updateReady = true;
        }

        private void btnSaveAndReturn_Click(object sender, EventArgs e)
        {
            SaveOptions();
            Hide();
            new frmHome().Show();
        }
        private void SaveOptions()
        {
            Options.DebugMode = cbDebugMode.Checked;
            Options.EncryptFileNames = cbEncryptFileNames.Checked;
            Options.RemoveDirectoryStructure = cbRemoveDirectoryStructure.Checked;
            Options.EncryptionAlgorithm = cmbEncryptionAlgorithm.SelectedItem.ToString();
            Options.SaveToFile();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {

        }

        private void cbEncryptFileNames_CheckedChanged(object sender, EventArgs e)
        {
            //Tell the user that this feature is in beta, and ask if they want to continue
            if (cbEncryptFileNames.Checked && updateReady)
            {
                DialogResult dialogResult = MessageBox.Show("This feature is in beta, and may not work as expected.\r\n\r\nPlease note that Lockers are not currently supported and their file names will be unencrypted. \r\n\r\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    cbEncryptFileNames.Checked = false;
                }
            }
        }

        private void btnUpdateContextMenu_Click(object sender, EventArgs e)
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

        private void lbEncryptionAlgorithmInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://jamiem.me/aes-twofish-difference",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void cmbEncryptionAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEncryptionAlgorithm.SelectedIndex == 1)
            {
                cbEncryptFileNames.Checked = false;
                cbEncryptFileNames.Enabled = false;
                cbRemoveDirectoryStructure.Checked = false;
                cbRemoveDirectoryStructure.Enabled = false;
            }
            else
            {
                cbEncryptFileNames.Enabled = true;
                cbRemoveDirectoryStructure.Enabled = true;
            }
        }
    }
}
