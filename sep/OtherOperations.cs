using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sep
{
    internal class OtherOperations
    {
        public static string filePath { get; set; }
        public static string storeLoc { get; set; }
        
        public static void LineRemover(string file, int indexRemove)
        {
            string[] lines = File.ReadAllLines(file);
            string[] newLines = new string[lines.Length - 1];
            int j = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (i != indexRemove)
                {
                    newLines[j] = lines[i];
                    j++;
                }
            }
            File.WriteAllLines(file, newLines);
            File.WriteAllLines(file, File.ReadAllLines(file).Where(l => !string.IsNullOrWhiteSpace(l)));
        }
        public static void LineChanger(string file, string find, string replace)
        {
            string[] lines = File.ReadAllLines(file);
            for(int i=0; i<lines.Length; i++)
            {
                if (lines[i].Contains(find))
                {
                    lines[i] = replace;
                }
            }
            File.WriteAllLines(file, lines);
        }
        public static void SaveToLibrary(string fileName, string password)
        {
            string libEN = "pwLib.conf.aes";
            string libDE = "pwLib.conf";
            DateTime current = new DateTime();
            if (File.Exists(libEN))
            {
                string pw = Microsoft.VisualBasic.Interaction.InputBox("Input password library master password: ", "Password Library Decryption");
                frmHome.a.FileDecrypt(libEN, libDE, pw);
                current = DateTime.Now;
                string currentWritable = current.ToString("d");
                File.AppendAllText(libDE, $"\r\n{currentWritable}~{fileName}~{password}");
                File.WriteAllLines(libDE, File.ReadAllLines(libDE).Where(l => !string.IsNullOrWhiteSpace(l)));
                frmHome.a.FileEncrypt(libDE, pw, false);
                File.Delete(libDE);
            }
            else
            {
                string pw = Microsoft.VisualBasic.Interaction.InputBox("Create a password for your password library: ", "Password Library Decryption");
                current = DateTime.Now;
                string currentWritable = current.ToString("d");
                File.WriteAllText(libDE, $"{currentWritable}~{fileName}~{password}");
                File.WriteAllLines(libDE, File.ReadAllLines(libDE).Where(l => !string.IsNullOrWhiteSpace(l)));
                frmHome.a.FileEncrypt(libDE, pw,false);
                File.Delete(libDE);
            }
        }
    }
}
