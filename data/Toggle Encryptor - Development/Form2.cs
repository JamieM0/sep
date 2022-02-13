using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Toggle_Encryptor___Development
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/ToggleCorp/tepp");
            //Process.Start(sInfo);
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/ToggleCorp/tepp",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Form3().Show();
        }
    }
}
