using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using sep.Models;

namespace sep
{
    public partial class frmLockerBrowser : Form
    {
        Locker selectedLocker = new Locker();
        public frmLockerBrowser()
        {
            InitializeComponent();
            CenterToScreen();
            PopulateLockerBrowser();
        }
        private void PopulateLockerBrowser()
        {
            dgLockersBrowser.ClearSelection();
            //Populate dgLockersBrowser using the database file
            Locker[] lockers = DatabaseHelperLK.getLockers();
            dgLockersBrowser.DataSource = lockers;
            dgLockersBrowser.Columns["ID"].Visible = false;
            dgLockersBrowser.Columns["password"].Visible = false;
            //dgLockersBrowser.Columns["lockState"].Visible = false;
            dgLockersBrowser.Columns["name"].HeaderText = "Locker Name";
            dgLockersBrowser.Columns["location"].HeaderText = "Locker Location";
            dgLockersBrowser.Columns["lockState"].HeaderText = "Lock State";
            dgLockersBrowser.Columns["name"].Width = 200;
            dgLockersBrowser.Columns["location"].Width = 360;
            dgLockersBrowser.Columns["lockState"].Width = 96;
        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://docs.jmatthews.uk/docs/sep/features/lockers/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }

        private void dgLockersBrowser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedLocker = (Locker)dgLockersBrowser.CurrentRow.DataBoundItem;
            btnOpenLocker.Enabled = true;
            btnLockAction.Enabled = true;
            btnDeleteLocker.Enabled = true;
            if (selectedLocker.lockState)
                btnLockAction.Text = "Unlock";
            else
                btnLockAction.Text = "Lock";
        }

