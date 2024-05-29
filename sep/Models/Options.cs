using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace sep.Models
{
    public static class Options
    {
        public static bool DebugMode { get; set; }
        public static bool EncryptFileNames { get; set; }
        public static bool RemoveDirectoryStructure { get; set; }
        public static string EncryptionAlgorithm { get; set; }

        public static void SaveToFile()
        {
            var optionsData = new
            {
                DebugMode,
                EncryptFileNames,
                RemoveDirectoryStructure,
                EncryptionAlgorithm
            };

            string json = JsonSerializer.Serialize(optionsData);
            File.WriteAllText(Path.Combine(OtherOperations.storeLoc, "options.json"), json);
        }
        public static void ReadFromFile()
        {
            string json = File.ReadAllText(Path.Combine(OtherOperations.storeLoc, "options.json"));
            if (string.IsNullOrWhiteSpace(json))
            {
                throw new InvalidDataException("The file content is empty.");
            }
            var optionsData = JsonSerializer.Deserialize<OptionsData>(json);
            if (optionsData == null)
            {
                throw new InvalidOperationException("Deserialization returned null.");
            }

            DebugMode = false;
            EncryptFileNames = false;
            RemoveDirectoryStructure = false;
            EncryptionAlgorithm = "AES-256";

            if (optionsData != null)
            {
                DebugMode = optionsData.DebugMode;
                EncryptFileNames = optionsData.EncryptFileNames;
                RemoveDirectoryStructure = optionsData.RemoveDirectoryStructure;
                EncryptionAlgorithm = optionsData.EncryptionAlgorithm;
            }
        }
        private class OptionsData
        {
            public bool DebugMode { get; set; }
            public bool EncryptFileNames { get; set; }
            public bool RemoveDirectoryStructure { get; set; }
            public string EncryptionAlgorithm { get; set; }
        }
    }
}
