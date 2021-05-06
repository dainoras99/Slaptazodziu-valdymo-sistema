using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slaptazodziu_valdymo_sistema.Forms
{
    public partial class Login : Form
    {
        public static User loggedInUser;
        public Login()
        {
            InitializeComponent();
        }

        private void Validations()
        {
            if (String.IsNullOrWhiteSpace(usernameBox.Text) ||
                String.IsNullOrWhiteSpace(passwordBox.Text))
                throw new Exception("You must include all information");

        }
        private void signInButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validations();
                PasswordHashing passwordHashing = new PasswordHashing();
                UsersRepository usersRepository = new UsersRepository();

                if (usersRepository.UserLogin(usernameBox.Text, passwordBox.Text) != null)
                {
                    User user = usersRepository.UserLogin(usernameBox.Text, passwordBox.Text);
                    if (passwordHashing.comparePassword(passwordBox.Text, user.password) == true)
                    {
                        DialogResult dialog = MessageBox.Show("You signed in successfully!", "OK", MessageBoxButtons.OK);
                        if (dialog == DialogResult.OK)
                        {
                            LoggedIn loggedIn = new LoggedIn();
                            loggedIn.ShowDialog();
                        }
                    }
                    else
                        throw new Exception("Incorrect password! Please try again.");

                }
                else 
                    throw new Exception("User not found");
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
