using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baseball
{
    public partial class teamView : Form
    {
        public teamView()
        {
            var query = "SELECT fName AS 'First Name', lName AS 'Last Name', Position, Email AS 'Email Address', Phone AS 'Phone Number' FROM Players WHERE TeamID = 1";
            InitializeComponent();
            FillData(query);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
