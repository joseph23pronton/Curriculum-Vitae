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
    public partial class Pink : Form
    {
        public Pink(string fullname, 
                    string email,
                    string phonenumber,
                    string full_address,
                    string objectives,
                    string jhs,
                    string jhs_year,
                    string shs,
                    string shs_year,
                    string college,
                    string college_year,
                    string nationality,
                    string birthday,
                    string company_name,
                    string experience,
                    string skills,
                    string sex,
                    Image img)
        {
            InitializeComponent();
            full_name_text.Text = fullname;
            phonenumber_label.Text = email;
            phonenumber_label.Text = phonenumber;
            email_label.Text = email;
            address_label.Text = full_address;
            objectives_label.Text = objectives;
            jhs_label.Text = jhs;
            jhs_year_label.Text = jhs_year;
            shs_label.Text = shs;
            shs_year_label.Text = shs_year;
            college_label.Text = college;
            college_year_label.Text = college_year;
            nationality_label.Text = nationality;
            birthday_label.Text = birthday;
            company_name_label.Text = company_name;
            experience_label.Text = experience;
            skills_label.Text = skills;
            sex_label.Text = sex;
            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Pink_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
