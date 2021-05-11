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
    public partial class DeletePassword : UserControl
    {
        FileCreation fileCreation = new FileCreation();
        PasswordHashing passwordHashing = new PasswordHashing();
        List<string> info = new List<string>();
        public DeletePassword()
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentCell != null)
                {
                    string username = "";
                    string password = "";
                    string url = "";
                    string moreInfo = "";
                    int row = dataGridView.CurrentCell.RowIndex;
                    username = dataGridView.Rows[row].Cells[0].Value.ToString();
                    password = passwordHashing.EncryptingAndDecryptingPasswordWithDES(dataGridView.Rows[row].Cells[1].Value.ToString(), true);
                    url = dataGridView.Rows[row].Cells[2].Value.ToString();
                    moreInfo = dataGridView.Rows[row].Cells[3].Value.ToString();
                    Console.WriteLine(username + password + url + moreInfo);
                    fileCreation.DeleteRecordFromFile(MainWindow.loggedInUser.fileLocation,
                        username, password, url, moreInfo);
                    MessageBox.Show("Successfully deleted this record!");
                }
                else
                    throw new Exception("You have to choose a password");
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

        private void showPasswords_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswords.Checked)
                dataGridView.Columns[1].Visible = true;
            if (!showPasswords.Checked)
                dataGridView.Columns[1].Visible = false;
        }
    }
}
