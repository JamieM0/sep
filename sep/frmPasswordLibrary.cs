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
using sep.Models;

namespace sep
{
    public partial class frmPasswordLibrary : Form
    {
        string password = "";
        bool validCred = true;
        public frmPasswordLibrary()
        {
            InitializeComponent();
            string libEN = "pwLib.conf.aes";
            string libDE = "pwLib.conf";
            tmrTick.Start();
            CenterToScreen();
            try
            {
                password = Microsoft.VisualBasic.Interaction.InputBox("Input password library master password: ", "Password Library Decryption");
                AES.FileDecrypt(libEN, libDE, password);
                string[] lines = File.ReadAllLines(libDE);
                //Array.Reverse(lines);
                File.Delete(libDE);
                for (int i=0; i<lines.Length; i++)
                {
                    string[] a = lines[i].Split('~');
                    PopulateFields(i, a[1], a[2], a[0]);
                }
            }
            //catch(FileNotFoundException ex)
            //{
            //    string pw = Microsoft.VisualBasic.Interaction.InputBox("Create a password library. Enter a master password: ", "Password Library Creation");
            //}
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Incorrect Password.", "Password Library Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.Delete("pwLib.conf");
                validCred = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured.\r\nMore Details: " + ex.Message, "Password Library Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.Delete("pwLib.conf");
                validCred = false;
            }
        }

        public void PopulateFields(int index, string fileName, string password, string date)
        {
            Panel pnl = new Panel();
            pnl.Location = new Point(12, 50+index*52);
            pnl.Size = new Size(776, 46);
            pnl.Name = $"pnl_{index}";
            Controls.Add(pnl);

            Label saveDate = new Label();
            saveDate.Location = new Point(3, 10);
            saveDate.Font = new Font("Segoe UI", 14);
            saveDate.Text = date;
            saveDate.Size = new Size(110, 25);
            pnl.Controls.Add(saveDate);

            Label FileName = new Label();
            FileName.BringToFront();
            FileName.Location = new Point(120, 10);
            FileName.Font = new Font("Segoe UI", 14);
            FileName.Text = fileName;
            FileName.Size = new Size(300, 25);
            pnl.Controls.Add(FileName);

            PictureBox remove = new PictureBox();
            remove.Location = new Point(733, 3);
            remove.Size = new Size(40, 40);
            remove.Image = Properties.Resources.remove;
            remove.SizeMode = PictureBoxSizeMode.Zoom;
            remove.Click += Remove_Click;
            remove.Name = $"btnRemove_{index}";
            pnl.Controls.Add(remove);

            Button copy = new Button();
            copy.Location = new Point(632, 8);
            copy.Size = new Size(95, 31);
            copy.Text = "Copy";
            copy.Name = $"btnCopy_{index}";
            copy.Click += Copy_Click;
            pnl.Controls.Add(copy);

            TextBox textBox = new TextBox();
            textBox.Location = new Point(490, 6);
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.Font = new Font("Segoe UI", 14);
            Size size = TextRenderer.MeasureText(password, textBox.Font);
            textBox.Size = new Size(size.Width+10, size.Height);
            //textBox.AutoSize = true;
            textBox.Text = password;
            textBox.ReadOnly = true;
            textBox.Name = $"txtPassword_{index}";
            pnl.Controls.Add(textBox);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            //Get index from remove button
            AES.FileDecrypt("pwLib.conf.aes", "pwLib.conf", password);
            PictureBox pb = sender as PictureBox;
            int index = Convert.ToInt32(pb.Name.Split('_')[1]);
            OtherOperations.LineRemover("pwLib.conf", index);
            Hide();
            new frmHome().Show();
            AES.FileEncrypt("pwLib.conf", password,false,"0");
            File.Delete("pwLib.conf");
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            //Get index from remove button
            Button btn = sender as Button;
            int index = Convert.ToInt32(btn.Name.Split('_')[1]);

            //Search all controls for one called txtPassword_i
            foreach (Control c in Controls)
            {
                if (c.Name == $"pnl_{index}")
                {
                    foreach(Control b in c.Controls)
                    {
                        if(b.Name == $"txtPassword_{index}")
                        {
                            Clipboard.SetText(b.Text);
                            MessageBox.Show("Password copied to clipboard.", "Password Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
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

        private void frmPasswordLibrary_Load(object sender, EventArgs e)
        {

        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            if(!validCred)
            {
                Hide();
                new frmHome().Show();
                tmrTick.Stop();
            }
        }
    }
}
