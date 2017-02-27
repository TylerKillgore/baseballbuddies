namespace Baseball
{
    partial class loginPage
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
            this.Login = new System.Windows.Forms.Button();
            this.usernameString = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.passwordString = new System.Windows.Forms.TextBox();
            this.createNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(364, 188);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(142, 43);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameString
            // 
            this.usernameString.Location = new System.Drawing.Point(181, 63);
            this.usernameString.Name = "usernameString";
            this.usernameString.Size = new System.Drawing.Size(325, 26);
            this.usernameString.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(73, 63);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(73, 130);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // passwordString
            // 
            this.passwordString.Location = new System.Drawing.Point(181, 127);
            this.passwordString.Name = "passwordString";
            this.passwordString.Size = new System.Drawing.Size(325, 26);
            this.passwordString.TabIndex = 4;
            // 
            // createNew
            // 
            this.createNew.Location = new System.Drawing.Point(181, 188);
            this.createNew.Name = "createNew";
            this.createNew.Size = new System.Drawing.Size(142, 43);
            this.createNew.TabIndex = 5;
            this.createNew.Text = "Create New";
            this.createNew.UseVisualStyleBackColor = true;
            this.createNew.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 272);
            this.Controls.Add(this.createNew);
            this.Controls.Add(this.passwordString);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.usernameString);
            this.Controls.Add(this.Login);
            this.Name = "loginPage";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox usernameString;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox passwordString;
        private System.Windows.Forms.Button createNew;
    }
}

