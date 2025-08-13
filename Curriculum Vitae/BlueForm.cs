using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curriculum_Vitae
{
    public partial class BlueForm : Form
    {
        // Declare all the labels and picture box
        private Label full_name_text;
        private Label phonenumber_label;
        private Label email_label;
        private Label address_label;
        private Label objectives_label;
        private Label jhs_label;
        private Label jhs_year_label;
        private Label shs_label;
        private Label shs_year_label;
        private Label college_label;
        private Label college_year_label;
        private Label nationality_label;
        private Label birthday_label;
        private Label company_name_label;
        private Label experience_label;
        private Label skills_label;
        private Label sex_label;
        private PictureBox pictureBox2;

        public BlueForm(string fullname,
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
            CreateControls(); // Create all the labels and picture box
            EnableScrollablePanel(); // Make the form scrollable

            // Set form properties for professional blue theme
            this.BackColor = Color.FromArgb(240, 248, 255); // AliceBlue
            this.Text = "Professional CV - " + fullname;

            


            // Populate form data
            full_name_text.Text = fullname;
            full_name_text.ForeColor = Color.FromArgb(25, 25, 112); // MidnightBlue
            full_name_text.Font = new Font("Segoe UI", 18, FontStyle.Bold);

            phonenumber_label.Text = phonenumber;
            phonenumber_label.ForeColor = Color.FromArgb(70, 130, 180); // SteelBlue

            email_label.Text = email;
            email_label.ForeColor = Color.FromArgb(70, 130, 180);

            address_label.Text = full_address;
            address_label.ForeColor = Color.FromArgb(70, 130, 180);

            objectives_label.Text = objectives;
            objectives_label.ForeColor = Color.FromArgb(47, 79, 79); // DarkSlateGray
            objectives_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            jhs_label.Text = jhs;
            jhs_label.ForeColor = Color.FromArgb(47, 79, 79);

            jhs_year_label.Text = jhs_year;
            jhs_year_label.ForeColor = Color.FromArgb(105, 105, 105); // DimGray

            shs_label.Text = shs;
            shs_label.ForeColor = Color.FromArgb(47, 79, 79);

            shs_year_label.Text = shs_year;
            shs_year_label.ForeColor = Color.FromArgb(105, 105, 105);

            college_label.Text = college;
            college_label.ForeColor = Color.FromArgb(47, 79, 79);

            college_year_label.Text = college_year;
            college_year_label.ForeColor = Color.FromArgb(105, 105, 105);

            nationality_label.Text = nationality;
            nationality_label.ForeColor = Color.FromArgb(70, 130, 180);

            birthday_label.Text = birthday;
            birthday_label.ForeColor = Color.FromArgb(70, 130, 180);

            company_name_label.Text = company_name;
            company_name_label.ForeColor = Color.FromArgb(47, 79, 79);

            experience_label.Text = experience;
            experience_label.ForeColor = Color.FromArgb(47, 79, 79);

            skills_label.Text = skills;
            skills_label.ForeColor = Color.FromArgb(47, 79, 79);

            sex_label.Text = sex;
            sex_label.ForeColor = Color.FromArgb(70, 130, 180);

            // Configure picture box
            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            college_label.Text = college;
            shs_label.Text = shs;
            shs_year_label.Text = shs_year;
            jhs_label.Text = jhs;
            jhs_year_label.Text = jhs_year;
            company_name_label.Text = company_name;
            experience_label.Text = experience;
            skills_label.Text = skills;
            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            // Add section headers styling
            StyleSectionHeaders();
        }

        private void CreateControls()
        {
            // Set form properties
            this.Size = new Size(800, 1000);
            this.BackColor = Color.FromArgb(240, 248, 255); // AliceBlue
            this.Text = "Professional CV";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Create and position all controls
            full_name_text = new Label();
            full_name_text.Location = new Point(50, 50);
            full_name_text.Size = new Size(400, 40);
            full_name_text.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            full_name_text.ForeColor = Color.FromArgb(25, 25, 112);
            this.Controls.Add(full_name_text);

            // Contact Information Section
            Label contactHeader = new Label();
            contactHeader.Text = "CONTACT INFORMATION";
            contactHeader.Location = new Point(50, 100);
            contactHeader.Size = new Size(300, 30);
            contactHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            contactHeader.ForeColor = Color.FromArgb(25, 25, 112);
            contactHeader.BackColor = Color.FromArgb(176, 196, 222);
            this.Controls.Add(contactHeader);

            phonenumber_label = new Label();
            phonenumber_label.Location = new Point(50, 140);
            phonenumber_label.Size = new Size(300, 25);
            phonenumber_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            phonenumber_label.ForeColor = Color.FromArgb(70, 130, 180);
            this.Controls.Add(phonenumber_label);

            email_label = new Label();
            email_label.Location = new Point(50, 170);
            email_label.Size = new Size(400, 25);
            email_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            email_label.ForeColor = Color.FromArgb(70, 130, 180);
            this.Controls.Add(email_label);

            address_label = new Label();
            address_label.Location = new Point(50, 200);
            address_label.Size = new Size(500, 50);
            address_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            address_label.ForeColor = Color.FromArgb(70, 130, 180);
            this.Controls.Add(address_label);

            nationality_label = new Label();
            nationality_label.Location = new Point(50, 260);
            nationality_label.Size = new Size(200, 25);
            nationality_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            nationality_label.ForeColor = Color.FromArgb(70, 130, 180);
            this.Controls.Add(nationality_label);

            birthday_label = new Label();
            birthday_label.Location = new Point(50, 290);
            birthday_label.Size = new Size(200, 25);
            birthday_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            birthday_label.ForeColor = Color.FromArgb(70, 130, 180);
            this.Controls.Add(birthday_label);

            sex_label = new Label();
            sex_label.Location = new Point(50, 320);
            sex_label.Size = new Size(200, 25);
            sex_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            sex_label.ForeColor = Color.FromArgb(70, 130, 180);
            this.Controls.Add(sex_label);

            // Picture Box
            pictureBox2 = new PictureBox();
            pictureBox2.Location = new Point(500, 50);
            pictureBox2.Size = new Size(150, 150);
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox2);

            // Objectives Section
            Label objectivesHeader = new Label();
            objectivesHeader.Text = "OBJECTIVES";
            objectivesHeader.Location = new Point(50, 360);
            objectivesHeader.Size = new Size(300, 30);
            objectivesHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            objectivesHeader.ForeColor = Color.FromArgb(25, 25, 112);
            objectivesHeader.BackColor = Color.FromArgb(176, 196, 222);
            this.Controls.Add(objectivesHeader);

            objectives_label = new Label();
            objectives_label.Location = new Point(50, 400);
            objectives_label.Size = new Size(600, 60);
            objectives_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            objectives_label.ForeColor = Color.FromArgb(47, 79, 79);
            this.Controls.Add(objectives_label);

            // Education Section
            Label educationHeader = new Label();
            educationHeader.Text = "EDUCATION";
            educationHeader.Location = new Point(50, 470);
            educationHeader.Size = new Size(300, 30);
            educationHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            educationHeader.ForeColor = Color.FromArgb(25, 25, 112);
            educationHeader.BackColor = Color.FromArgb(176, 196, 222);
            this.Controls.Add(educationHeader);

            college_label = new Label();
            college_label.Location = new Point(50, 510);
            college_label.Size = new Size(400, 25);
            college_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            college_label.ForeColor = Color.FromArgb(47, 79, 79);
            this.Controls.Add(college_label);

            college_year_label = new Label();
            college_year_label.Location = new Point(460, 510);
            college_year_label.Size = new Size(100, 25);
            college_year_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            college_year_label.ForeColor = Color.FromArgb(105, 105, 105);
            this.Controls.Add(college_year_label);

            shs_label = new Label();
            shs_label.Location = new Point(50, 540);
            shs_label.Size = new Size(400, 25);
            shs_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            shs_label.ForeColor = Color.FromArgb(47, 79, 79);
            this.Controls.Add(shs_label);

            shs_year_label = new Label();
            shs_year_label.Location = new Point(460, 540);
            shs_year_label.Size = new Size(100, 25);
            shs_year_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            shs_year_label.ForeColor = Color.FromArgb(105, 105, 105);
            this.Controls.Add(shs_year_label);

            jhs_label = new Label();
            jhs_label.Location = new Point(50, 570);
            jhs_label.Size = new Size(400, 25);
            jhs_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            jhs_label.ForeColor = Color.FromArgb(47, 79, 79);
            this.Controls.Add(jhs_label);

            jhs_year_label = new Label();
            jhs_year_label.Location = new Point(460, 570);
            jhs_year_label.Size = new Size(100, 25);
            jhs_year_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            jhs_year_label.ForeColor = Color.FromArgb(105, 105, 105);
            this.Controls.Add(jhs_year_label);

            // Experience Section
            Label experienceHeader = new Label();
            experienceHeader.Text = "WORK EXPERIENCE";
            experienceHeader.Location = new Point(50, 610);
            experienceHeader.Size = new Size(300, 30);
            experienceHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            experienceHeader.ForeColor = Color.FromArgb(25, 25, 112);
            experienceHeader.BackColor = Color.FromArgb(176, 196, 222);
            this.Controls.Add(experienceHeader);

            company_name_label = new Label();
            company_name_label.Location = new Point(50, 650);
            company_name_label.Size = new Size(400, 25);
            company_name_label.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            company_name_label.ForeColor = Color.FromArgb(47, 79, 79);
            this.Controls.Add(company_name_label);

            experience_label = new Label();
            experience_label.Location = new Point(50, 680);
            experience_label.Size = new Size(600, 60);
            experience_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            experience_label.ForeColor = Color.FromArgb(47, 79, 79);
            this.Controls.Add(experience_label);

            // Skills Section
            Label skillsHeader = new Label();
            skillsHeader.Text = "SKILLS";
            skillsHeader.Location = new Point(50, 750);
            skillsHeader.Size = new Size(300, 30);
            skillsHeader.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            skillsHeader.ForeColor = Color.FromArgb(25, 25, 112);
            skillsHeader.BackColor = Color.FromArgb(176, 196, 222);
            this.Controls.Add(skillsHeader);

            skills_label = new Label();
            skills_label.Location = new Point(50, 790);
            skills_label.Size = new Size(600, 60);
            skills_label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            skills_label.ForeColor = Color.FromArgb(47, 79, 79);
            this.Controls.Add(skills_label);

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

        private void StyleSectionHeaders()
        {
            // Assuming you have section header labels in your designer
            // You can add panels with blue backgrounds for section separators
            Font headerFont = new Font("Segoe UI", 12, FontStyle.Bold);
            Color headerColor = Color.FromArgb(25, 25, 112); // MidnightBlue

            // Style section headers if they exist
            foreach (Control control in this.Controls)
            {
                if (control is Label && control.Name.Contains("header"))
                {
                    control.Font = headerFont;
                    control.ForeColor = headerColor;
                    control.BackColor = Color.FromArgb(176, 196, 222); // LightSteelBlue
                }
            }
        }

        private void BlueForm_Load(object sender, EventArgs e)
        {
            // Add any initialization code here

        }

        // Event handlers (keep empty as in original)
        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox7_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
    }
}