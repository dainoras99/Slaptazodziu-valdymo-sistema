using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slaptazodziu_valdymo_sistema.UserControls
{
    public partial class NewPassword : UserControl
    {
        public NewPassword()
        {
            InitializeComponent();
        }

        private void Validations()
        {
            try
            {
                if (String.IsNullOrWhiteSpace(loginNameBox.Text) || String.IsNullOrWhiteSpace(passwordBox.Text))
                    throw new Exception("You must provide us with full information");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            PasswordHashing passwordHashing = new PasswordHashing();
            FileCreation fileCreation = new FileCreation();
            Validations();
            List<string> info = new List<string>();
            info.Add(loginNameBox.Text);
            info.Add(passwordHashing.
                EncryptingAndDecryptingPasswordWithDES(passwordBox.Text,true));
            if (urlBox.Text != "")
                info.Add(urlBox.Text);
            if (moreInfoBox.Text != "")
                info.Add(moreInfoBox.Text);
            fileCreation.WriteToFile(MainWindow.loggedInUser.fileLocation, info);

            MessageBox.Show("New password is successfully added!");

            loginNameBox.Text = "";
            passwordBox.Text = "";
            urlBox.Text = "";
            moreInfoBox.Text = "";
        }
    }
}
