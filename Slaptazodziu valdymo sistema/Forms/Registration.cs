﻿using System;
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
    public partial class Registration : Form
    {
        public static User loggedInUser;
        public Registration()
        {
            InitializeComponent();
        }

        private void Validations()
        {
            if (String.IsNullOrWhiteSpace(usernameBox.Text) || 
                String.IsNullOrWhiteSpace(passwordBox.Text) ||
                String.IsNullOrWhiteSpace(confirmPasswordBox.Text))
                throw new Exception("You must include all information");
            if (passwordBox.Text != confirmPasswordBox.Text)
                throw new Exception("Your passwords doesn't match");
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                PasswordHashing passwordHashing = new PasswordHashing();
                UsersRepository usersRepository = new UsersRepository();
                Validations();
                User user = new User(usernameBox.Text,
                    passwordHashing.creatingHashedPassword(passwordBox.Text));
                usersRepository.AddNewUserToDB(user);

                loggedInUser = user;

                DialogResult dialog = MessageBox.Show("You signed up successfully!", "OK", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    LoggedIn loggedIn = new LoggedIn();
                    loggedIn.ShowDialog();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    }
}
