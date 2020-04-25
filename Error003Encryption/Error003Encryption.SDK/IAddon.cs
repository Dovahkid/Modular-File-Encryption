using System;
using System.Collections.Generic;
using System.Text;

namespace Error003Encryption.Sdk
{
    public interface IAddon
    {
        string name { get; set; }

        void FileEncrypt(string filePath, string password);

        void FileDecrypt(string filePath, string password);     

    }
}
