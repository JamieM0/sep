using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        string filePath;
        string fileName;
        int numP;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Open file dialog, and get a file to wipe
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a file to wipe";
            ofd.Filter = "All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
            lbFileName.Text = fileName;
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            numP = Convert.ToInt32(txtNumP.Text);
            //If user has chosen more than 15 passes ask to confirm to continue
            if (numP>15)
            {
                DialogResult ar = MessageBox.Show("Are you sure you want to make " + numP + " passes?\r\n3 times is likely enough, as recommended by security experts, and this may be overkill.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ar == DialogResult.No)
                {
                    return;
                }
            }

            //Ask user to confirm
            DialogResult dr = MessageBox.Show("Are you sure you want to wipe this file? It will become unrecoverable, and lost forever?\r\nClick \"Cancel\" to cancel.", "Confirm", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //Wipe the file
                AesOperation.SecureDelete(filePath, numP);
                MessageBox.Show("File Wiped Successfully!");
            }
            else
            {
                Hide();
                new frmHome().Show();
            }
        }
    }
}
