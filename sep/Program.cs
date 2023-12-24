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
    //public class LockerObj
    //{
    //    public int Id { get; set; }        // Unique identifier (primary key).
    //    public string LockerName { get; set; }
    //    public string LockerPassword { get; set; }
    //    public string LockerPath { get; set; }
    //    public bool LockState { get; set; }
    //    public LockerObj(int lockerID, string lockerName, string lockerPassword, string lockerPath, bool lockState)
    //    {
    //        Id = lockerID;
    //        LockerName = lockerName;
    //        LockerPassword = lockerPassword;
    //        LockerPath = lockerPath;
    //        LockState = lockState;
    //    }
    //}
}
