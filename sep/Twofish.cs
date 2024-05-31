using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using System.IO;
using System.Security.Cryptography;

namespace sep
{
    public static class Twofish
    {
        private const int KeySize = 256; // Key size for Twofish can be 128, 192, or 256 bits
        private const int BlockSize = 16; // Block size for Twofish is always 128 bits (16 bytes)

        public static void EncryptFile(string inputFile, byte[] key)
        {
            string outputFile = inputFile + ".2fs";

            byte[] iv = GenerateRandomIV(BlockSize);

            IBufferedCipher cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(new TwofishEngine()));
            cipher.Init(true, new ParametersWithIV(new KeyParameter(key), iv));

            using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
            {
                // Write the IV to the beginning of the output file
                outputFileStream.Write(iv, 0, iv.Length);

                byte[] inputBuffer = new byte[BlockSize];
                byte[] outputBuffer = new byte[cipher.GetOutputSize(inputBuffer.Length)];

                int bytesRead;
                while ((bytesRead = inputFileStream.Read(inputBuffer, 0, inputBuffer.Length)) > 0)
                {
                    int outputBytes = cipher.ProcessBytes(inputBuffer, 0, bytesRead, outputBuffer, 0);
                    outputFileStream.Write(outputBuffer, 0, outputBytes);
                }

                int finalOutputBytes = cipher.DoFinal(outputBuffer, 0);
                outputFileStream.Write(outputBuffer, 0, finalOutputBytes);
            }
        }
        public static void DecryptFile(string inputFile, byte[] key)
        {
            string outputFile = inputFile.Substring(0,inputFile.Length-4);
            
            using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            {
                byte[] iv = new byte[BlockSize];

                // Read the IV from the beginning of the input file
                inputFileStream.Read(iv, 0, iv.Length);

                IBufferedCipher cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(new TwofishEngine()));
                cipher.Init(false, new ParametersWithIV(new KeyParameter(key), iv));

                using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                {
                    byte[] inputBuffer = new byte[BlockSize];
                    byte[] outputBuffer = new byte[cipher.GetOutputSize(inputBuffer.Length)];

                    int bytesRead;
                    while ((bytesRead = inputFileStream.Read(inputBuffer, 0, inputBuffer.Length)) > 0)
                    {
                        int outputBytes = cipher.ProcessBytes(inputBuffer, 0, bytesRead, outputBuffer, 0);
                        outputFileStream.Write(outputBuffer, 0, outputBytes);
                    }

                    int finalOutputBytes = cipher.DoFinal(outputBuffer, 0);
                    outputFileStream.Write(outputBuffer, 0, finalOutputBytes);
                }
            }
        }
        private static byte[] GenerateRandomIV(int size)
        {
            var random = new SecureRandom();
            byte[] iv = new byte[size];
            random.NextBytes(iv);
            return iv;
        }

        public static string EncryptString(string plaintext, byte[] key)
        {
            if (key.Length * 8 != KeySize)
                throw new ArgumentException($"Key size must be {KeySize} bits", nameof(key));

            byte[] iv = GenerateRandomIV(BlockSize);

            IBufferedCipher cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(new TwofishEngine()));
            cipher.Init(true, new ParametersWithIV(new KeyParameter(key), iv));

            byte[] inputBytes = Encoding.UTF8.GetBytes(plaintext);
            byte[] outputBytes = new byte[cipher.GetOutputSize(inputBytes.Length)];

            int length = cipher.ProcessBytes(inputBytes, 0, inputBytes.Length, outputBytes, 0);
            length += cipher.DoFinal(outputBytes, length);

            // Combine IV and ciphertext
            byte[] combinedBytes = new byte[iv.Length + length];
            Array.Copy(iv, 0, combinedBytes, 0, iv.Length);
            Array.Copy(outputBytes, 0, combinedBytes, iv.Length, length);

            return Convert.ToBase64String(combinedBytes);
        }

        public static string DecryptString(string ciphertext, byte[] key)
        {
            if (key.Length * 8 != KeySize)
                throw new ArgumentException($"Key size must be {KeySize} bits", nameof(key));

            byte[] combinedBytes = Convert.FromBase64String(ciphertext);

            if (combinedBytes.Length < BlockSize)
                throw new ArgumentException("The input ciphertext is too short.");

            // Extract the IV from the start of the combined bytes
            byte[] iv = new byte[BlockSize];
            Array.Copy(combinedBytes, 0, iv, 0, iv.Length);

            // Extract the ciphertext from the combined bytes
            byte[] cipherBytes = new byte[combinedBytes.Length - iv.Length];
            Array.Copy(combinedBytes, iv.Length, cipherBytes, 0, cipherBytes.Length);

            IBufferedCipher cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(new TwofishEngine()));
            cipher.Init(false, new ParametersWithIV(new KeyParameter(key), iv));

            byte[] outputBytes = new byte[cipher.GetOutputSize(cipherBytes.Length)];

            int length = cipher.ProcessBytes(cipherBytes, 0, cipherBytes.Length, outputBytes, 0);
            length += cipher.DoFinal(outputBytes, length);

            return Encoding.UTF8.GetString(outputBytes, 0, length);
        }

    }
}
