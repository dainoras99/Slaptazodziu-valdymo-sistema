using Slaptazodziu_valdymo_sistema.UserControls;
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
    public partial class LoggedIn : Form
    {
        public LoggedIn()
        {
            InitializeComponent();
        }

        private void newPassword_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            NewPassword newPassword = new NewPassword();
            flowLayoutPanel.Controls.Add(newPassword);
        }

        private void updatePassword_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            UpdatePassword updatePassword = new UpdatePassword();
            flowLayoutPanel.Controls.Add(updatePassword);
        }

        private void findPassword_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            FindPassword findPassword = new FindPassword();
            flowLayoutPanel.Controls.Add(findPassword);
        }

        private void deletePassword_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            DeletePassword deletePassword = new DeletePassword();
            flowLayoutPanel.Controls.Add(deletePassword);
        }
    }
}
