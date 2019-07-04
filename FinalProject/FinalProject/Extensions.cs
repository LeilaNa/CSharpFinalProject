using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FinalProject
{
    class Extensions
    {
        public static string hashPassword(string password)
        {
            byte[] byteArray = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hashedArray = new SHA256Managed().ComputeHash(byteArray);
            string hashedPassword = ASCIIEncoding.ASCII.GetString(hashedArray);

            return hashedPassword;
        }

        public static bool checkPassword(string password, string hashedpassword)
        {
            return hashPassword(password) == hashedpassword;
        }
    }
}
