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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            slidepanel.Height = button1.Height;
            slidepanel.Top = button1.Top;

            //show Pages
            adminprofile1.Show();
            mystudent1.Hide();
            addexam1.Hide();
            addsubject1.Hide();
            showexams1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button1.Height;
            slidepanel.Top = button1.Top;
            //show Pages
            adminprofile1.Show();
            mystudent1.Hide();
            addexam1.Hide();
            addsubject1.Hide();
            showexams1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button2.Height;
            slidepanel.Top = button2.Top;
            //show Pages
            mystudent1.Show();
            adminprofile1.Hide();
            addexam1.Hide();
            addsubject1.Hide();
            showexams1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button3.Height;
            slidepanel.Top = button3.Top;

            //show Pages
            addexam1.Show();
            mystudent1.Hide();
            adminprofile1.Hide();
            addsubject1.Hide();
            showexams1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button4.Height;
            slidepanel.Top = button4.Top;
            //show Pages
            showexams1.Show();
            addexam1.Hide();
            mystudent1.Hide();
            adminprofile1.Hide();
            addsubject1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button5.Height;
            slidepanel.Top = button5.Top;
            //show Pages
            addsubject1.Show();
            addexam1.Hide();
            mystudent1.Hide();
            adminprofile1.Hide();
            showexams1.Hide();
        }
    }
}
