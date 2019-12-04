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
    public partial class login : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-BKME0BG; Initial Catalog = ; Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader dr;
        public login()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            student s = new student();
            Form1 f = new Form1();
            f.Hide();
            s.ShowDialog();
            admin ad = new admin();
            ad.ShowDialog();

        }
    }
}
