using System;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

using Error003Encryption.Sdk;
using System.IO;

namespace AES_Encryption
{
    public class AES : IAddon
    {
        public AES()
        {
            name = "AES";
        }

        public string name { get; set; }

        static byte[] GenerateRandomSalt()
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

        public void FileEncrypt(string filePath, string password)
        {
            
        }

        public void FileDecrypt(string filePath, string password)
        {
            
        }
    }
}
