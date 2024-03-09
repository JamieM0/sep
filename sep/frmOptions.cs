using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sep.Models;

namespace sep
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
            GetOptions();
            CenterToScreen();
        }
        private void GetOptions()
        {
            Options options = new Options();
            options = options.ReadFromFile();
            cbDebugMode.Checked = options.DebugMode == true ? true : false;
            cbEncryptFileNames.Checked = options.EncryptFileNames == true ? true : false;
            cbRemoveDirectoryStructure.Checked = options.RemoveDirectoryStructure == true ? true : false;
        }

        private void btnSaveAndReturn_Click(object sender, EventArgs e)
        {
            SaveOptions();
            Hide();
            new frmHome().Show();
        }
        private void SaveOptions()
        {
            Options options = new Options();
            options.DebugMode = cbDebugMode.Checked;
            options.EncryptFileNames = cbEncryptFileNames.Checked;
            options.RemoveDirectoryStructure = cbRemoveDirectoryStructure.Checked;
            options.SaveToFile();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
