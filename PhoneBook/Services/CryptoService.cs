using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services
{
    public class CryptoService
    {
        private static int _iterations = 2000;
        private static byte[] _salt = Encoding.Unicode.GetBytes("360DGETTY");
        private static string _password = "^YHN5tb7ujm";

        private static Aes GetAesInstance()
        {
            var pbkdf2 = new Rfc2898DeriveBytes(_password, _salt, _iterations);

            Aes aes = Aes.Create();
            aes.Key = pbkdf2.GetBytes(32);
            aes.IV = pbkdf2.GetBytes(16);
            return aes;
        }


        /// <summary>
        /// Шифрование
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string Encrypt(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
                return "";
            byte[] plainBytes = Encoding.Unicode.GetBytes(plainText);

            Aes aes = GetAesInstance();

            var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cs.Write(plainBytes, 0, plainBytes.Length);
            }

            return Convert.ToBase64String(ms.ToArray());
        }


        /// <summary>
        /// Дешифровка
        /// </summary>
        /// <param name="cryptoText"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string Decrypt(string cryptoText)
        {
            if (string.IsNullOrEmpty(cryptoText))
                return "";
            byte[] cryptoBytes = Convert.FromBase64String(cryptoText);

            Aes aes = GetAesInstance();

            var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
            {
                cs.Write(cryptoBytes, 0, cryptoBytes.Length);
            }

            return Encoding.Unicode.GetString(ms.ToArray());
        }
    }
}
