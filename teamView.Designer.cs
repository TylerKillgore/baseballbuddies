using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

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

        void FillData(string query)
        {
            // 1
            // Open connection
            using (SqlConnection c = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BBallBuddies;Integrated Security=True"))
            {
                c.Open();
                // 2
                // Create new DataAdapter
                using (SqlDataAdapter a = new SqlDataAdapter(query, c))
                {
                    // 3
                    // Use DataAdapter to fill DataTable
                    DataTable t = new DataTable();
                    a.Fill(t);

                    // 4
                    // Render data onto the screen
                    dataGridView1.DataSource = t; // <-- From your designer
                }
            }
        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.teamViewPage = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // teamViewPage
            // 
            this.teamViewPage.AutoSize = true;
            this.teamViewPage.Location = new System.Drawing.Point(466, 21);
            this.teamViewPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamViewPage.Name = "teamViewPage";
            this.teamViewPage.Size = new System.Drawing.Size(34, 13);
            this.teamViewPage.TabIndex = 1;
            this.teamViewPage.Text = "Team";
            this.teamViewPage.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 256);
            this.dataGridView1.TabIndex = 2;
            // 
            // teamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 296);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.teamViewPage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "teamView";
            this.Text = "teamView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label teamViewPage;
        private DataGridView dataGridView1;
    }
}