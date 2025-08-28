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
    public partial class CV_Form4 : Form
    {
        public CV_Form4()
        {
            InitializeComponent();
            this.Load += CV_Form4_Load;
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

        private void CV_Form4_Load(object sender, EventArgs e)
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
            string fullname = textBox2.Text +", " + textBox1.Text + " " + textBox3.Text + " " + suffix.Text;
            string email = email_textbox.Text;
            string phonenumber = phonenumber_textbox.Text;
            string full_address = textBox7.Text + " " + textBox8.Text + " " + textBox4.Text + " " + textBox10.Text;
            string objectives = objective_text.Text;
            string nationality = textBox9.Text;
            string jhs = jhs_textbox.Text;
            string jhs_year = textBox17.Text;
            string shs = shs_textbox.Text;
            string shs_year = textBox20.Text;
            string college = college_textbox.Text;
            string college_year = textBox23.Text;
            string birthday = birthday_textbox.Text;
            string company_name = company_name_textbox.Text;
            string experience = experience_textbox.Text;
            string skills = skills_textbox.Text;
            string sex = sex_combobox.Text;


            if (pictureBox2.Image != null)
            {
                this.Close();
                Pink pink = new Pink(fullname, email, phonenumber, full_address, objectives, jhs, jhs_year, shs, shs_year, college, college_year, nationality, birthday, company_name, experience, skills, sex, pictureBox2.Image);
                pink.Show();
                this.Hide();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
