using sep.Models;
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
            if (Options.EncryptionAlgorithm != "AES-256")
            {
                MessageBox.Show($"{Options.EncryptionAlgorithm} is your current encryption algorithm, but it won't be used for encrypting or decrypting strings, instead, AES-256 will be used.", "AES-256 will be used for encrypting or decrypting strings.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                try
                {
                    if (Options.EncryptionAlgorithm == "AES-256")
                        txtOutput.Text = AesOperation.EncryptString(txtPassword.Text, txtInput.Text);
                    else if (Options.EncryptionAlgorithm == "Twofish")
                        txtOutput.Text = Twofish.EncryptString(txtInput.Text, AesOperation.Hasher(txtPassword.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while encrypting the string. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInput.Enabled = true;
                    txtPassword.Enabled = true;
                    return;
                }
            }
            else
            {
                try
                {
                    if (Options.EncryptionAlgorithm == "AES-256")
                        txtOutput.Text = AesOperation.DecryptString(txtPassword.Text, txtInput.Text);
                    else if (Options.EncryptionAlgorithm == "Twofish")
                        txtOutput.Text = Twofish.DecryptString(txtInput.Text, AesOperation.Hasher(txtPassword.Text));
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An error occurred while decrypting the string. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInput.Enabled = true;
                    txtPassword.Enabled = true;
                    return;
                }
            }

            txtOutput.Visible = true;
            lbInfoOutput.Visible = true;
            btnCopy.Visible = true;
            btnReset.Visible = true;
            btnSwitch.Visible = true;
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
            btnSwitch.Visible = false;
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

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if(encryptMode)
            {
                Hide();
                new frmFunctionString(false).Show();
            }
            else
            {
                Hide();
                new frmFunctionString(true).Show();
            }
        }
    }
}
