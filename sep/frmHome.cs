using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace sep
{
    public partial class frmHome : Form
    {

        public static AES a = new AES();
        
        public frmHome()
        {
            InitializeComponent();
            CenterToScreen();
            if(!File.Exists("first.load"))
            {
                MessageBox.Show("Warning: This project is still in development. Please use at your own risk.\r\n\r\nThis message will not show again (until the first.load file is removed).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                File.Create("first.load");
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
    }
}
