
namespace Slaptazodziu_valdymo_sistema.UserControls
{
    partial class DeletePassword
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.showPasswords = new System.Windows.Forms.CheckBox();
            this.allButton = new System.Windows.Forms.Button();
            this.LogName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passwordd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URLXD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M0reInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPasswordBox
            // 
            this.searchPasswordBox.Location = new System.Drawing.Point(114, 60);
            this.searchPasswordBox.Name = "searchPasswordBox";
            this.searchPasswordBox.Size = new System.Drawing.Size(150, 20);
            this.searchPasswordBox.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Search password:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(270, 59);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 20);
            this.searchButton.TabIndex = 53;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "IŠTRINTI SLAPTAŽODĮ";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(246, 226);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 26);
            this.deleteButton.TabIndex = 57;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogName,
            this.Passwordd,
            this.URLXD,
            this.M0reInformation});
            this.dataGridView.Location = new System.Drawing.Point(19, 86);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(555, 134);
            this.dataGridView.TabIndex = 59;
            // 
            // showPasswords
            // 
            this.showPasswords.AutoSize = true;
            this.showPasswords.Location = new System.Drawing.Point(447, 62);
            this.showPasswords.Name = "showPasswords";
            this.showPasswords.Size = new System.Drawing.Size(106, 17);
            this.showPasswords.TabIndex = 60;
            this.showPasswords.Text = "Show passwords";
            this.showPasswords.UseVisualStyleBackColor = true;
            this.showPasswords.CheckedChanged += new System.EventHandler(this.showPasswords_CheckedChanged);
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(351, 59);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(75, 20);
            this.allButton.TabIndex = 61;
            this.allButton.Text = "ALL";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // LogName
            // 
            this.LogName.HeaderText = "Login Name";
            this.LogName.Name = "LogName";
            this.LogName.ReadOnly = true;
            // 
            // Passwordd
            // 
            this.Passwordd.HeaderText = "Password";
            this.Passwordd.Name = "Passwordd";
            this.Passwordd.ReadOnly = true;
            // 
            // URLXD
            // 
            this.URLXD.HeaderText = "URL";
            this.URLXD.Name = "URLXD";
            this.URLXD.ReadOnly = true;
            // 
            // M0reInformation
            // 
            this.M0reInformation.HeaderText = "More information";
            this.M0reInformation.Name = "M0reInformation";
            this.M0reInformation.ReadOnly = true;
            // 
            // DeletePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.showPasswords);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchPasswordBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Name = "DeletePassword";
            this.Size = new System.Drawing.Size(589, 255);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchPasswordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckBox showPasswords;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passwordd;
        private System.Windows.Forms.DataGridViewTextBoxColumn URLXD;
        private System.Windows.Forms.DataGridViewTextBoxColumn M0reInformation;
    }
}
