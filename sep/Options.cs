using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace sep
{
    public class Options
    {
        public bool DebugMode { get; set; }
        public bool EncryptFileNames { get; set; }
        public bool RemoveDirectoryStructure { get; set; }

        public Options()
        {
            DebugMode = false;
            EncryptFileNames = false;
            RemoveDirectoryStructure = false;
        }

        public void SaveToFile()
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(Path.Combine(OtherOperations.storeLoc, "options.json"), json);
        }
        public Options ReadFromFile()
        {
            string json = File.ReadAllText(Path.Combine(OtherOperations.storeLoc, "options.json"));
            Options options = JsonSerializer.Deserialize<Options>(json);
            //DebugMode = options.DebugMode;
            //EncryptFileNames = options.EncryptFileNames;
            //RemoveDirectoryStructure = options.RemoveDirectoryStructure;
            return options;
        }
    }
}
