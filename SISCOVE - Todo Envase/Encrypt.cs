using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SISCOVE___Todo_Envase
{
    public class Encrypt
    {
        public string Encryption(string password)
        {
            StringBuilder BuilderString = new StringBuilder();
            MD5 hashMD5 = MD5.Create();

            byte[] EncryptedPassword = hashMD5.ComputeHash(Encoding.Default.GetBytes(password));

            for (int i = 0; i < EncryptedPassword.Length; i++)
            {
                BuilderString.Append(EncryptedPassword[i].ToString("x2"));
            }
            return BuilderString.ToString();
        }
    }

}
