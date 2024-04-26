using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sep
{
    public partial class frmWipeFile : Form
    {
        public frmWipeFile()
        {
            InitializeComponent();
            CenterToScreen();
        }

        string[] filePath;
        string[] fileName;
        int numP;
        bool dirMode = false;
        string dirPath = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Open file dialog, and get a file to wipe
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a file to wipe";
            ofd.Filter = "All Files (*.*)|*.*";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dirMode = false;
                filePath = ofd.FileNames;
                fileName = ofd.SafeFileNames;
                string currentText = txtNumP.Text;
                try
                {
                    int testCase = Convert.ToInt32(currentText);
                    if (testCase >= 3 && testCase <= 100)
                        btnWipe.Enabled = true;
                    else
                        btnWipe.Enabled = false;
                }
                catch (Exception ex)
                {
                    btnWipe.Enabled = false;
                }
            }
            try
            {
                if (filePath.Length != 1)
                    lbFileName.Text = $"{filePath.Length} files selected!";
                else
                    lbFileName.Text = fileName[0];
            }
            catch (NullReferenceException ex)
            {

            }
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            numP = Convert.ToInt32(txtNumP.Text);
            //If user has chosen more than 15 passes ask to confirm to continue
            if (numP > 25)
            {
                DialogResult ar = MessageBox.Show("You are about to make " + numP + " passes.\r\nThis is an extremely high number of passes, and may take a long time. It may also cause damage to your drive, but this is unlikely.\r\n3 times is likely enough, as recommended by security experts.\r\nAre you sure you want to proceed?", "EXTREMELY HIGH NUMBER OF PASSES. Please Confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ar == DialogResult.No)
                {
                    return;
                }
            }
            else if (numP > 10)
            {
                DialogResult ar = MessageBox.Show("Are you sure you want to make " + numP + " passes?\r\n3 times is likely enough, as recommended by security experts, and this may be overkill.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ar == DialogResult.No)
                {
                    return;
                }
            }

            //Ask user to confirm
            DialogResult dr = MessageBox.Show("Are you sure you want to wipe these files? They will become unrecoverable, and lost forever.\r\nClick \"Cancel\" to cancel.", "Confirm", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                try
                {
                    //Wipe the file
                    foreach (string file in filePath)
                    {
                        AesOperation.SecureDelete(file, numP);
                    }
                    if (dirMode)
                        Directory.Delete(dirPath,true);
                    MessageBox.Show("Files Wiped Successfully!");
                    lbFileName.Text = "";
                    fileName = null;
                    filePath = null;
                    dirMode = false;
                    dirPath = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error.\r\nMore Details: " + ex.Message);
                }
            }
            else
            {
                Hide();
                new frmHome().Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }

        private void frmWipeFile_Load(object sender, EventArgs e)
        {

        }

        private void frmWipeFile_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the data being dragged in is a file (or files)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Show a "copy" cursor
            else
                e.Effect = DragDropEffects.None; // Show a "stop" cursor
        }

        private void frmWipeFile_DragDrop(object sender, DragEventArgs e)
        {
            var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            if (!Directory.Exists(path))
            {
                // Get the filenames of all files being dragged into the form
                dirMode = false;
                filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
                fileName = (string[])e.Data.GetData(DataFormats.FileDrop);

                for (int i = 0; i < fileName.Length; i++)
                {
                    fileName[i] = Path.GetFileName(filePath[i]);
                }

                if (filePath.Length != 1)
                    lbFileName.Text = $"{filePath.Length} files selected!";
                else
                    lbFileName.Text = fileName[0];

                btnWipe.Enabled = true;
            }
            else
            {
                dirMode = true;
                dirPath = path;
                filePath = Directory.GetFiles(dirPath);
                fileName = Directory.GetFiles(dirPath);
                for (int i = 0; i < fileName.Length; i++)
                {
                    fileName[i] = Path.GetFileName(filePath[i]);
                }

                if (filePath.Length != 1)
                    lbFileName.Text = $"{filePath.Length} files selected!";
                else
                    lbFileName.Text = fileName[0];

                btnWipe.Enabled = true;
            }
        }

        private void lbDocLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.lbDocLink.LinkVisited = true;

            // Navigate to a URL.
            Process.Start(new ProcessStartInfo("https://docs.jmatthews.uk/docs/sep/features/secure-delete/") { UseShellExecute = true });
        }

        private void txtNumP_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string currentText = textBox.Text;
                try
                {
                    int testCase = Convert.ToInt32(currentText);
                    if (testCase >= 3 && testCase <= 100)
                        btnWipe.Enabled = true;
                    else
                        btnWipe.Enabled = false;
                }
                catch (Exception ex)
                {
                    btnWipe.Enabled = false;
                }
            }
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dirMode = true;
                    dirPath = fbd.SelectedPath;
                    filePath = Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories);
                    fileName = Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories);

                    for (int i = 0; i < fileName.Length; i++)
                    {
                        fileName[i] = Path.GetFileName(filePath[i]);
                    }

                    string currentText = txtNumP.Text;
                    try
                    {
                        int testCase = Convert.ToInt32(currentText);
                        if (testCase >= 3 && testCase <= 100)
                            btnWipe.Enabled = true;
                        else
                            btnWipe.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        btnWipe.Enabled = false;
                    }
                    if (filePath.Length != 1)
                        lbFileName.Text = $"{filePath.Length} files selected!";
                    else
                        lbFileName.Text = fileName[0];
                }
            }
        }
    }
}
