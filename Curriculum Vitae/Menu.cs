﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curriculum_Vitae
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CV_Form1 newCV_Form1 = new CV_Form1();
            newCV_Form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CV_Form1 newCV_Form1 = new CV_Form1();
            newCV_Form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CV_Form1 newCV_Form1 = new CV_Form1();
            newCV_Form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CV_Form1 newCV_Form1 = new CV_Form1();
            newCV_Form1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
