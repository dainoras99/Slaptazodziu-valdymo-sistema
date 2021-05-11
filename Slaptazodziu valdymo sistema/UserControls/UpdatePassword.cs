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
    public partial class UpdatePassword : UserControl
    {
        FileCreation fileCreation = new FileCreation();
        PasswordHashing passwordHashing = new PasswordHashing();
        List<string> info = new List<string>();
        public UpdatePassword()
        {
            InitializeComponent();
            info = (fileCreation.ReadFromFile
               (MainWindow.loggedInUser.fileLocation));

            foreach (string inf in info)
            {
                string stringSplit = "nEpABaiGaIrNeKoNec!!jaXociuumirat:))";

                string[] split = inf.Split(new string[] { stringSplit }, StringSplitOptions.None);

                if (split[1].Contains("NaujasLainasRRR"))
                    split[1] = split[1].Replace("NaujasLainasRRR", "\r");
                if (split[1].Contains("NaujasLainasNNN"))
                    split[1] = split[1].Replace("NaujasLainasNNN", "\n");
                split[1] = passwordHashing.EncryptingAndDecryptingPasswordWithDES(split[1], false);
                dataGridView.Rows.Add(split);
            }
            dataGridView.Columns[1].Visible = false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (loginName.Text != null ||
                    passwordBox.Text != null ||
                    urlBox.Text != null ||
                    passwordBox.Text != null)
                {
                    string password = passwordHashing.EncryptingAndDecryptingPasswordWithDES(passwordBox.Text, true);
                    fileCreation.UpdateFile(MainWindow.loggedInUser.fileLocation,
                        loginNameBox.Text, password, urlBox.Text, moreInfoBox.Text);
                    MessageBox.Show("This password is updated!");
                    if (dataGridView.CurrentCell != null)
                    {
                        int row = dataGridView.CurrentCell.RowIndex;
                        dataGridView.Rows[row].Cells[1].Value = passwordBox.Text;
                    }
                    if (dataGridView.CurrentRow != null)
                    {
                        dataGridView.CurrentRow.Cells[1].Value = passwordBox.Text;
                    }
                    loginName.Text = "";
                    passwordBox.Text = "";
                    urlBox.Text = "";
                    moreInfoBox.Text = "";
                }
                else
                    throw new Exception("You must provide us with full information!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void showPasswords_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswords.Checked)
                dataGridView.Columns[1].Visible = true;
            if (!showPasswords.Checked)
                dataGridView.Columns[1].Visible = false;
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            info = (fileCreation.ReadFromFile
                (MainWindow.loggedInUser.fileLocation));

            foreach (string inf in info)
            {
                string stringSplit = "nEpABaiGaIrNeKoNec!!jaXociuumirat:))";

                string[] split = inf.Split(new string[] { stringSplit }, StringSplitOptions.None);

                if (split[1].Contains("NaujasLainasRRR"))
                    split[1] = split[1].Replace("NaujasLainasRRR", "\r");
                if (split[1].Contains("NaujasLainasNNN"))
                    split[1] = split[1].Replace("NaujasLainasNNN", "\n");
                split[1] = passwordHashing.EncryptingAndDecryptingPasswordWithDES(split[1], false);
                dataGridView.Rows.Add(split);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            List<string> passwords = new List<string>();
            foreach (string inf in info)
            {
                string stringSplit = "nEpABaiGaIrNeKoNec!!jaXociuumirat:))";

                string[] splitWithPassword = inf.Split(new string[] { stringSplit }, StringSplitOptions.None);

                if (splitWithPassword[1].Contains("NaujasLainasRRR"))
                    splitWithPassword[1] = splitWithPassword[1].Replace("NaujasLainasRRR", "\r");
                if (splitWithPassword[1].Contains("NaujasLainasNNN"))
                    splitWithPassword[1] = splitWithPassword[1].Replace("NaujasLainasNNN", "\n");
                splitWithPassword[1] = passwordHashing.EncryptingAndDecryptingPasswordWithDES(splitWithPassword[1], false);
                if (searchPasswordBox.Text == splitWithPassword[1])
                {
                    dataGridView.Rows.Add(splitWithPassword);
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[index];
                if (selectedRow.Cells[0].Value != null ||
                    selectedRow.Cells[1].Value != null ||
                    selectedRow.Cells[2].Value != null ||
                    selectedRow.Cells[3].Value != null)
                {
                    loginNameBox.Text = selectedRow.Cells[0].Value.ToString();
                    urlBox.Text = selectedRow.Cells[2].Value.ToString();
                    moreInfoBox.Text = selectedRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            GeneratePassword generatePassword = new GeneratePassword();
            passwordBox.Text = generatePassword.GenerateToken(20);
        }
    }
}
