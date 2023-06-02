using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sep
{
    public partial class frmPasswordLibrary : Form
    {
        public frmPasswordLibrary()
        {
            InitializeComponent();
            string libEN = "pwLib.conf.aes";
            string libDE = "pwLib.conf";
            try
            {
                string pw = Microsoft.VisualBasic.Interaction.InputBox("Input password library master password: ", "Password Library Decryption");
                frmHome.a.FileDecrypt(libEN, libDE, pw);
                string[] lines = File.ReadAllLines(libDE);
                Array.Reverse(lines);
                File.Delete(libDE);
                for(int i=0; i<lines.Length; i++)
                {
                    string[] a = lines[i].Split('~');
                    PopulateFields(i, a[1], a[2], a[0]);
                }
            }
            //catch(FileNotFoundException ex)
            //{
            //    string pw = Microsoft.VisualBasic.Interaction.InputBox("Create a password library. Enter a master password: ", "Password Library Creation");
            //}
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Password.\r\nMore Details: " + ex.Message, "Password Library Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopulateFields(int index, string fileName, string password, string date)
        {
            Panel pnl = new Panel();
            pnl.Location = new Point(12, 50+index*52);
            pnl.Size = new Size(776, 46);
            Controls.Add(pnl);

            Label saveDate = new Label();
            saveDate.Location = new Point(3, 10);
            saveDate.Font = new Font("Segoe UI", 14);
            saveDate.Text = date;
            pnl.Controls.Add(saveDate);

            Label FileName = new Label();
            FileName.Location = new Point(120, 10);
            FileName.Font = new Font("Segoe UI", 14);
            FileName.Text = fileName;
            pnl.Controls.Add(FileName);

            PictureBox remove = new PictureBox();
            remove.Location = new Point(733, 3);
            remove.Size = new Size(40, 40);
            remove.Image = Properties.Resources.remove;
            remove.SizeMode = PictureBoxSizeMode.Zoom;
            pnl.Controls.Add(remove);

            Button copy = new Button();
            copy.Location = new Point(632, 8);
            copy.Size = new Size(95, 31);
            copy.Text = "Copy";
            pnl.Controls.Add(copy);

            TextBox textBox = new TextBox();
            textBox.Location = new Point(380, 6);
            textBox.Size = new Size(184, 33);
            textBox.Font = new Font("Segoe UI", 14);
            textBox.Text = password;
            textBox.ReadOnly = true;
            pnl.Controls.Add(textBox);
        }
        
        public void remove_Click()
        {
            
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            //Prompt with confirm action
            if (MessageBox.Show("Are you sure you want to remove all entries in the password library?\r\nThere is no way to undo this action.", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Remove all passwords
                File.Delete("pwLib.conf");
                File.Delete("pwLib.conf.aes");
                Hide();
                new frmHome().Show();
                ////Prompt with success
                //MessageBox.Show("All passwords have been removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }
    }
}
