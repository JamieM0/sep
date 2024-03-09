using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using sep.Models;

namespace sep
{
    public class AES
    {
        public bool willKeepOriginal;
        
        //  Call this function to remove the key from memory after use for security
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        // Creates a random salt that will be used to encrypt your file. This method is required on FileEncrypt.
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);
                }
            }

            return data;
        }

        public static void FileEncrypt(string inputFile, string password, bool usingMFA, string currentID)
        {
            //http://stackoverflow.com/questions/27645527/aes-encryption-on-large-files

            //generate random salt
            byte[] salt = GenerateRandomSalt();

            int pwLibID=0;
            bool usingPWLib = false;

            DateTime inputCreationDate = File.GetCreationTime(inputFile);

            //create output file name
            FileStream fsCrypt;
            if (usingMFA)
            {
                string directory = Path.GetDirectoryName(inputFile);
                string fileName = Path.GetFileName(inputFile);

                string newFileName = $"{currentID}-{fileName}";

                string outputFile = Path.Combine(directory, newFileName);

                string extension = ".mfa";

                fsCrypt = new FileStream(outputFile + extension, FileMode.Create);
                
            }
            else
            {
                string extension = ".aes";
                fsCrypt = new FileStream(inputFile + extension, FileMode.Create);
            }

            //convert password string to byte arrray
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            //Set Rijndael symmetric encryption algorithm
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            //http://stackoverflow.com/questions/2659214/why-do-i-need-to-use-the-rfc2898derivebytes-class-in-net-instead-of-directly
            //"What it does is repeatedly hash the user password along with the salt." High iteration counts.
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            //Cipher modes: http://security.stackexchange.com/questions/52665/which-is-the-best-cipher-mode-and-padding-mode-for-aes-encryption
            AES.Mode = CipherMode.CFB;

            // write salt to the begining of the output file, so in this case can be random every time
            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            //create a buffer (1mb) so only this amount will allocate in the memory and not the whole file
            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    cs.Write(buffer, 0, read);
                }

                // Close up
                fsIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Options options = new Options();
                options = options.ReadFromFile();
                if (options.EncryptFileNames)
                {
                    //Get the file name (without extension or path)
                    string fileName = Path.GetFileNameWithoutExtension(inputFile);

                    //Encrypt the file name (excluding path and extension)
                    string encFileName = AesOperation.EncryptString(password, fileName);

                    //Get the file extension
                    string extension = Path.GetExtension(inputFile) + ".aes";

                    //Get the directory
                    string directory = Path.GetDirectoryName(inputFile);

                    //Create the new file name
                    string newFileName = Path.Combine(directory, encFileName + extension);

                    //Close the CryptoStream before renaming the file
                    cs.Close();
                    fsCrypt.Close();

                    //Rename the file
                    File.Move(inputFile + ".aes", newFileName);
                }
                else
                {
                    // Close the CryptoStream and FileStream
                    cs.Close();
                    fsCrypt.Close();

                    // Set the creation time of the encrypted file
                    File.SetCreationTime(fsCrypt.Name, inputCreationDate);
                }
            }
        }
        public static void FileEncrypt(string inputFile, string outputFile, string password)
        {
            //http://stackoverflow.com/questions/27645527/aes-encryption-on-large-files

            //generate random salt
            byte[] salt = GenerateRandomSalt();

            //create output file name
            FileStream fsCrypt = new FileStream(outputFile, FileMode.Create);

            //convert password string to byte arrray
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            //Set Rijndael symmetric encryption algorithm
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            //http://stackoverflow.com/questions/2659214/why-do-i-need-to-use-the-rfc2898derivebytes-class-in-net-instead-of-directly
            //"What it does is repeatedly hash the user password along with the salt." High iteration counts.
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            //Cipher modes: http://security.stackexchange.com/questions/52665/which-is-the-best-cipher-mode-and-padding-mode-for-aes-encryption
            AES.Mode = CipherMode.CFB;

            // write salt to the begining of the output file, so in this case can be random every time
            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            //create a buffer (1mb) so only this amount will allocate in the memory and not the whole file
            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    cs.Write(buffer, 0, read);
                }

                // Close up
                fsIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }

        /// <summary>
        /// Decrypts an encrypted file with the FileEncrypt method through its path and the plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        /// <param name="password"></param>
        public static void FileDecrypt(string inputFile, string outputFile, string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                Options options = new Options();
                options = options.ReadFromFile();
                if(options.EncryptFileNames)
                {
                    //Get the file name (without extension or path)
                    string fileNameStep1 = Path.GetFileNameWithoutExtension(inputFile);
                    string fileName = fileNameStep1.Split('.')[0];

                    //Decrypt the file name (excluding path and extension)
                    string decFileName = AesOperation.DecryptString(password, fileName);

                    //Get the directory
                    string directory = Path.GetDirectoryName(inputFile);

                    //Get the file extension
                    string extension = Path.GetExtension(Path.Combine(directory,fileNameStep1));

                    //Create the new file name
                    string newFileName = Path.Combine(directory, decFileName + extension);

                    //Close the CryptoStream before renaming the file
                    fsOut.Close();
                    cs.Close();
                    fsCrypt.Close();

                    //Rename the file
                    File.Move(fsOut.Name, newFileName);
                }
                else
                {
                    File.SetCreationTime(fsOut.Name, DateTime.Now);
                    fsOut.Close();
                    fsCrypt.Close();
                }
            }
        }
    }
}
