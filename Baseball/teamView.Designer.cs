namespace Baseball
{
    partial class teamView
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.teamViewPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(30, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(734, 364);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // teamViewPage
            // 
            this.teamViewPage.AutoSize = true;
            this.teamViewPage.Location = new System.Drawing.Point(699, 32);
            this.teamViewPage.Name = "teamViewPage";
            this.teamViewPage.Size = new System.Drawing.Size(49, 20);
            this.teamViewPage.TabIndex = 1;
            this.teamViewPage.Text = "Team";
            this.teamViewPage.Click += new System.EventHandler(this.label1_Click);
            // 
            // teamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 456);
            this.Controls.Add(this.teamViewPage);
            this.Controls.Add(this.listView1);
            this.Name = "teamView";
            this.Text = "teamView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label teamViewPage;
    }
}