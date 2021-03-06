﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AnalyticsLibrary.Helpers
{
    public static class Crypt
    {

        private static byte[] salt = Encoding.ASCII.GetBytes("9asd$ioasj/&75z");
        private static string secret = "23sdad§$da&d%§$34gaz";
        /// <summary>
        ///  Hash the password to secret.
        /// </summary>
        /// <param name="password">Passwort</param>
        /// <returns>Password Hash // secret</returns>
        public static string EncodeHash(string username, string password)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            byte[] digest = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
            string base64digest = Convert.ToBase64String(digest, 0, digest.Length);
            return base64digest.Substring(0, base64digest.Length - 2);
        }


        /// <summary>
        /// Encrypt a string
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns>Decryptet String</returns>
        public static string Encrypt(string plainText)
        {
            Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(secret, salt);

            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(new CryptoStream(ms, new RijndaelManaged().CreateEncryptor(key.GetBytes(32), key.GetBytes(16)), CryptoStreamMode.Write));
            sw.Write(plainText);
            sw.Close();
            ms.Close();
            return Convert.ToBase64String(ms.ToArray());
        }
        /// <summary>
        /// Decrypt a encrypted string
        /// </summary>
        /// <param name="base64Text"></param>
        /// <returns></returns>
        public static string Decrypt(string base64Text)
        {
            Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(secret, salt);

            ICryptoTransform d = new RijndaelManaged().CreateDecryptor(key.GetBytes(32), key.GetBytes(16));
            byte[] bytes = Convert.FromBase64String(base64Text);
            return new StreamReader(new CryptoStream(new MemoryStream(bytes), d, CryptoStreamMode.Read)).ReadToEnd();
        }
    }
}