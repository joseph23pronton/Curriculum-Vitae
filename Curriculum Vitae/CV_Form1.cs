using System;
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
    public partial class CV_Form1 : Form
    {
        public CV_Form1()
        {
            InitializeComponent();
            this.Load += CV_Form1_Load;
        }

        private void EnableScrollablePanel()
        {
            Panel scrollPanel = new Panel();
            scrollPanel.Dock = DockStyle.Fill;
            scrollPanel.AutoScroll = true;

            var controls = new List<Control>();
            foreach (Control ctrl in this.Controls)
        {
                controls.Add(ctrl);

        }
            this.Controls.Clear();

            foreach (Control ctrl in controls)
            {
                scrollPanel.Controls.Add(ctrl);
            }

            this.Controls.Add(scrollPanel);
        }



                private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CV_Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EnableScrollablePanel();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 600;
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1(object sender, EventArgs e)
        {
            // Collect all the data from your form
            string fullname = textBox2.Text + ", " + textBox1.Text + " " + textBox3.Text;
            string email = textBox6.Text;
            string phonenumber = textBox5.Text;
            string full_address = textBox7.Text + " " + textBox8.Text + " " + textBox4.Text + " " + textBox10.Text;
            string objectives = objective_text.Text;

            // You need to add these textboxes to your form or set default values
            string jhs = "Your Junior High School"; // Replace with actual textbox
            string jhs_year = "2018-2020"; // Replace with actual textbox
            string shs = "Your Senior High School"; // Replace with actual textbox  
            string shs_year = "2020-2022"; // Replace with actual textbox
            string college = "Your College"; // Replace with actual textbox
            string college_year = "2022-2026"; // Replace with actual textbox
            string nationality = "Filipino"; // Replace with actual textbox
            string birthday = "January 1, 2000"; // Replace with actual textbox
            string company_name = "Company Name"; // Replace with actual textbox
            string experience = "Work experience details"; // Replace with actual textbox
            string skills = "Your skills"; // Replace with actual textbox
            string sex = "Male/Female"; // Replace with actual textbox

            // Default image (you can change this to load from file)
            Image defaultImage = new Bitmap(150, 150);

            // Create and show the BlueForm with all the data
            BlueForm blueForm = new BlueForm(fullname, email, phonenumber, full_address,
                objectives, jhs, jhs_year, shs, shs_year, college, college_year,
                nationality, birthday, company_name, experience, skills, sex, defaultImage);

            blueForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
