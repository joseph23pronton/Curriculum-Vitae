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
    public partial class CV_Form3 : Form
    {
        public CV_Form3()
        {
            InitializeComponent();
            this.Load += CV_Form3_Load;
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

        private void CV_Form3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (Session.LoggedInUser != null)
            {
                lblUserInfo.Text = Session.LoggedInUser.Username;
            }
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

        // MODIFIED: Complete button1 method to connect to Red form
        private void button1(object sender, EventArgs e)
        {
            // Collect all data from Form3 textboxes
            string fullname = textBox2.Text + ", " + textBox1.Text + " " + textBox3.Text;
            string email = textBox6.Text;
            string phonenumber = textBox5.Text;
            string full_address = textBox7.Text + " " + textBox8.Text + " " + textBox4.Text + " " + textBox10.Text;
            string objectives = objective_text.Text;

            // You need to add these textboxes in your Designer if they don't exist:
            // For now, I'll use placeholder text or empty strings for missing fields

            string jhs = textBox19.Text; // Add textbox for JHS in designer
            string jhs_year = textBox17.Text; // Add textbox for JHS year
            string shs = textBox22.Text; // Add textbox for SHS
            string shs_year = textBox20.Text; // Add textbox for SHS year  
            string college = textBox25.Text; // Add textbox for college
            string college_year = textBox23.Text; // Add textbox for college year
            string nationality = textBox9.Text; // Add textbox for nationality
            string birthday = textBox11.Text; // Add textbox or DateTimePicker for birthday
            string company_name = textBox26.Text; // Add textbox for company
            string experience = richTextBox3.Text; // Add textbox for experience
            string skills = richTextBox4.Text; // Add textbox for skills
            string sex = sex_combobox.Text; // Add combobox or textbox for gender

            // Get image from pictureBox2 (if user uploaded one)
            Image profileImage = null;
            if (pictureBox2.Image != null)
            {
                profileImage = pictureBox2.Image;
                // Create and show Red CV form with all the data
                Red redCV = new Red(
                    fullname,        // Full name
                    email,           // Email
                    phonenumber,     // Phone number
                    full_address,    // Address
                    objectives,      // Career objectives
                    jhs,             // Junior High School
                    jhs_year,        // JHS year
                    shs,             // Senior High School
                    shs_year,        // SHS year
                    college,         // College
                    college_year,    // College year
                    nationality,     // Nationality
                    birthday,        // Birthday
                    company_name,    // Company name
                    experience,      // Work experience
                    skills,          // Skills
                    sex,             // Gender
                    profileImage     // Profile picture
                );

                redCV.Show(); // Show the Red CV
                this.Hide();  // Hide Form3
            }
            else
            {
                MessageBox.Show("Please insert an image first.");
            }

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select an Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(ofd.FileName);
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom; // Makes it fit nicely
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}