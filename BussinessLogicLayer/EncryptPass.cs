using EasyCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public static class EncryptPass
    {
        public static string Encrypt(string store_pass,string master_pass)
        {
            return AesEncryption.EncryptWithPassword(store_pass, master_pass);
        }

        public static string Decrypt(string encrypted_pass,string master_pass)
        {
            return AesEncryption.DecryptWithPassword(encrypted_pass, master_pass);
        }
    }
}
