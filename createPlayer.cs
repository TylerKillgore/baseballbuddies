using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baseball
{
    public partial class createPlayer : Form
    {
        public createPlayer()
        {
            var query = "SELECT TeamName FROM Teams";
            InitializeComponent();
            FillData(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
