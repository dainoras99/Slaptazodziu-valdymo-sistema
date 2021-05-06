using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slaptazodziu_valdymo_sistema
{
    class FileCreation
    {
        private string mainPath = @"D:\KOLEGIJOS MEDZIAGA\INFORMACIJOS SAUGUMAS\Slaptazodziu valdymo sistema\files\";

        public string createFile(string username)
        {
            string filePath = mainPath + username + ".txt";
            File.Create(filePath);
            return filePath;
        }
    }
}
