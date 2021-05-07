using Scrypt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Slaptazodziu_valdymo_sistema
{
    class PasswordHashing
    {
        private ScryptEncoder scryptEncoder = new ScryptEncoder();
        public string creatingHashedPassword(string password)
        {
            string hashedPassword = scryptEncoder.Encode(password);
            return hashedPassword;
        }
        public bool comparePassword(string password, string hashedPassword)
        {
            bool areEquals = scryptEncoder.Compare(password, hashedPassword);
            return areEquals;
        }

        public string EncryptingAndDecryptingPasswordWithDES (string password, bool encryptOrDecrypt)
        {
            Encoding encoding = Encoding.GetEncoding("437");
            string key = "dainoras";

            byte[] keyNumbers = encoding.GetBytes(key);
            byte[] textNumbers = encoding.GetBytes(password);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = keyNumbers;
            DES.BlockSize = 64;
            DES.Mode = CipherMode.ECB;


            MemoryStream memoryStream = new MemoryStream(); // memoryStream į kurį įrašomas rezultatas
            memoryStream.Position = 0;
            CryptoStream cryptoStream = null;
            if (encryptOrDecrypt == true)
                cryptoStream = new CryptoStream(memoryStream, DES.CreateEncryptor(), CryptoStreamMode.Write);
            if (encryptOrDecrypt == false)
                cryptoStream = new CryptoStream(memoryStream, DES.CreateDecryptor(), CryptoStreamMode.Write);

            cryptoStream.Write(textNumbers, 0, textNumbers.Length);
            cryptoStream.FlushFinalBlock();

            byte[] encryptedOrDecryptedNumbers = memoryStream.ToArray();

            string encryptedOrDecryptedText = encoding.GetString(encryptedOrDecryptedNumbers);
            return encryptedOrDecryptedText;
        }

        private object ASCIIEncoding()
        {
            throw new NotImplementedException();
        }
    }
}
