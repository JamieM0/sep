using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace sep
{
    internal class DatabaseHelper
    {
        private static readonly string AppDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string DatabaseFolderPath = Path.Combine(AppDataFolderPath, "sep"); // Change "YourAppName" to your application name.

        private static readonly string DatabaseFileName = "privateKeys.db";
        private static readonly string DatabaseFilePath = Path.Combine(DatabaseFolderPath, DatabaseFileName);

        private static readonly string ConnectionString = "Data Source=" + DatabaseFilePath + ";Version=3;";

        public static void InitializeDatabase()
        {
            if (!Directory.Exists(DatabaseFolderPath))
            {
                Directory.CreateDirectory(DatabaseFolderPath);
            }

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Create the table if it doesn't exist.
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS FileData (
                                          Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                          FileName TEXT NOT NULL,
                                          SecretKey TEXT NOT NULL
                                      );";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Add a method to insert data into the table.
        public static void InsertFileData(string fileName, string secretKey)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO FileData (FileName, SecretKey) VALUES (@FileName, @SecretKey);";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@FileName", fileName);
                    command.Parameters.AddWithValue("@SecretKey", secretKey);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // Add a method to retrieve the SecretKey from a given id
        public static string GetSecretKey(int id)
        {
            string secretKey = null;

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT SecretKey FROM FileData WHERE Id = @Id;";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            secretKey = reader.GetString(0);
                        }
                    }
                }
            }

            return secretKey;
        }

        // Add a method to count the number of entries in the table.
        public static int CountFileData()
        {
            int count = 0;

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string countQuery = "SELECT COUNT(*) FROM FileData;";

                using (var command = new SQLiteCommand(countQuery, connection))
                {
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return count;
        }

        // Loop through every entry in the table in the specified column and return true or false if a specified string is found
        public static bool SearchDatabase(string fileName)
        {
            bool duplicate = false;
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT FileName FROM FileData;";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(0) == fileName)
                            {
                                duplicate = true;
                            }
                        }
                    }
                }
            }

            return duplicate;
        }
        // Add other database operations as needed (e.g., retrieve data, update data, delete data, etc.).
    }
    
    internal class DatabaseHelperPL 
    {
        
        private static readonly string AppDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string DatabaseFolderPath = Path.Combine(AppDataFolderPath, "sep"); // Change "YourAppName" to your application name.

        public static readonly string DatabaseFileName = "pwLib.db";
        private static readonly string DatabaseFilePath = Path.Combine(DatabaseFolderPath, DatabaseFileName);
        public static readonly string EncryptedDatabaseFilePath = DatabaseFilePath + ".aes";
        
        private static readonly string ConnectionString = "Data Source=" + DatabaseFilePath + ";Version=3;";

        public static void InitializeDatabase()
        {
            if (File.Exists(EncryptedDatabaseFilePath))
                return;
            if (!Directory.Exists(DatabaseFolderPath))
            {
                Directory.CreateDirectory(DatabaseFolderPath);
            }
            
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Create the table if it doesn't exist.
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS PWLib (
                                          Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                          FileName TEXT NOT NULL,
                                          Password TEXT NOT NULL
                                      );";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Add a method to insert data into the table.
        public static void InsertPWLib(string fileName, string password)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO PWLib (FileName, Password) VALUES (@FileName, @Password);";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@FileName", fileName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.ExecuteNonQuery();
                }
            }
        }


        // Add a method to retrieve the Password from a given id
        public static string GetPassword(int id)
        {
            string password = null;

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Password FROM PWLib WHERE Id = @Id;";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            password = reader.GetString(0);
                        }
                    }
                }
            }

            return password;
        }

        // Add a method to count the number of entries in the table.
        public static int CountPasswordData()
        {
            int count = 0;

            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string countQuery = "SELECT COUNT(*) FROM PWLib;";

                    using (var command = new SQLiteCommand(countQuery, connection))
                    {
                        count = Convert.ToInt32(command.ExecuteScalar());
                    }
                }

                return count;
            }
            catch
            {
                return -1;
            }
        }

        public static void EncryptPWLib(string pw)
        {
            AES.FileEncrypt(DatabaseFilePath, EncryptedDatabaseFilePath, pw);
            File.Delete(DatabaseFilePath);
        }
        public static void DecryptPWLib(string pw)
        {
            AES.FileDecrypt(EncryptedDatabaseFilePath, DatabaseFilePath, pw);
        }
        // Add other database operations as needed (e.g., retrieve data, update data, delete data, etc.).
    }
}
