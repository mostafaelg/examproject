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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void student_Load(object sender, EventArgs e)
        {
            slidepanel.Height = button1.Height;
            slidepanel.Top = button1.Top;

            //page show 
            studentprofile1.Show();
            grade1.Hide();
            studentexams1.Hide();
            studentsubject1.Hide();
            editprofile1.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button1.Height;
            slidepanel.Top = button1.Top;
            //page show 
            studentprofile1.Show();
            grade1.Hide();
            studentexams1.Hide();
            studentsubject1.Hide();
            editprofile1.Hide();



        }
        private void button2_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button2.Height;
            slidepanel.Top = button2.Top;
            //page show 
            grade1.Show();
            studentprofile1.Hide();
            studentexams1.Hide();
            studentsubject1.Hide();
            editprofile1.Hide();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button3.Height;
            slidepanel.Top = button3.Top;
            //page show 
            studentexams1.Show();
            grade1.Hide();
            studentprofile1.Hide();
            studentsubject1.Hide();
            editprofile1.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button4.Height;
            slidepanel.Top = button4.Top;
            
            //page show 
            studentsubject1.Show();
            grade1.Hide();
            studentprofile1.Hide();
            studentexams1.Hide();
            editprofile1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button5.Height;
            slidepanel.Top = button5.Top;

            //page show 
            editprofile1.Show();
            grade1.Hide();
            studentprofile1.Hide();
            studentexams1.Hide();
            studentsubject1.Hide();
        }

        private void grade1_Load(object sender, EventArgs e)
        {

        }
    }
}
