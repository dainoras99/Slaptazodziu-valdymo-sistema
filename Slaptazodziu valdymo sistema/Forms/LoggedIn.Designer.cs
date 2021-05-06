
namespace Slaptazodziu_valdymo_sistema.Forms
{
    partial class LoggedIn
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.Button();
            this.updatePassword = new System.Windows.Forms.Button();
            this.findPassword = new System.Windows.Forms.Button();
            this.deletePassword = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(145, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "SLAPTAŽODŽIŲ VALDYMO SISTEMA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(14, 115);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(129, 23);
            this.newPassword.TabIndex = 24;
            this.newPassword.Text = "New password";
            this.newPassword.UseVisualStyleBackColor = true;
            this.newPassword.Click += new System.EventHandler(this.newPassword_Click);
            // 
            // updatePassword
            // 
            this.updatePassword.Location = new System.Drawing.Point(173, 115);
            this.updatePassword.Name = "updatePassword";
            this.updatePassword.Size = new System.Drawing.Size(123, 23);
            this.updatePassword.TabIndex = 25;
            this.updatePassword.Text = "Update password";
            this.updatePassword.UseVisualStyleBackColor = true;
            this.updatePassword.Click += new System.EventHandler(this.updatePassword_Click);
            // 
            // findPassword
            // 
            this.findPassword.Location = new System.Drawing.Point(330, 115);
            this.findPassword.Name = "findPassword";
            this.findPassword.Size = new System.Drawing.Size(119, 23);
            this.findPassword.TabIndex = 26;
            this.findPassword.Text = "Find password";
            this.findPassword.UseVisualStyleBackColor = true;
            this.findPassword.Click += new System.EventHandler(this.findPassword_Click);
            // 
            // deletePassword
            // 
            this.deletePassword.Location = new System.Drawing.Point(482, 115);
            this.deletePassword.Name = "deletePassword";
            this.deletePassword.Size = new System.Drawing.Size(123, 23);
            this.deletePassword.TabIndex = 27;
            this.deletePassword.Text = "Delete password";
            this.deletePassword.UseVisualStyleBackColor = true;
            this.deletePassword.Click += new System.EventHandler(this.deletePassword_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(16, 160);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(589, 255);
            this.flowLayoutPanel.TabIndex = 28;
            // 
            // LoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(617, 427);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.deletePassword);
            this.Controls.Add(this.findPassword);
            this.Controls.Add(this.updatePassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "LoggedIn";
            this.Text = "LoggedIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button newPassword;
        private System.Windows.Forms.Button updatePassword;
        private System.Windows.Forms.Button findPassword;
        private System.Windows.Forms.Button deletePassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}