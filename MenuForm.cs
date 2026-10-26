using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _25520840_Lab2
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            Form3.Show();
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            Form Form4 = new Form4();
            Form4.Show();
        }

        private void btnForm5_Click(object sender, EventArgs e)
        {
            Form Form5 = new Form5();
            Form5.Show();
        }

        private void btnForm6_Click(object sender, EventArgs e)
        {
            Form Form6 = new Form6();
            Form6.Show();
        }

        private void btnForm7_Click(object sender, EventArgs e)
        {
            Form Form7 = new Form7();
            Form7.Show();
        }
    }
}
