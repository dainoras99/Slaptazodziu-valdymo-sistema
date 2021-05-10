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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int currentRow = dataGridView.CurrentCell.RowIndex;

            //loginNameBox.Text = dataGridView.Rows[dataGridView.SelectedRows[currentRow].Index].Cells[1].Value.ToString();
            // passwordBox.Text = dataGridView.Rows[dataGridView.SelectedRows[currentRow].Index].Cells[2].Value.ToString();
            //urlBox.Text = dataGridView.Rows[dataGridView.SelectedRows[currentRow].Index].Cells[3].Value.ToString();
            //moreInfoBox.Text = dataGridView.Rows[dataGridView.SelectedRows[currentRow].Index].Cells[4].Value.ToString();
            try
            {
                //if (dataGridView.SelectedCells.Count > 1)
                //    throw new Exception("You can't choose two or more cells");
                //if (dataGridView.SelectedCells.Count > 0)
                //{
                //    loginNameBox.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                //    passwordBox.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                //    urlBox.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                //    moreInfoBox.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                //}
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[index];
                loginNameBox.Text = selectedRow.Cells[0].Value.ToString();
                passwordBox.Text = selectedRow.Cells[1].Value.ToString();
                urlBox.Text = selectedRow.Cells[2].Value.ToString();
                moreInfoBox.Text = selectedRow.Cells[3].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
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

        private void selectButton_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // CIA EXCEPTION REIK KAD PIRMOS EILUTES NELIESTU KRC userioxs Xd
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[index];
                loginNameBox.Text = selectedRow.Cells[0].Value.ToString();
                passwordBox.Text = selectedRow.Cells[1].Value.ToString();
                urlBox.Text = selectedRow.Cells[2].Value.ToString();
                moreInfoBox.Text = selectedRow.Cells[3].Value.ToString();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
    }
}
