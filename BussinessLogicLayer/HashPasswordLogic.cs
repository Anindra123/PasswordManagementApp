using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public static class HashPasswordLogic
    {
        public static string HashPass(string pass)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pass));
                StringBuilder output = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    output.Append(bytes[i].ToString("x2"));
                }
                return output.ToString();
            }
        }
    }
}
