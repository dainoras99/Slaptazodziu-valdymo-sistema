
namespace Slaptazodziu_valdymo_sistema.UserControls
{
    partial class NewPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginName = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moreInfoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.loginNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(164, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "SUKURTI NAUJĄ SLAPTAŽODĮ";
            // 
            // loginName
            // 
            this.loginName.AutoSize = true;
            this.loginName.Location = new System.Drawing.Point(181, 70);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(68, 13);
            this.loginName.TabIndex = 22;
            this.loginName.Text = "Login name: ";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(255, 105);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(150, 20);
            this.passwordBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "More information: ";
            // 
            // moreInfoBox
            // 
            this.moreInfoBox.Location = new System.Drawing.Point(255, 179);
            this.moreInfoBox.Name = "moreInfoBox";
            this.moreInfoBox.Size = new System.Drawing.Size(150, 20);
            this.moreInfoBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "URL/application: ";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(261, 220);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 30;
            this.createButton.Text = "CREATE";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(255, 141);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(150, 20);
            this.urlBox.TabIndex = 31;
            // 
            // loginNameBox
            // 
            this.loginNameBox.Location = new System.Drawing.Point(255, 67);
            this.loginNameBox.Name = "loginNameBox";
            this.loginNameBox.Size = new System.Drawing.Size(150, 20);
            this.loginNameBox.TabIndex = 32;
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.loginNameBox);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.moreInfoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginName);
            this.Controls.Add(this.label1);
            this.Name = "NewPassword";
            this.Size = new System.Drawing.Size(589, 255);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginName;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox moreInfoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox loginNameBox;
    }
}
