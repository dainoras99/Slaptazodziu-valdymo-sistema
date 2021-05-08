
namespace Slaptazodziu_valdymo_sistema.UserControls
{
    partial class FindPassword
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
            this.searchPasswordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoreInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showPasswords = new System.Windows.Forms.CheckBox();
            this.allButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPasswordBox
            // 
            this.searchPasswordBox.Location = new System.Drawing.Point(110, 33);
            this.searchPasswordBox.Name = "searchPasswordBox";
            this.searchPasswordBox.Size = new System.Drawing.Size(150, 20);
            this.searchPasswordBox.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Search password:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(284, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 20);
            this.searchButton.TabIndex = 47;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(205, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "IEŠKOTI SLAPTAŽODŽIO";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(511, 92);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 160);
            this.copyButton.TabIndex = 52;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginName,
            this.Password,
            this.URL,
            this.MoreInfo});
            this.dataGridView1.Location = new System.Drawing.Point(3, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 160);
            this.dataGridView1.TabIndex = 55;
            // 
            // LoginName
            // 
            this.LoginName.HeaderText = "Login Name";
            this.LoginName.Name = "LoginName";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            // 
            // MoreInfo
            // 
            this.MoreInfo.HeaderText = "More Information";
            this.MoreInfo.Name = "MoreInfo";
            // 
            // showPasswords
            // 
            this.showPasswords.AutoSize = true;
            this.showPasswords.Location = new System.Drawing.Point(139, 69);
            this.showPasswords.Name = "showPasswords";
            this.showPasswords.Size = new System.Drawing.Size(106, 17);
            this.showPasswords.TabIndex = 56;
            this.showPasswords.Text = "Show passwords";
            this.showPasswords.UseVisualStyleBackColor = true;
            this.showPasswords.CheckedChanged += new System.EventHandler(this.showPasswords_CheckedChanged);
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(365, 33);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(75, 20);
            this.allButton.TabIndex = 57;
            this.allButton.Text = "ALL";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // FindPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.showPasswords);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.searchPasswordBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Name = "FindPassword";
            this.Size = new System.Drawing.Size(589, 255);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchPasswordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoreInfo;
        private System.Windows.Forms.CheckBox showPasswords;
        private System.Windows.Forms.Button allButton;
    }
}
