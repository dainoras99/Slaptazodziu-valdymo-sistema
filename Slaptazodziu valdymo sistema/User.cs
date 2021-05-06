using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slaptazodziu_valdymo_sistema
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }

        public string fileLocation { get; set; }

        public User(string username, string password, string fileLocation)
        {
            this.username = username;
            this.password = password;
            this.fileLocation = fileLocation;
        }
    }
}
