namespace Baseball
{
    partial class createTeam
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
            this.submitPlayerInformation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.playerFirstNameInput = new System.Windows.Forms.Label();
            this.playerLastNameInput = new System.Windows.Forms.Label();
            this.playerPositionInput = new System.Windows.Forms.Label();
            this.playerNumberInput = new System.Windows.Forms.Label();
            this.playerTeamNameInput = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitPlayerInformation
            // 
            this.submitPlayerInformation.Location = new System.Drawing.Point(328, 174);
            this.submitPlayerInformation.Name = "submitPlayerInformation";
            this.submitPlayerInformation.Size = new System.Drawing.Size(83, 36);
            this.submitPlayerInformation.TabIndex = 0;
            this.submitPlayerInformation.Text = "Submit";
            this.submitPlayerInformation.UseVisualStyleBackColor = true;
            this.submitPlayerInformation.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 26);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 26);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(79, 26);
            this.textBox4.TabIndex = 5;
            // 
            // playerFirstNameInput
            // 
            this.playerFirstNameInput.AutoSize = true;
            this.playerFirstNameInput.Location = new System.Drawing.Point(46, 73);
            this.playerFirstNameInput.Name = "playerFirstNameInput";
            this.playerFirstNameInput.Size = new System.Drawing.Size(86, 20);
            this.playerFirstNameInput.TabIndex = 6;
            this.playerFirstNameInput.Text = "First Name";
            // 
            // playerLastNameInput
            // 
            this.playerLastNameInput.AutoSize = true;
            this.playerLastNameInput.Location = new System.Drawing.Point(46, 108);
            this.playerLastNameInput.Name = "playerLastNameInput";
            this.playerLastNameInput.Size = new System.Drawing.Size(86, 20);
            this.playerLastNameInput.TabIndex = 7;
            this.playerLastNameInput.Text = "Last Name";
            // 
            // playerPositionInput
            // 
            this.playerPositionInput.AutoSize = true;
            this.playerPositionInput.Location = new System.Drawing.Point(70, 144);
            this.playerPositionInput.Name = "playerPositionInput";
            this.playerPositionInput.Size = new System.Drawing.Size(62, 20);
            this.playerPositionInput.TabIndex = 8;
            this.playerPositionInput.Text = "Postion";
            // 
            // playerNumberInput
            // 
            this.playerNumberInput.AutoSize = true;
            this.playerNumberInput.Location = new System.Drawing.Point(70, 190);
            this.playerNumberInput.Name = "playerNumberInput";
            this.playerNumberInput.Size = new System.Drawing.Size(65, 20);
            this.playerNumberInput.TabIndex = 9;
            this.playerNumberInput.Text = "Number";
            // 
            // playerTeamNameInput
            // 
            this.playerTeamNameInput.AutoSize = true;
            this.playerTeamNameInput.Location = new System.Drawing.Point(46, 41);
            this.playerTeamNameInput.Name = "playerTeamNameInput";
            this.playerTeamNameInput.Size = new System.Drawing.Size(49, 20);
            this.playerTeamNameInput.TabIndex = 11;
            this.playerTeamNameInput.Text = "Team";
            this.playerTeamNameInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 38);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(306, 26);
            this.textBox5.TabIndex = 10;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // createTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 260);
            this.Controls.Add(this.playerTeamNameInput);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.playerNumberInput);
            this.Controls.Add(this.playerPositionInput);
            this.Controls.Add(this.playerLastNameInput);
            this.Controls.Add(this.playerFirstNameInput);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.submitPlayerInformation);
            this.Name = "createTeam";
            this.Text = "Create Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitPlayerInformation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label playerFirstNameInput;
        private System.Windows.Forms.Label playerLastNameInput;
        private System.Windows.Forms.Label playerPositionInput;
        private System.Windows.Forms.Label playerNumberInput;
        private System.Windows.Forms.Label playerTeamNameInput;
        private System.Windows.Forms.TextBox textBox5;
    }
}