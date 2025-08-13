using System;
using System.Drawing;
using System.Windows.Forms;

namespace Curriculum_Vitae
{
    public partial class Red : Form
    {
        public Red()
        {
            InitializeComponent();
        }

        // This receives and displays data from Form3
        public Red(string fullname, string email, string phonenumber, string full_address,
                   string objectives, string jhs, string jhs_year, string shs, string shs_year,
                   string college, string college_year, string nationality, string birthday,
                   string company_name, string experience, string skills, string sex, Image img)
        {
            InitializeComponent();

            // Put Form3 data into the red CV
            full_name_text.Text = fullname;
            phonenumber_label.Text = "📞 " + phonenumber;
            email_label.Text = "📧 " + email;
            address_label.Text = "📍 " + full_address;
            objectives_label.Text = objectives;
            jhs_label.Text = jhs;
            jhs_year_label.Text = jhs_year;
            shs_label.Text = shs;
            shs_year_label.Text = shs_year;
            college_label.Text = college;
            college_year_label.Text = college_year;
            nationality_label.Text = "Nationality: " + nationality;
            birthday_label.Text = "Birthday: " + birthday;
            company_name_label.Text = company_name;
            experience_label.Text = experience;
            skills_label.Text = skills;
            sex_label.Text = "Gender: " + sex;

            // Set the photo
            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}