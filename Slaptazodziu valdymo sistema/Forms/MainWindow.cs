using Slaptazodziu_valdymo_sistema.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slaptazodziu_valdymo_sistema
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.IsMdiContainer = true;
            login.MdiParent = this;
            login.Show();
            loginButton.Visible = false;
            registerButton.Visible = false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Registration register = new Registration();
            this.IsMdiContainer = true;
            register.MdiParent = this;
            register.Show();
            loginButton.Visible = false;
            registerButton.Visible = false;
        }
    }
}
