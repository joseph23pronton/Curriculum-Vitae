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
            string jhs = textBox19.Text; // Replace with actual textbox
            string jhs_year = textBox17.Text; // Replace with actual textbox
            string shs = textBox22.Text; // Replace with actual textbox  
            string shs_year = textBox20.Text; // Replace with actual textbox
            string college = textBox25.Text; // Replace with actual textbox
            string college_year = textBox23.Text; // Replace with actual textbox
            string nationality = textBox9.Text; // Replace with actual textbox
            string birthday = textBox11.Text; // Replace with actual textbox
            string company_name = textBox26.Text; // Replace with actual textbox
            string experience = richTextBox3.Text; // Replace with actual textbox
            string skills = richTextBox4.Text; // Replace with actual textbox
            string sex = comboBox2.Text; // Replace with actual textbox

            // Default image (you can change this to load from file)
            Image defaultImage = new Bitmap(150, 150);

            if (pictureBox2.Image != null)
            {
                this.Close();
                BlueForm blueForm = new BlueForm(fullname, email, phonenumber, full_address,
                                objectives, jhs, jhs_year, shs, shs_year, college, college_year,
                                nationality, birthday, company_name, experience, skills, sex, pictureBox2.Image);
                blueForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please insert an image first.");
            }
            // Create and show the BlueForm with all the data
            
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

        private void textBox9_TextChanged(object sender, EventArgs e)
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
