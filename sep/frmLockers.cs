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
    public partial class frmLockers : Form
    {
        public frmLockers()
        {
            InitializeComponent();
            PopulateFields(0, "testlockername");
        }

        public void PopulateFields(int index, string lockname)
        {
            Panel pnl = new Panel();
            if (index == 0 || index % 2 == 0)
            {
                pnl.Location = new Point(12, 110 + index * 53);
            }
            else
            {
                pnl.Location = new Point(493, 110 + index * 53);
            }
            pnl.Size = new Size(410, 45);
            pnl.Name = $"pnl_{index}";
            Controls.Add(pnl);

            Label lockerName = new Label();
            lockerName.Location = new Point(111, 10);
            lockerName.TextAlign = ContentAlignment.MiddleRight;
            lockerName.Anchor = AnchorStyles.Right;
            lockerName.Font = new Font("Segoe UI", 14);
            lockerName.Text = lockname;
            lockerName.AutoSize = false;
            lockerName.Name = $"txtLockerName_{index}";
            pnl.Controls.Add(lockerName);

            Button lockAction = new Button();
            lockAction.Location = new Point(180, 7);
            lockAction.Size = new Size(110, 32);
            lockAction.Text = "Copy";
            lockAction.Font = new Font("Segoe UI", 14);
            lockAction.Name = $"btnCopy_{index}";
            lockAction.Click += LockAction_Click;
            pnl.Controls.Add(lockAction);

            Button openLocker = new Button();
            openLocker.Location = new Point(296, 7);
            openLocker.Size = new Size(110, 32);
            openLocker.Text = "Copy";
            openLocker.Font = new Font("Segoe UI", 14);
            openLocker.Name = $"btnCopy_{index}";
            openLocker.Click += OpenLockerAction_Click;
            pnl.Controls.Add(openLocker);
        }

        private void LockAction_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = int.Parse(btn.Name.Split('_')[1]);
            TextBox txt = (TextBox)Controls.Find($"txtPassword_{index}", true)[0];
            Clipboard.SetText(txt.Text);
        }

        private void OpenLockerAction_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = int.Parse(btn.Name.Split('_')[1]);
            TextBox txt = (TextBox)Controls.Find($"txtPassword_{index}", true)[0];
            Clipboard.SetText(txt.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }
    }
}
