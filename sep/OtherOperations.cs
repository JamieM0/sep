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
    }
}
