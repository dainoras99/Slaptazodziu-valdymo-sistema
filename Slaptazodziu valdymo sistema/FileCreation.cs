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

            if (fileContent.Any(x => x.Contains("\n")))
                fileContent[1] = fileContent[1].Replace("\n", "NaujasLainasNNN");
            if (fileContent.Any(x => x.Contains("\r")))
                fileContent[1] = fileContent[1].Replace("\r", "NaujasLainasRRR");

            foreach (string filePiece in fileContent)
            {
                i++;
                if (i == fileContent.Count)
                    File.AppendAllText(file, filePiece + "PaBaiGaKoNeCxDxD!" + Environment.NewLine);
                else
                    File.AppendAllText(file, filePiece + "nEpABaiGaIrNeKoNec!!jaXociuumirat:))");
            }
        }
        public List<string> ReadFromFile(string file)
        {
            //string temp = "";
            string[] lines = File.ReadAllLines(file);
            List<string> info = new List<string>();
            List<string> fixedInfo = new List<string>();
            foreach (string line in lines)
                    info.Add(line);

            foreach (string element in info)
                fixedInfo.Add(element.Remove(element.Length - 17));

            return fixedInfo;
        }
        public void UpdateFile(string file, string username, string password, string url, string moreInfo)
        {
            if (password.Contains("\n"))
                password = password.Replace("\n", "NaujasLainasNNN");
            if (password.Contains("\r"))
                password = password.Replace("\r", "NaujasLainasRRR");

            int i = -1;
            string[] lines = File.ReadAllLines(file);
            string[] temp = lines;
            foreach (string line in temp)
            {
                i++;
                string stringSplit = "nEpABaiGaIrNeKoNec!!jaXociuumirat:))";
                string[] split = line.Split(new string[] { stringSplit }, StringSplitOptions.None);
                split[3] = split[3].Remove(split[3].Length - 17);
                if (username.Equals(split[0]) && url.Equals(split[2]) && moreInfo.Equals(split[3]))
                {
                    lines[i] = username + "nEpABaiGaIrNeKoNec!!jaXociuumirat:))"
                        + password + "nEpABaiGaIrNeKoNec!!jaXociuumirat:))" +
                        url + "nEpABaiGaIrNeKoNec!!jaXociuumirat:))" +
                        moreInfo + "PaBaiGaKoNeCxDxD!";
                }
            }
            File.WriteAllLines(file, lines);
        }
        public void DeleteRecordFromFile(string file, string username, string password, string url, string moreInfo)
        {
            if (password.Contains("\n"))
                password = password.Replace("\n", "NaujasLainasNNN");
            if (password.Contains("\r"))
                password = password.Replace("\r", "NaujasLainasRRR");
            int i = -1;
            string[] lines = File.ReadAllLines(file);
            string[] temp = lines;
            List<string> removeList = new List<string>(lines);
            foreach (string line in temp)
            {
                i++;
                string stringSplit = "nEpABaiGaIrNeKoNec!!jaXociuumirat:))";
                string[] split = line.Split(new string[] { stringSplit }, StringSplitOptions.None);
                split[3] = split[3].Remove(split[3].Length - 17);
                if (username.Equals(split[0]) && password.Equals(split[1]) && url.Equals(split[2]) && moreInfo.Equals(split[3]))
                {
                    removeList.RemoveAt(i);
                }
            }
            File.WriteAllLines(file, removeList.ToArray());
        }
    }
}
