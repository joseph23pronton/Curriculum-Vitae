using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Curriculum_Vitae
{
    public partial class Red : Form
    {
        public Red(string fullname, string email, string phonenumber, string full_address,
                   string objectives, string jhs, string jhs_year, string shs, string shs_year,
                   string college, string college_year, string nationality, string birthday,
                   string company_name, string experience, string skills, string sex, Image img
        )
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


            label1.Text = fullname;
            label11.Text = birthday;
            label13.Text = sex;
            label17.Text = full_address;
            label33.Text = email;
            label30.Text = phonenumber;
            label21.Text = jhs;
            label29.Text = jhs_year;
            label25.Text = shs;
            label31.Text = shs_year;
            label26.Text = college;
            label32.Text = college_year;
            label41.Text = company_name;
            label39.Text = experience;
            label34.Text = skills;  
            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Red_Load(object sender, EventArgs e)
        {

        }
    }
}
