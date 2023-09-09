using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Authenticator;

namespace sep
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseHelper.InitializeDatabase();
            DatabaseHelperPL.InitializeDatabase();
            DatabaseHelperLK.InitializeDatabase();
            Application.Run(new frmHome());
        }
    }

    public class FileData
    {
        public int Id { get; set; }        // Unique identifier (primary key).
        public string FileName { get; set; }
        public string SecretKey { get; set; }
    }
}
