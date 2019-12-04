using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace project
{
    public partial class signup : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-BKME0BG; Initial Catalog = ; Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader dr;
        public signup()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
    }
}
