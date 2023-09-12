using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace sep
{
    public partial class frmLockers : Form
    {
        public frmLockers()
        {
            InitializeComponent();
            Populator();
            CenterToScreen();
        }

        bool deleting = false;
        string[] lockerLocations = new string[DatabaseHelperLK.CountLockerData()];
        Locker[] lockersInfo = new Locker[DatabaseHelperLK.CountLockerData()];

        public void Populator()
        {
            for (int i = 0; i < lockersInfo.Length; i++)
            {
                lockersInfo[i] = new Locker(i + 1, DatabaseHelperLK.getRequestedDataFromID("LockerName", i+1), DatabaseHelperLK.getRequestedDataFromID("LockerLocation", i + 1), DatabaseHelperLK.getRequestedDataFromID("LockerPassword", i + 1), DatabaseHelperLK.getLockStateFromID(i + 1));
                lockerLocations[i] = Path.Combine(lockersInfo[i].location, lockersInfo[i].name);
                PopulateFields(lockersInfo[i].ID, lockersInfo[i].name, lockersInfo[i].lockState);
            }

            foreach (Control c in Controls)
            {
                //if (c.Name.Split('_')[0] == "pnlI")
                //    Controls.Remove(c);

                //Make all labels visible
                if (c.Name.Split('_')[0] == "lb")
                    c.Visible = true;
            }
        }
        
        public void PopulateFields(int index, string lockname, bool lockState)
        {
            index --;
            Panel pnl = new Panel();
            if (index == 0 || index % 2 == 0)
            {
                pnl.Location = new Point(12, 110 + index / 2 * 53);
            }
            else
            {
                pnl.Location = new Point(493, 110 + index / 2 * 53);
            }
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Size = new Size(410, 45);
            pnl.Name = $"pnlI_{index}";
            Controls.Add(pnl);

            index ++;
            Label lockerName = new Label();
            lockerName.Font = new Font("Segoe UI", 14);
            //lockerName.Location = new Point(180 - TextRenderer.MeasureText(lockname, lockerName.Font).Width, 10);
            lockerName.Location = new Point(3, 8);
            //Truncate lockername if the text goes behind the buttons
            if (lockname.Length > 20)
                lockerName.Text = lockname.Substring(0, 9) + "...";
            else
                lockerName.Text = lockname;
            lockerName.Name = $"txtLockerName_{index}";
            lockerName.BringToFront();
            pnl.Controls.Add(lockerName);

            Button lockAction = new Button();
            lockAction.Location = new Point(180, 6);
            lockAction.Size = new Size(110, 32);
            if (lockState == false)
                lockAction.Text = "Lock";
            else
                lockAction.Text = "Unlock";
            lockAction.Font = new Font("Segoe UI", 14);
            lockAction.Name = $"btnLockAction_{index}";
            lockAction.Click += LockAction_Click;
            pnl.Controls.Add(lockAction);

            Button openLocker = new Button();
            openLocker.Location = new Point(296, 6);
            openLocker.Size = new Size(110, 32);
            openLocker.Text = "Fix";
            openLocker.Font = new Font("Segoe UI", 14);
            openLocker.Name = $"btnOpenLocker_{index}";
            openLocker.Click += OpenLockerAction_Click;
            pnl.Controls.Add(openLocker);
        }

        private void LockAction_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = (int.Parse(btn.Name.Split('_')[1])-1);

            btn.Enabled = false;
            if (btn.Text == "Lock")
            {
                string pw = lockersInfo[index].password;
                if (Directory.Exists(lockersInfo[index] + ".encloc"))
                {
                    Directory.Delete(lockerLocations[index] + ".encloc", true);
                }
                Directory.CreateDirectory(lockerLocations[index] + ".encloc");

                foreach (string f in Directory.GetFiles(lockerLocations[index]))
                {
                    string input = f;
                    string output = lockerLocations[index] + ".encloc\\" + Path.GetFileName(f) + ".aes";
                    AES.FileEncrypt(input, output, pw);
                }
                
                //Get every directory inside the locker & recreate this within the .encloc folder
                foreach (string d in Directory.GetDirectories(lockerLocations[index]))
                {
                    //split and get directory name from path
                    string p = d.Split(Path.DirectorySeparatorChar).Last();
                    
                    if (!Directory.Exists(lockerLocations[index] + ".encloc\\"+p))
                        Directory.CreateDirectory(lockerLocations[index] + ".encloc\\" + p);
                    foreach (string f in Directory.GetDirectories(lockerLocations[index]/* + ".encloc\\" + p*/))
                    {
                        string input = f;
                        string output = Path.Combine(d, Path.GetFileName(f) + ".aes");
                        AES.FileEncrypt(input, output, pw);
                    }
                }

                DatabaseHelperLK.setLockState(index, true);
                MessageBox.Show("Locker locked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Directory.Delete(lockerLocations[index], true);
                btn.Text = "Unlock";
            }
            else if (btn.Text == "Unlock")
            {
                string pw;
                if (MessageBox.Show("Would you like to use the saved password for this locker?", "Use saved password?", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    pw = lockersInfo[index].password;
                else
                    pw = Microsoft.VisualBasic.Interaction.InputBox("Enter locker password:", "Input Locker Password");
                Directory.CreateDirectory(lockerLocations[index]);

                foreach (string f in Directory.GetFiles(lockerLocations[index] + ".encloc"))
                {
                    string input = f;
                    string output = lockerLocations[index] + "\\" + $"{Path.GetFileName(f).Split('.')[0]}.{Path.GetFileName(f).Split('.')[1]}";
                    AES.FileDecrypt(input, output, pw);
                }
                
                //Get every directory inside the locker & recreate this within the .encloc folder
                foreach (string d in Directory.GetDirectories(lockerLocations[index]))
                {
                    foreach (string f in Directory.GetDirectories(d))
                    {
                        string input = f;
                        string output = Path.Combine(d, Path.GetFileName(f).Split('.')[0]+"."+Path.GetFileName(f).Split('.')[1]);
                        AES.FileEncrypt(input, output, pw);
                    }
                }

                DatabaseHelperLK.setLockState(index, false);
                MessageBox.Show("Locker unlocked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn.Text = "Lock";
            }
            btn.Enabled = true;
        }

        private void OpenLockerAction_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = int.Parse(btn.Name.Split('_')[1]);
            string dirToOpen = lockerLocations[index];
            if (btn.Text == "Fix")
            {
                //System.Diagnostics.Process.Start("explorer.exe", @dirToOpen);
                //OtherOperations.LineChanger()
            }
            else
            {
                OtherOperations.LineRemover(Path.Combine(OtherOperations.storeLoc, "lockersInfo.conf"), index);
                MessageBox.Show("Locker deleted, but the files are still on your PC, you can now delete them manually.");
                System.Diagnostics.Process.Start("explorer.exe", @dirToOpen);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!pnlCreateMenu.Visible)
            {
                Hide();
                new frmHome().Show();
            }
            else
            {
                pnlCreateMenu.Visible = false;
                btnDeleteLocker.Visible = true;
                btnCreateLocker.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!deleting)
            {
                btnDeleteLocker.Text = "Stop Deleting";
                // Change all the open locker buttons' text to "Delete"
                foreach (Control c in Controls)
                {
                    if (c is Panel)
                    {
                        foreach (Control c2 in c.Controls)
                        {
                            if (c2 is Button)
                            {
                                if (c2.Text == "Open")
                                {
                                    c2.Text = "Fix";
                                }
                            }
                        }
                    }
                }
                deleting = true;
            }
            else
            {
                btnDeleteLocker.Text = "- Delete Locker";
                // Change all the open locker buttons' text to "Delete"
                foreach (Control c in Controls)
                {
                    if (c is Panel)
                    {
                        foreach (Control c2 in c.Controls)
                        {
                            if (c2 is Button)
                            {
                                if (c2.Text == "Fix")
                                {
                                    c2.Text = "Open";
                                }
                            }
                        }
                    }
                }
                deleting = false;
            }
        }

        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            //Open choose a directory dialog / menu
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lbDirectoryListing.Visible = true;
                    lbDirectoryListing.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnCreateLocker_Click(object sender, EventArgs e)
        {
            pnlCreateMenu.Visible = true;
            btnCreateLocker.Visible = false;
            btnDeleteLocker.Visible = false;
        }

        private void btnCreateLockerConfirm_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lbDirectoryListing.Text) && !String.IsNullOrEmpty(txtLockerName.Text))
            {
                File.AppendAllText(Path.Combine(OtherOperations.storeLoc, "lockersInfo.conf"), $"{lbDirectoryListing.Text}~{txtLockerName.Text}~0\r\n");

                pnlCreateMenu.Visible = false;
                btnDeleteLocker.Visible = true;
                btnCreateLocker.Visible = true;

                Directory.CreateDirectory(lbDirectoryListing.Text + "/" + txtLockerName.Text);
            }
            else
            {
                MessageBox.Show("Invalid contents!", "Invalid locker settings!");
            }

            Populator();
        }

        private void frmLockers_Load(object sender, EventArgs e)
        {

        }
    }
}
