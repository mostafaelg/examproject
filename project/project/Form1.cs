using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            signup1.Hide();
            bunifuThinButton21.Hide();
            login1.Show();
            bunifuThinButton22.Show();

            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            login1.Hide();
            bunifuThinButton22.Hide();
            signup1.Show();
            bunifuThinButton21.Show();
            
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            signup1.Hide();
            bunifuThinButton21.Hide();
            login1.Show();
            bunifuThinButton22.Show();
        }

    }
}
