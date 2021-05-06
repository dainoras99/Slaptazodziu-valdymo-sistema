using Scrypt;
using System;
using System.Collections.Generic;
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
    }
}
