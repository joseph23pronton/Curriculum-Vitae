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
    public partial class MintChocolateCV : Form
    {
        // Mint Chocolate Color Palette
        private readonly Color DarkMintGreen = Color.FromArgb(45, 90, 61);      // #2D5A3D
        private readonly Color MintGreen = Color.FromArgb(127, 211, 160);       // #7FD3A0
        private readonly Color DarkBackground = Color.FromArgb(26, 47, 26);     // #1A2F1A
        private readonly Color LightMint = Color.FromArgb(184, 212, 193);       // #B8D4C1
        private readonly Color WhiteSmoke = Color.FromArgb(250, 250, 250);      // #FAFAFA

        public MintChocolateCV(string fullname, string email, string phonenumber, string full_address,
            string objectives, string jhs, string jhs_year, string shs, string shs_year,
            string college, string college_year, string nationality, string birthday,
            string company_name, string experience, string skills, string sex, Image img)
        {
            InitializeComponent();
            SetupFormDesign();
            PopulateData(fullname, email, phonenumber, full_address, objectives, jhs, jhs_year,
                        shs, shs_year, college, college_year, nationality, birthday,
                        company_name, experience, skills, sex, img);
        }

        private void SetupFormDesign()
        {
            // Form Properties
            this.Size = new Size(1200, 850);
            this.BackColor = DarkBackground;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Professional CV - Mint Chocolate Theme";

            // Main Container Panel
            Panel mainPanel = new Panel()
            {
                Size = new Size(1160, 800),
                Location = new Point(20, 20),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            // Left Sidebar Panel (Dark Mint)
            Panel sidebarPanel = new Panel()
            {
                Size = new Size(400, 800),
                Location = new Point(0, 0),
                BackColor = DarkMintGreen
            };

            // Right Content Panel (Light)
            Panel contentPanel = new Panel()
            {
                Size = new Size(760, 800),
                Location = new Point(400, 0),
                BackColor = WhiteSmoke
            };

            // Profile Picture
            PictureBox profilePicture = new PictureBox()
            {
                Size = new Size(150, 150),
                Location = new Point(125, 40),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.None
            };

            // Name Label
            Label nameLabel = new Label()
            {
                Size = new Size(350, 40),
                Location = new Point(25, 210),
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = MintGreen,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };

            // Contact Section Header
            Label contactHeader = CreateSectionHeader("CONTACT INFORMATION", new Point(25, 270));

            // Contact Labels
            Label phoneLabel = CreateContactLabel("📱 Phone:", new Point(25, 310));
            Label phoneValue = CreateContactValue("", new Point(25, 335));

            Label emailLabel = CreateContactLabel("📧 Email:", new Point(25, 365));
            Label emailValue = CreateContactValue("", new Point(25, 390));

            Label addressLabel = CreateContactLabel("🏠 Address:", new Point(25, 420));
            Label addressValue = CreateContactValue("", new Point(25, 445));

            Label nationalityLabel = CreateContactLabel("🌍 Nationality:", new Point(25, 490));
            Label nationalityValue = CreateContactValue("", new Point(25, 515));

            Label birthdayLabel = CreateContactLabel("🎂 Birthday:", new Point(25, 545));
            Label birthdayValue = CreateContactValue("", new Point(25, 570));

            Label sexLabel = CreateContactLabel("👤 Gender:", new Point(25, 600));
            Label sexValue = CreateContactValue("", new Point(25, 625));

            // Skills Section
            Label skillsHeader = CreateSectionHeader("SKILLS", new Point(25, 670));
            Label skillsValue = CreateContactValue("", new Point(25, 710));

            // Right Panel Content
            // Objectives Section
            Label objectivesHeader = CreateMainSectionHeader("CAREER OBJECTIVE", new Point(30, 30));
            Label objectivesValue = CreateMainContentLabel("", new Point(30, 70), new Size(700, 80));

            // Education Section
            Label educationHeader = CreateMainSectionHeader("EDUCATION", new Point(30, 170));

            Label collegeLabel = CreateEducationLabel("COLLEGE:", new Point(30, 210));
            Label collegeValue = CreateEducationValue("", new Point(30, 235));
            Label collegeYearValue = CreateEducationYear("", new Point(600, 235));

            Label shsLabel = CreateEducationLabel("SENIOR HIGH SCHOOL:", new Point(30, 275));
            Label shsValue = CreateEducationValue("", new Point(30, 300));
            Label shsYearValue = CreateEducationYear("", new Point(600, 300));

            Label jhsLabel = CreateEducationLabel("JUNIOR HIGH SCHOOL:", new Point(30, 340));
            Label jhsValue = CreateEducationValue("", new Point(30, 365));
            Label jhsYearValue = CreateEducationYear("", new Point(600, 365));

            // Experience Section
            Label experienceHeader = CreateMainSectionHeader("WORK EXPERIENCE", new Point(30, 420));
            Label companyLabel = CreateEducationLabel("COMPANY:", new Point(30, 460));
            Label companyValue = CreateEducationValue("", new Point(30, 485));
            Label experienceValue = CreateMainContentLabel("", new Point(30, 520), new Size(700, 100));

            // Add all controls to panels
            sidebarPanel.Controls.AddRange(new Control[] {
                profilePicture, nameLabel, contactHeader, phoneLabel, phoneValue,
                emailLabel, emailValue, addressLabel, addressValue,
                nationalityLabel, nationalityValue, birthdayLabel, birthdayValue,
                sexLabel, sexValue, skillsHeader, skillsValue
            });

            contentPanel.Controls.AddRange(new Control[] {
                objectivesHeader, objectivesValue, educationHeader,
                collegeLabel, collegeValue, collegeYearValue,
                shsLabel, shsValue, shsYearValue,
                jhsLabel, jhsValue, jhsYearValue,
                experienceHeader, companyLabel, companyValue, experienceValue
            });

            mainPanel.Controls.AddRange(new Control[] { sidebarPanel, contentPanel });
            this.Controls.Add(mainPanel);

            // Store references for data population
            this.profilePicture = profilePicture;
            this.nameLabel = nameLabel;
            this.phoneValue = phoneValue;
            this.emailValue = emailValue;
            this.addressValue = addressValue;
            this.nationalityValue = nationalityValue;
            this.birthdayValue = birthdayValue;
            this.sexValue = sexValue;
            this.skillsValue = skillsValue;
            this.objectivesValue = objectivesValue;
            this.collegeValue = collegeValue;
            this.collegeYearValue = collegeYearValue;
            this.shsValue = shsValue;
            this.shsYearValue = shsYearValue;
            this.jhsValue = jhsValue;
            this.jhsYearValue = jhsYearValue;
            this.companyValue = companyValue;
            this.experienceValue = experienceValue;
        }

        // Helper methods for creating styled controls
        private Label CreateSectionHeader(string text, Point location)
        {
            return new Label()
            {
                Text = text,
                Size = new Size(350, 25),
                Location = location,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = MintGreen,
                BackColor = Color.Transparent
            };
        }

        private Label CreateContactLabel(string text, Point location)
        {
            return new Label()
            {
                Text = text,
                Size = new Size(350, 20),
                Location = location,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = LightMint,
                BackColor = Color.Transparent
            };
        }

        private Label CreateContactValue(string text, Point location)
        {
            return new Label()
            {
                Text = text,
                Size = new Size(350, 20),
                Location = location,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.White,
                BackColor = Color.Transparent
            };
        }

        private Label CreateMainSectionHeader(string text, Point location)
        {
            return new Label()
            {
                Text = text,
                Size = new Size(700, 30),
                Location = location,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = DarkMintGreen,
                BackColor = Color.Transparent
            };
        }

        private Label CreateMainContentLabel(string text, Point location, Size size)
        {
            return new Label()
            {
                Text = text,
                Size = size,
                Location = location,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(60, 60, 60),
                BackColor = Color.Transparent
            };
        }

        private Label CreateEducationLabel(string text, Point location)
        {
            return new Label()
            {
                Text = text,
                Size = new Size(200, 20),
                Location = location,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = DarkMintGreen,
                BackColor = Color.Transparent
            };
        }

        private Label CreateEducationValue(string text, Point location)
        {
            return new Label()
            {
                Text = text,
                Size = new Size(500, 20),
                Location = location,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(80, 80, 80),
                BackColor = Color.Transparent
            };
        }

        private Label CreateEducationYear(string text, Point location)
        {
            return new Label()
            {
                Text = text,
                Size = new Size(120, 20),
                Location = location,
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                ForeColor = DarkMintGreen,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleRight
            };
        }

        // Control references for data population
        private PictureBox profilePicture;
        private Label nameLabel;
        private Label phoneValue;
        private Label emailValue;
        private Label addressValue;
        private Label nationalityValue;
        private Label birthdayValue;
        private Label sexValue;
        private Label skillsValue;
        private Label objectivesValue;
        private Label collegeValue;
        private Label collegeYearValue;
        private Label shsValue;
        private Label shsYearValue;
        private Label jhsValue;
        private Label jhsYearValue;
        private Label companyValue;
        private Label experienceValue;

        private void PopulateData(string fullname, string email, string phonenumber, string full_address,
            string objectives, string jhs, string jhs_year, string shs, string shs_year,
            string college, string college_year, string nationality, string birthday,
            string company_name, string experience, string skills, string sex, Image img)
        {
            nameLabel.Text = fullname;
            phoneValue.Text = phonenumber;
            emailValue.Text = email;
            addressValue.Text = full_address;
            nationalityValue.Text = nationality;
            birthdayValue.Text = birthday;
            sexValue.Text = sex;
            skillsValue.Text = skills;
            objectivesValue.Text = objectives;
            collegeValue.Text = college;
            collegeYearValue.Text = college_year;
            shsValue.Text = shs;
            shsYearValue.Text = shs_year;
            jhsValue.Text = jhs;
            jhsYearValue.Text = jhs_year;
            companyValue.Text = company_name;
            experienceValue.Text = experience;

            if (img != null)
            {
                profilePicture.Image = img;
            }
        }

        private void MintChocolateCV_Load(object sender, EventArgs e)
        {
            // Any additional load logic
        }
    }
}