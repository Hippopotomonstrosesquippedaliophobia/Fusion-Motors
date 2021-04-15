using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Database_Application_Chris
{
    public class Utilities
    {
        public static string HashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] passwod_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrypted_bytes = sha1.ComputeHash(passwod_bytes);

            return Convert.ToBase64String(encrypted_bytes);
        }


    }
}