        private void btnOpenLocker_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(selectedLocker.location, selectedLocker.name));
        }

        private void btnDeleteLocker_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this locker? This action cannot be undone.", "Delete Locker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DatabaseHelperLK.deleteLocker(selectedLocker.ID);
                PopulateLockerBrowser();
                MessageBox.Show("Locker Deleted. Remember that files are NOT DELETED, only the locker has been deleted.", "Locker Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //if (MessageBox.Show("Locker Deleted. Remember that files are NOT DELETED, only the locker has been deleted.\r\nWould you also like to delete the files in the locker?", "Delete Files", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                //{
                //    try
                //    {
                //        if(selectedLocker.lockState != true)
                //        {
                //            foreach (string file in Directory.GetFiles(Path.Combine(selectedLocker.location, selectedLocker.name)))
                //            {
                //                AesOperation.SecureDelete(file, 3);
                //            }
                //            Directory.Delete(Path.Combine(selectedLocker.location, selectedLocker.name));
                //        }
                //        else
                //        {
                //            foreach (string file in Directory.GetFiles(Path.Combine(selectedLocker.location, selectedLocker.name + ".encloc")))
                //            {
                //                AesOperation.SecureDelete(file, 3);
                //            }
                //            Directory.Delete(Path.Combine(selectedLocker.location, selectedLocker.name + ".encloc"));
                //        }
                //        MessageBox.Show("Action completed. Locker and Locker files have been deleted.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    catch
                //    {

                //    }
                //}
            }
        }

        private void btnLockAction_Click(object sender, EventArgs e)
        {
            bool removeDirectoryStructure = Options.RemoveDirectoryStructure;

            if (!selectedLocker.lockState)
            {
                //Get empty locker
                string pw = selectedLocker.password;
                string targetDirLocked = Path.Combine(selectedLocker.location, selectedLocker.name + ".encloc");
                string sourceDir = Path.Combine(selectedLocker.location, selectedLocker.name);
                if (Directory.Exists(targetDirLocked))
                {
                    Directory.Delete(targetDirLocked, true);
                }
                Directory.CreateDirectory(targetDirLocked);

                if (removeDirectoryStructure == true)
                {
                    File.Create(targetDirLocked + "\\structure.conf").Close();
                }

                //Encrypt each file in directory
                foreach (string file in Directory.GetFiles(sourceDir))
                {
                    string input = file;
                    string output = targetDirLocked + "\\" + Path.GetFileName(file) + ".aes";
                    //AES.FileEncrypt(input, output, pw);
                    AES.FileEncrypt(input, output, pw);
                    if (removeDirectoryStructure == true)
                    {
                        File.AppendAllText(targetDirLocked + "\\structure.conf", Path.GetFileName(file) + Environment.NewLine);
                    }
                }

                //populate dirsToCheck with all the directories & subdirectories inside the chosen folder
                string[] dirsToCheck = Directory.GetDirectories(sourceDir, "*", SearchOption.AllDirectories);

                foreach (string dir in dirsToCheck)
                {
                    //populate filesToCheck with all the files inside the chosen folder
                    string[] filesToCheck = Directory.GetFiles(dir, "*", SearchOption.TopDirectoryOnly);
                    string subDirName = dir.Substring(sourceDir.Length + 1);

                    if(removeDirectoryStructure!=true)
                    {
                        Directory.CreateDirectory(targetDirLocked + "\\" + subDirName);
                    }

                    foreach (string file in filesToCheck)
                    {
                        string input = file;
                        string output = "";
                        if (removeDirectoryStructure == true)
                        {
                            output = targetDirLocked + "\\" + Path.GetFileName(file) + ".aes";
                            File.AppendAllText(targetDirLocked + "\\structure.conf", subDirName + "/" + Path.GetFileName(file) + Environment.NewLine);
                        }
                        else
                        {
                            output = targetDirLocked + "\\" + subDirName + "\\" + Path.GetFileName(file) + ".aes";
                        }
                        AES.FileEncrypt(input, output, pw);
                    }
                }

                if (removeDirectoryStructure == true)
                {
                    AES.FileEncrypt(targetDirLocked + "\\structure.conf", targetDirLocked + "\\structure.conf.aes", pw);
                    File.Delete(targetDirLocked + "\\structure.conf");
                }

                Directory.Delete(sourceDir, true);
                DatabaseHelperLK.setLockState(selectedLocker.ID, true);
                MessageBox.Show("Locker locked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLockAction.Text = "Unlock Locker";
                PopulateLockerBrowser();
                selectedLocker = dgLockersBrowser.SelectedRows[0].DataBoundItem as Locker;
            }
            else
            {
                string pw = Microsoft.VisualBasic.Interaction.InputBox("Enter locker password:", "Input Locker Password");
                string sourceDirLocked = Path.Combine(selectedLocker.location, selectedLocker.name + ".encloc");
                string targetDir = Path.Combine(selectedLocker.location, selectedLocker.name);
                Directory.CreateDirectory(targetDir);

                foreach (string file in Directory.GetFiles(sourceDirLocked))
                {
                    string input = file;
                    string output = targetDir + "\\" + $"{Path.GetFileName(file).Split('.')[0]}.{Path.GetFileName(file).Split('.')[1]}";
                    AES.FileDecrypt(input, output, pw);
                }

                //populate dirsToCheck with all the directories & subdirectories inside the chosen folder
                string[] dirsToCheck = Directory.GetDirectories(sourceDirLocked, "*", SearchOption.AllDirectories);

                if(removeDirectoryStructure!=true)
                {
                    foreach (string dir in dirsToCheck)
                    {
                        //populate filesToCheck with all the files inside the chosen folder
                        string[] filesToCheck = Directory.GetFiles(dir, "*", SearchOption.TopDirectoryOnly);
                        string subdirName = dir.Substring(targetDir.Length + 8);

                        Directory.CreateDirectory(targetDir + "\\" + subdirName);

                        foreach (string file in filesToCheck)
                        {
                            string input = file;
                            string output = targetDir + "\\" + subdirName + "\\" + $"{Path.GetFileName(file).Split('.')[0]}.{Path.GetFileName(file).Split('.')[1]}";
                            AES.FileDecrypt(input, output, pw);
                        }
                    }
                }
                else
                {
                    foreach (string file in Directory.GetFiles(selectedLocker.location + "\\" + selectedLocker.name + ".encloc"))
                    {
                        string output = selectedLocker.location + "\\" + selectedLocker.name + "\\" + Path.GetFileNameWithoutExtension(file);
                        AES.FileDecrypt(file, output, pw);
                    }
                    if(removeDirectoryStructure==true)
                    {
                        Structurise();
                    }
                    
                    //foreach (string line in File.ReadAllLines(selectedLocker.location + "\\" + selectedLocker.name + ".encloc" + "\\structure.conf"))
                    //{
                    //    //string[] parts = line.Split('/');
                    //    //Get a string which has all the split items in 'parts' except the last one
                    
                    //    //string input = "test/hello/world/another/test";
                    //    if(line=="" || line ==null || line==" ")
                    //    {
                    //        break;
                    //    }
                    //    int lastIndex = line.LastIndexOf('/');
                    //    string subDir = "";
                    //    string fileName = "";
                    //    if (lastIndex != -1)
                    //    {
                    //        subDir = line.Substring(0, lastIndex);
                    //        subDir = subDir.Replace("/","\\");
                    //        fileName = line.Substring(lastIndex);
                    //        Directory.CreateDirectory(subDir);
                    //    }
                    //    else
                    //    {
                    //        fileName = line;
                    //    }
                        
                    //    string input = selectedLocker.location + "\\" + selectedLocker.name + ".encloc" + "\\" + fileName + ".aes";
                    //    string output = selectedLocker.location + "\\" + selectedLocker.name + "\\" + line;
                    //    AES.FileDecrypt(input, output, pw);
                        
                    //    //populate filesToCheck with all the files inside the chosen folder
                    //    //string[] filesToCheck = Directory.GetFiles(dir, "*", SearchOption.TopDirectoryOnly);
                    //    //string subdirName = dir.Substring(targetDir.Length + 8);

                    //    //Directory.CreateDirectory(targetDir + "\\" + subdirName);

                    //    //foreach (string file in filesToCheck)
                    //    //{
                    //    //    string input = file;
                    //    //    string output = targetDir + "\\" + subdirName + "\\" + $"{Path.GetFileName(file).Split('.')[0]}.{Path.GetFileName(file).Split('.')[1]}";
                    //    //    AES.FileDecrypt(input, output, pw);
                    //    //}
                    //}
                }

                DatabaseHelperLK.setLockState(selectedLocker.ID, false);
                MessageBox.Show("Locker unlocked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!Directory.Exists(OtherOperations.storeLoc + "\\backupLockers\\"))
                    Directory.CreateDirectory(OtherOperations.storeLoc + "\\backupLockers\\");
                if (Directory.Exists(OtherOperations.storeLoc + "\\backupLockers\\" + selectedLocker.name + ".encloc"))
                    Directory.Delete(OtherOperations.storeLoc + "\\backupLockers\\" + selectedLocker.name + ".encloc", true);
                Directory.Move(sourceDirLocked, OtherOperations.storeLoc + "\\backupLockers\\" + selectedLocker.name + ".encloc");
                btnLockAction.Text = "Lock Locker";
                PopulateLockerBrowser();
            }
        }

        private void Structurise()
        {
            string[] lines = File.ReadAllLines(Path.Combine(selectedLocker.location, selectedLocker.name, "structure.conf"));
            foreach(string file in lines)
            {
                if(file.Contains("/"))
                {
                    string[] partsOfFile = file.Split('/');
                    //Remove last item from partsOfFile
                    string[] parts = new string[partsOfFile.Length - 1];
                    Array.Copy(partsOfFile, parts, partsOfFile.Length - 1);
                    string currentDirectory = Path.Combine(selectedLocker.location, selectedLocker.name);
                    for (int i = 0; i < parts.Length; i++)
                    {
                        currentDirectory = Path.Combine(currentDirectory, parts[i]);
                        if (!Directory.Exists(currentDirectory))
                            Directory.CreateDirectory(currentDirectory);
                    }

                    //Get the last item from partsOfFile
                    string fileName = partsOfFile[partsOfFile.Length - 1];

                    string subDir = "";
                    foreach (string part in parts)
                    {
                        subDir = Path.Combine(subDir, part);
                    }

                    File.Move(Path.Combine(selectedLocker.location, selectedLocker.name, fileName), Path.Combine(selectedLocker.location, selectedLocker.name, subDir, fileName));
                }
                else
                {
                    
                }
            }
            File.Delete(Path.Combine(selectedLocker.location, selectedLocker.name, "structure.conf"));
        }

        private void btnCreateLocker_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To create a locker, please right click on a folder, and choose \"SEP Convert to Locker\".", "Create Locker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
