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
    public partial class FindPassword : UserControl
    {
        FileCreation fileCreation = new FileCreation();
        PasswordHashing passwordHashing = new PasswordHashing();
        List<string> info = new List<string>();
        public FindPassword()
        {
            InitializeComponent();

            info = (fileCreation.ReadFromFile
                (MainWindow.loggedInUser.fileLocation));

            foreach (string inf in info)
            {
                string[] split = inf.Split(',');
               //split[1] = "*******";
                split[1] = passwordHashing.EncryptingAndDecryptingPasswordWithDES(split[1], false);
                dataGridView1.Rows.Add(split);
            }
            dataGridView1.Columns[1].Visible = false;
        }

        private void showPasswords_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswords.Checked)
            {
                //dataGridView1.Rows.Clear();
                //foreach (string inf in info)
                //{
                //    string[] splitWithPassword = inf.Split(','); 
                //        splitWithPassword[1] = passwordHashing.EncryptingAndDecryptingPasswordWithDES(splitWithPassword[1], false);
                //    dataGridView1.Rows.Add(splitWithPassword);
                //}
                dataGridView1.Columns[1].Visible = true;
            }
            if (!showPasswords.Checked)
            {
                //dataGridView1.Rows.Clear();
                //foreach (string inf in info)
                //{
                //    string[] splitWithoutPassword = inf.Split(',');
                //        splitWithoutPassword[1] = "*******";
                //    dataGridView1.Rows.Add(splitWithoutPassword);
                //}
                dataGridView1.Columns[1].Visible = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<string> passwords = new List<string>();
            foreach (string inf in info)
            {
                string[] splitWithPassword = inf.Split(',');
                splitWithPassword[1] = passwordHashing.EncryptingAndDecryptingPasswordWithDES(splitWithPassword[1], false);
                if (searchPasswordBox.Text == splitWithPassword[1])
                {
                    dataGridView1.Rows.Add(splitWithPassword);
                }
            }
            // *******************************************************************************************************************************************************
            // Cia sustojau, reikia sutvarkyt ,,Show passwords", kai searchina passwrd
            // *******************************************************************************************************************************************************

        }

        private void allButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            info = (fileCreation.ReadFromFile
                (MainWindow.loggedInUser.fileLocation));

            foreach (string inf in info)
            {
                string[] split = inf.Split(',');
                split[1] = passwordHashing.EncryptingAndDecryptingPasswordWithDES(split[1], false);
                dataGridView1.Rows.Add(split);
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            MessageBox.Show("Password is copied!");
        }
    }
}
