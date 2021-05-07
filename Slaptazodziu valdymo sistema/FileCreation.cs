using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slaptazodziu_valdymo_sistema
{
    class FileCreation
    {
        private string mainPath = @"D:\KOLEGIJOS MEDZIAGA\INFORMACIJOS SAUGUMAS\Slaptazodziu valdymo sistema\files\";
        private string password = "dainorasdainorasdainorasdainoras";
        private string IVkey = "1234567890ABCDEF";

        public string createFile(string username)
        {
            string filePath = mainPath + username + ".txt";
            using (File.Create(filePath)) {};
            return filePath;
        }
        public string EncryptWithAES(string file)
        {
            try
            {
                byte[] plainContent = File.ReadAllBytes(file);
                using (var AES = new RijndaelManaged())
                {
                    AES.IV = Encoding.UTF8.GetBytes(IVkey);
                    AES.Key = Encoding.UTF8.GetBytes(password);
                    AES.Mode = CipherMode.CBC;
                    AES.Padding = PaddingMode.PKCS7;

                    using (var memStream = new MemoryStream())
                    {
                        CryptoStream cryptoStream = new CryptoStream(memStream, AES.CreateEncryptor(), CryptoStreamMode.Write);

                        cryptoStream.Write(plainContent, 0, plainContent.Length);
                        cryptoStream.FlushFinalBlock();
                        File.WriteAllBytes(file, memStream.ToArray());

                        string addedExtension = file + ".aes";
                        File.Move(file, addedExtension);

                        Console.WriteLine("Encrypted succesfully" + file);

                        return addedExtension;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return null;
        }
        public string DecryptWithAES(string file)
        {
            try
            {
                byte[] plainContent = File.ReadAllBytes(file);
                using (var AES = new RijndaelManaged())
                {
                    AES.IV = Encoding.UTF8.GetBytes(IVkey);
                    AES.Key = Encoding.UTF8.GetBytes(password);
                    AES.Mode = CipherMode.CBC;
                    AES.Padding = PaddingMode.PKCS7;

                    using (var memStream = new MemoryStream())
                    {
                        CryptoStream cryptoStream = new CryptoStream(memStream, AES.CreateDecryptor(), CryptoStreamMode.Write);

                        cryptoStream.Write(plainContent, 0, plainContent.Length);
                        cryptoStream.FlushFinalBlock();
                        File.WriteAllBytes(file, memStream.ToArray());

                        string removeExtension = Path.ChangeExtension(file, null);
                        File.Move(file, removeExtension);

                        Console.WriteLine("Decrypted succesfully" + file);
                        return removeExtension;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return null;
        }
        public void WriteToFile(string file, List<string> fileContent)
        {
            int i = 0;
            foreach (string filePiece in fileContent)
            {
                i++;
                if (i == fileContent.Count)
                    File.AppendAllText(file, filePiece + Environment.NewLine);
                else
                    File.AppendAllText(file, filePiece + ",");
            }
        }
    }
}
