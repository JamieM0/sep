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
    public partial class frmFunctionString : Form
    {
        bool encryptMode = true;
        public frmFunctionString(bool EncryptMode)
        {
            encryptMode = EncryptMode;
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(850, 450);
            if (!encryptMode)
            {
                this.Text = "SEP: Decrypt String";
                lbInfo.Text = "Decrypt String";
                lbInfoInput.Text = "Enter the encrypted string you want to decrypt:";
                btnConfirmInput.Text = "Decrypt String";
                lbInfoOutput.Text = "Decrypted String:";
                txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                txtOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                pnlPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            }
            CenterControlToFormHorizontally(lbInfo);
            CenterToScreen();
        }

        public void CenterControlToFormHorizontally(Control control)
        {
            // Check if the control and its parent form are not null

            if (control != null && control.Parent != null)
            {
                // Get the width of the control and its parent form
                int controlWidth = control.Width;
                int formWidth = control.Parent.Width;

                // Calculate the left position of the control to center it horizontally
                int left = (formWidth - controlWidth) / 2;

                // Set the left property of the control
                control.Left = left;
            }
        }

        private void frmFunctionString_Resize(object sender, EventArgs e)
        {
            CenterControlToFormHorizontally(lbInfo);
        }

        private void btnConfirmInput_Click(object sender, EventArgs e)
        {
            txtInput.Enabled = false;
            txtPassword.Enabled = false;

            if (encryptMode)
            {
                txtOutput.Text = AesOperation.EncryptString(txtPassword.Text, txtInput.Text);
            }
            else
            {
                txtOutput.Text = AesOperation.DecryptString(txtPassword.Text, txtInput.Text);
            }

            txtOutput.Visible = true;
            lbInfoOutput.Visible = true;
            btnCopy.Visible = true;
            btnReset.Visible = true;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOutput.Text);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnCopy_MouseEnter(object sender, EventArgs e)
        {
            btnCopy.BackgroundImage = Properties.Resources.copy_icon_active;
        }

        private void btnCopy_MouseLeave(object sender, EventArgs e)
        {
            btnCopy.BackgroundImage = Properties.Resources.copy_icon;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackgroundImage = Properties.Resources.reset_icon_active;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackgroundImage = Properties.Resources.reset_icon;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnCopy.Visible = false;
            btnReset.Visible = false;
            txtOutput.Visible = false;
            lbInfoOutput.Visible = false;
            txtInput.Enabled = true;
            txtPassword.Enabled = true;
            txtInput.Text = "";
            txtPassword.Text = "";
            txtOutput.Text = "";
        }

        private void btnGoMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }
    }
}
