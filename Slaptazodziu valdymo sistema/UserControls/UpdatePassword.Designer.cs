
namespace Slaptazodziu_valdymo_sistema.UserControls
{
    partial class UpdatePassword
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginNameBox = new System.Windows.Forms.TextBox();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.moreInfoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPasswordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Usernam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passwrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoreInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showPasswords = new System.Windows.Forms.CheckBox();
            this.allButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loginNameBox
            // 
            this.loginNameBox.Location = new System.Drawing.Point(107, 89);
            this.loginNameBox.Name = "loginNameBox";
            this.loginNameBox.ReadOnly = true;
            this.loginNameBox.Size = new System.Drawing.Size(150, 20);
            this.loginNameBox.TabIndex = 42;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(107, 172);
            this.urlBox.Name = "urlBox";
            this.urlBox.ReadOnly = true;
            this.urlBox.Size = new System.Drawing.Size(150, 20);
            this.urlBox.TabIndex = 41;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(95, 229);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 40;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "More information: ";
            // 
            // moreInfoBox
            // 
            this.moreInfoBox.Location = new System.Drawing.Point(107, 198);
            this.moreInfoBox.Name = "moreInfoBox";
            this.moreInfoBox.ReadOnly = true;
            this.moreInfoBox.Size = new System.Drawing.Size(150, 20);
            this.moreInfoBox.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "URL/application: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Password:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(107, 124);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(150, 20);
            this.passwordBox.TabIndex = 35;
            // 
            // loginName
            // 
            this.loginName.AutoSize = true;
            this.loginName.Location = new System.Drawing.Point(33, 92);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(68, 13);
            this.loginName.TabIndex = 34;
            this.loginName.Text = "Login name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(204, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "ATNAUJINTI SLAPTAŽODĮ";
            // 
            // searchPasswordBox
            // 
            this.searchPasswordBox.Location = new System.Drawing.Point(112, 40);
            this.searchPasswordBox.Name = "searchPasswordBox";
            this.searchPasswordBox.Size = new System.Drawing.Size(150, 20);
            this.searchPasswordBox.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Search password:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(415, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 20);
            this.searchButton.TabIndex = 48;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usernam,
            this.Passwrd,
            this.Url,
            this.MoreInformation});
            this.dataGridView.Location = new System.Drawing.Point(263, 40);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(323, 212);
            this.dataGridView.TabIndex = 49;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Usernam
            // 
            this.Usernam.HeaderText = "Login Name";
            this.Usernam.Name = "Usernam";
            this.Usernam.ReadOnly = true;
            // 
            // Passwrd
            // 
            this.Passwrd.HeaderText = "Password";
            this.Passwrd.Name = "Passwrd";
            this.Passwrd.ReadOnly = true;
            // 
            // Url
            // 
            this.Url.HeaderText = "URL";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            // 
            // MoreInformation
            // 
            this.MoreInformation.HeaderText = "More Information";
            this.MoreInformation.Name = "MoreInformation";
            this.MoreInformation.ReadOnly = true;
            // 
            // showPasswords
            // 
            this.showPasswords.AutoSize = true;
            this.showPasswords.Location = new System.Drawing.Point(112, 66);
            this.showPasswords.Name = "showPasswords";
            this.showPasswords.Size = new System.Drawing.Size(106, 17);
            this.showPasswords.TabIndex = 57;
            this.showPasswords.Text = "Show passwords";
            this.showPasswords.UseVisualStyleBackColor = true;
            this.showPasswords.CheckedChanged += new System.EventHandler(this.showPasswords_CheckedChanged);
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(496, 6);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(75, 20);
            this.allButton.TabIndex = 58;
            this.allButton.Text = "ALL";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(143, 146);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 20);
            this.generateButton.TabIndex = 59;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.showPasswords);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchPasswordBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loginNameBox);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.moreInfoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginName);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePassword";
            this.Size = new System.Drawing.Size(589, 255);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginNameBox;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox moreInfoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label loginName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchPasswordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usernam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passwrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoreInformation;
        private System.Windows.Forms.CheckBox showPasswords;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button generateButton;
    }
}
