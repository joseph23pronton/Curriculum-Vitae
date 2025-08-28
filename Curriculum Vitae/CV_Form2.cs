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
    public partial class CV_Form2 : Form
    {
        public CV_Form2()
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

        private void button1(object sender, EventArgs e)
        {
            // Collect all the data from your form
            string fullname = textBox2.Text + ", " + textBox1.Text + " " + textBox3.Text;
            string email = textBox6.Text;
            string phonenumber = textBox5.Text;
            string full_address = textBox7.Text + " " + textBox8.Text + " " + textBox4.Text + " " + textBox10.Text;
            string objectives = objective_text.Text;

            // You need to collect these additional fields from your form:
            // Add textboxes for these if you don't have them yet
            string jhs = textBox19.Text; // Add textbox for Junior High School
            string jhs_year = textBox17.Text; // Add textbox for JHS graduation year
            string shs = textBox22.Text; // Add textbox for Senior High School  
            string shs_year = textBox20.Text; // Add textbox for SHS graduation year
            string college = textBox25.Text; // Add textbox for College
            string college_year = textBox23.Text; // Add textbox for college graduation year
            string nationality = textBox9.Text; // Add textbox for nationality
            string birthday = textBox11.Text; // Add textbox for birthday
            string company_name = textBox26.Text; // Add textbox for company name
            string experience = richTextBox3.Text; // Add textbox for work experience
            string skills = richTextBox4.Text; // Add textbox for skills
            string sex = sex_combobox.Text; // Add textbox or combobox for gender

            if (pictureBox2.Image != null)
            {
                MintChocolateCV cvForm = new MintChocolateCV(
                fullname,
                email,
                phonenumber,
                full_address,
                objectives,
                jhs,
                jhs_year,
                shs,
                shs_year,
                college,
                college_year,
                nationality,
                birthday,
                company_name,
                experience,
                skills,
                sex,
                pictureBox2.Image
            );

                cvForm.Show();
                this.Hide(); // Hide the current form
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


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.LoggedInUser = null;
            this.Hide();
            var login = new Login();
            login.Show();
        }
    }
}
