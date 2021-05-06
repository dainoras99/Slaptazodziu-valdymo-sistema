using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slaptazodziu_valdymo_sistema;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.IO;
using System.Diagnostics;

namespace Slaptazodziu_valdymo_sistema
{
    class UsersRepository
    {
        private SqlConnection connection;

        public UsersRepository()
        {
            connection = new SqlConnection(@"Server=.;Database=PasswordSystem;Integrated Security=true;");
        }

        public void AddNewUserToDB(User user)
        {
            try
            {
                string sql = "insert into Users(username, password, fileLocation) " +
                    "values (@username, @password, @fileLocation)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@fileLocation", user.fileLocation);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public User UserLogin(string username, string password)
        {
            try
            {
                string sql = "select username, password, fileLocation from Users " +
                        "where username=@username";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string usrname = reader["username"].ToString();
                        string passrord = reader["password"].ToString();
                        string filrLocation = reader["fileLocation"].ToString();
                        connection.Close();
                        return new User(usrname, passrord, filrLocation);
                    }
                }
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            return null;
        }
    }
}
