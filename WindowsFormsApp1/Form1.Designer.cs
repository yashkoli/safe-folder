
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.welcome = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.logintxtusername = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.logintxtpassword = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.welcome.Location = new System.Drawing.Point(22, 90);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(241, 29);
            this.welcome.TabIndex = 10;
            this.welcome.Text = "Welcome to SF";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.username.Location = new System.Drawing.Point(347, 183);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(83, 21);
            this.username.TabIndex = 12;
            this.username.Text = "Username";
            // 
            // logintxtusername
            // 
            this.logintxtusername.BackColor = System.Drawing.Color.NavajoWhite;
            this.logintxtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logintxtusername.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintxtusername.Location = new System.Drawing.Point(351, 216);
            this.logintxtusername.Name = "logintxtusername";
            this.logintxtusername.Size = new System.Drawing.Size(220, 23);
            this.logintxtusername.TabIndex = 13;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.password.Location = new System.Drawing.Point(352, 264);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(78, 21);
            this.password.TabIndex = 14;
            this.password.Text = "Password";
            // 
            // logintxtpassword
            // 
            this.logintxtpassword.BackColor = System.Drawing.Color.NavajoWhite;
            this.logintxtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logintxtpassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintxtpassword.Location = new System.Drawing.Point(356, 302);
            this.logintxtpassword.Name = "logintxtpassword";
            this.logintxtpassword.PasswordChar = '#';
            this.logintxtpassword.Size = new System.Drawing.Size(220, 23);
            this.logintxtpassword.TabIndex = 15;
            // 
            // loginbutton
            // 
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(356, 369);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(220, 35);
            this.loginbutton.TabIndex = 16;
            this.loginbutton.Text = " LOG IN";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1146, 567);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.logintxtpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.logintxtusername);
            this.Controls.Add(this.username);
            this.Controls.Add(this.welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox logintxtusername;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox logintxtpassword;
        private System.Windows.Forms.Button loginbutton;
    }
}