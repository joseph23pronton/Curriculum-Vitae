using System.Drawing;
using System.Windows.Forms;

namespace Curriculum_Vitae
{
    partial class Red
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.full_name_text = new System.Windows.Forms.Label();
            this.phonenumber_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.objectives_label = new System.Windows.Forms.Label();
            this.jhs_label = new System.Windows.Forms.Label();
            this.jhs_year_label = new System.Windows.Forms.Label();
            this.shs_label = new System.Windows.Forms.Label();
            this.shs_year_label = new System.Windows.Forms.Label();
            this.college_label = new System.Windows.Forms.Label();
            this.college_year_label = new System.Windows.Forms.Label();
            this.nationality_label = new System.Windows.Forms.Label();
            this.birthday_label = new System.Windows.Forms.Label();
            this.company_name_label = new System.Windows.Forms.Label();
            this.experience_label = new System.Windows.Forms.Label();
            this.skills_label = new System.Windows.Forms.Label();
            this.sex_label = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.educationHeaderPanel = new System.Windows.Forms.Panel();
            this.educationTitleLabel = new System.Windows.Forms.Label();
            this.skillsHeaderPanel = new System.Windows.Forms.Panel();
            this.skillsTitleLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.objectiveHeaderPanel = new System.Windows.Forms.Panel();
            this.objectiveTitleLabel = new System.Windows.Forms.Label();
            this.experienceHeaderPanel = new System.Windows.Forms.Panel();
            this.experienceTitleLabel = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.educationHeaderPanel.SuspendLayout();
            this.skillsHeaderPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.objectiveHeaderPanel.SuspendLayout();
            this.experienceHeaderPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // Form Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Name = "Red";
            this.Text = "Professional CV - Red Theme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            // 
            // Header Panel (Dark Red Background)
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.headerPanel.Controls.Add(this.pictureBox2);
            this.headerPanel.Controls.Add(this.full_name_text);
            this.headerPanel.Controls.Add(this.phonenumber_label);
            this.headerPanel.Controls.Add(this.email_label);
            this.headerPanel.Controls.Add(this.address_label);
            this.headerPanel.Controls.Add(this.birthday_label);
            this.headerPanel.Controls.Add(this.nationality_label);
            this.headerPanel.Controls.Add(this.sex_label);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1200, 180);
            this.headerPanel.TabIndex = 0;

            // 
            // Profile Picture
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(30, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;

            // 
            // Full Name (Large White Text)
            // 
            this.full_name_text.AutoSize = true;
            this.full_name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.full_name_text.ForeColor = System.Drawing.Color.White;
            this.full_name_text.Location = new System.Drawing.Point(200, 25);
            this.full_name_text.Name = "full_name_text";
            this.full_name_text.Size = new System.Drawing.Size(508, 42);
            this.full_name_text.TabIndex = 2;
            this.full_name_text.Text = "FULL NAME";

            // 
            // Contact Information Labels
            // 
            this.phonenumber_label.AutoSize = true;
            this.phonenumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.phonenumber_label.ForeColor = System.Drawing.Color.White;
            this.phonenumber_label.Location = new System.Drawing.Point(200, 80);
            this.phonenumber_label.Name = "phonenumber_label";
            this.phonenumber_label.Size = new System.Drawing.Size(150, 18);
            this.phonenumber_label.TabIndex = 3;
            this.phonenumber_label.Text = "📞 Phone Number";

            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.email_label.ForeColor = System.Drawing.Color.White;
            this.email_label.Location = new System.Drawing.Point(400, 80);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(200, 18);
            this.email_label.TabIndex = 4;
            this.email_label.Text = "📧 Email Address";

            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.address_label.ForeColor = System.Drawing.Color.White;
            this.address_label.Location = new System.Drawing.Point(200, 110);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(300, 18);
            this.address_label.TabIndex = 5;
            this.address_label.Text = "📍 Home Address";

            this.birthday_label.AutoSize = true;
            this.birthday_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.birthday_label.ForeColor = System.Drawing.Color.White;
            this.birthday_label.Location = new System.Drawing.Point(650, 80);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(150, 18);
            this.birthday_label.TabIndex = 6;
            this.birthday_label.Text = "🎂 Birthday";

            this.nationality_label.AutoSize = true;
            this.nationality_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.nationality_label.ForeColor = System.Drawing.Color.White;
            this.nationality_label.Location = new System.Drawing.Point(650, 110);
            this.nationality_label.Name = "nationality_label";
            this.nationality_label.Size = new System.Drawing.Size(120, 18);
            this.nationality_label.TabIndex = 7;
            this.nationality_label.Text = "🌍 Nationality";

            this.sex_label.AutoSize = true;
            this.sex_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.sex_label.ForeColor = System.Drawing.Color.White;
            this.sex_label.Location = new System.Drawing.Point(650, 140);
            this.sex_label.Name = "sex_label";
            this.sex_label.Size = new System.Drawing.Size(100, 18);
            this.sex_label.TabIndex = 8;
            this.sex_label.Text = "👤 Gender";

            // 
            // Left Panel (Education & Skills)
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leftPanel.Controls.Add(this.educationHeaderPanel);
            this.leftPanel.Controls.Add(this.jhs_label);
            this.leftPanel.Controls.Add(this.jhs_year_label);
            this.leftPanel.Controls.Add(this.shs_label);
            this.leftPanel.Controls.Add(this.shs_year_label);
            this.leftPanel.Controls.Add(this.college_label);
            this.leftPanel.Controls.Add(this.college_year_label);
            this.leftPanel.Controls.Add(this.skillsHeaderPanel);
            this.leftPanel.Controls.Add(this.skills_label);
            this.leftPanel.Location = new System.Drawing.Point(0, 180);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(350, 620);
            this.leftPanel.TabIndex = 9;

            // 
            // Education Header Panel
            // 
            this.educationHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.educationHeaderPanel.Controls.Add(this.educationTitleLabel);
            this.educationHeaderPanel.Location = new System.Drawing.Point(0, 20);
            this.educationHeaderPanel.Name = "educationHeaderPanel";
            this.educationHeaderPanel.Size = new System.Drawing.Size(350, 40);
            this.educationHeaderPanel.TabIndex = 10;

            this.educationTitleLabel.AutoSize = true;
            this.educationTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.educationTitleLabel.ForeColor = System.Drawing.Color.White;
            this.educationTitleLabel.Location = new System.Drawing.Point(15, 8);
            this.educationTitleLabel.Name = "educationTitleLabel";
            this.educationTitleLabel.Size = new System.Drawing.Size(104, 24);
            this.educationTitleLabel.TabIndex = 0;
            this.educationTitleLabel.Text = "Education";

            // 
            // Education Labels
            // 
            this.jhs_label.AutoSize = true;
            this.jhs_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.jhs_label.ForeColor = System.Drawing.Color.White;
            this.jhs_label.Location = new System.Drawing.Point(20, 80);
            this.jhs_label.Name = "jhs_label";
            this.jhs_label.Size = new System.Drawing.Size(152, 18);
            this.jhs_label.TabIndex = 11;
            this.jhs_label.Text = "Junior High School";

            this.jhs_year_label.AutoSize = true;
            this.jhs_year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.jhs_year_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.jhs_year_label.Location = new System.Drawing.Point(20, 105);
            this.jhs_year_label.Name = "jhs_year_label";
            this.jhs_year_label.Size = new System.Drawing.Size(100, 17);
            this.jhs_year_label.TabIndex = 12;
            this.jhs_year_label.Text = "Year Graduated";

            this.shs_label.AutoSize = true;
            this.shs_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.shs_label.ForeColor = System.Drawing.Color.White;
            this.shs_label.Location = new System.Drawing.Point(20, 140);
            this.shs_label.Name = "shs_label";
            this.shs_label.Size = new System.Drawing.Size(154, 18);
            this.shs_label.TabIndex = 13;
            this.shs_label.Text = "Senior High School";

            this.shs_year_label.AutoSize = true;
            this.shs_year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.shs_year_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.shs_year_label.Location = new System.Drawing.Point(20, 165);
            this.shs_year_label.Name = "shs_year_label";
            this.shs_year_label.Size = new System.Drawing.Size(100, 17);
            this.shs_year_label.TabIndex = 14;
            this.shs_year_label.Text = "Year Graduated";

            this.college_label.AutoSize = true;
            this.college_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.college_label.ForeColor = System.Drawing.Color.White;
            this.college_label.Location = new System.Drawing.Point(20, 200);
            this.college_label.Name = "college_label";
            this.college_label.Size = new System.Drawing.Size(65, 18);
            this.college_label.TabIndex = 15;
            this.college_label.Text = "College";

            this.college_year_label.AutoSize = true;
            this.college_year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.college_year_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.college_year_label.Location = new System.Drawing.Point(20, 225);
            this.college_year_label.Name = "college_year_label";
            this.college_year_label.Size = new System.Drawing.Size(100, 17);
            this.college_year_label.TabIndex = 16;
            this.college_year_label.Text = "Year Graduated";

            // 
            // Skills Header Panel
            // 
            this.skillsHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skillsHeaderPanel.Controls.Add(this.skillsTitleLabel);
            this.skillsHeaderPanel.Location = new System.Drawing.Point(0, 280);
            this.skillsHeaderPanel.Name = "skillsHeaderPanel";
            this.skillsHeaderPanel.Size = new System.Drawing.Size(350, 40);
            this.skillsHeaderPanel.TabIndex = 17;

            this.skillsTitleLabel.AutoSize = true;
            this.skillsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.skillsTitleLabel.ForeColor = System.Drawing.Color.White;
            this.skillsTitleLabel.Location = new System.Drawing.Point(15, 8);
            this.skillsTitleLabel.Name = "skillsTitleLabel";
            this.skillsTitleLabel.Size = new System.Drawing.Size(58, 24);
            this.skillsTitleLabel.TabIndex = 0;
            this.skillsTitleLabel.Text = "Skills";

            this.skills_label.AutoSize = true;
            this.skills_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.skills_label.ForeColor = System.Drawing.Color.White;
            this.skills_label.Location = new System.Drawing.Point(20, 340);
            this.skills_label.Name = "skills_label";
            this.skills_label.Size = new System.Drawing.Size(280, 200);
            this.skills_label.TabIndex = 18;
            this.skills_label.Text = "Skills and Competencies";

            // 
            // Right Panel (Objectives & Experience)
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Controls.Add(this.objectiveHeaderPanel);
            this.rightPanel.Controls.Add(this.objectives_label);
            this.rightPanel.Controls.Add(this.experienceHeaderPanel);
            this.rightPanel.Controls.Add(this.company_name_label);
            this.rightPanel.Controls.Add(this.experience_label);
            this.rightPanel.Location = new System.Drawing.Point(350, 180);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(850, 620);
            this.rightPanel.TabIndex = 19;

            // 
            // Objective Header Panel
            // 
            this.objectiveHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.objectiveHeaderPanel.Controls.Add(this.objectiveTitleLabel);
            this.objectiveHeaderPanel.Location = new System.Drawing.Point(20, 20);
            this.objectiveHeaderPanel.Name = "objectiveHeaderPanel";
            this.objectiveHeaderPanel.Size = new System.Drawing.Size(810, 40);
            this.objectiveHeaderPanel.TabIndex = 20;

            this.objectiveTitleLabel.AutoSize = true;
            this.objectiveTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.objectiveTitleLabel.ForeColor = System.Drawing.Color.White;
            this.objectiveTitleLabel.Location = new System.Drawing.Point(15, 8);
            this.objectiveTitleLabel.Name = "objectiveTitleLabel";
            this.objectiveTitleLabel.Size = new System.Drawing.Size(108, 24);
            this.objectiveTitleLabel.TabIndex = 0;
            this.objectiveTitleLabel.Text = "Objectives";

            this.objectives_label.AutoSize = true;
            this.objectives_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.objectives_label.ForeColor = System.Drawing.Color.Black;
            this.objectives_label.Location = new System.Drawing.Point(35, 80);
            this.objectives_label.Name = "objectives_label";
            this.objectives_label.Size = new System.Drawing.Size(750, 100);
            this.objectives_label.TabIndex = 21;
            this.objectives_label.Text = "Career Objectives";

            // 
            // Experience Header Panel
            // 
            this.experienceHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.experienceHeaderPanel.Controls.Add(this.experienceTitleLabel);
            this.experienceHeaderPanel.Location = new System.Drawing.Point(20, 220);
            this.experienceHeaderPanel.Name = "experienceHeaderPanel";
            this.experienceHeaderPanel.Size = new System.Drawing.Size(810, 40);
            this.experienceHeaderPanel.TabIndex = 22;

            this.experienceTitleLabel.AutoSize = true;
            this.experienceTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.experienceTitleLabel.ForeColor = System.Drawing.Color.White;
            this.experienceTitleLabel.Location = new System.Drawing.Point(15, 8);
            this.experienceTitleLabel.Name = "experienceTitleLabel";
            this.experienceTitleLabel.Size = new System.Drawing.Size(172, 24);
            this.experienceTitleLabel.TabIndex = 0;
            this.experienceTitleLabel.Text = "Work Experience";

            this.company_name_label.AutoSize = true;
            this.company_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.company_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.company_name_label.Location = new System.Drawing.Point(35, 280);
            this.company_name_label.Name = "company_name_label";
            this.company_name_label.Size = new System.Drawing.Size(150, 24);
            this.company_name_label.TabIndex = 23;
            this.company_name_label.Text = "Company Name";

            this.experience_label.AutoSize = true;
            this.experience_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.experience_label.ForeColor = System.Drawing.Color.Black;
            this.experience_label.Location = new System.Drawing.Point(35, 320);
            this.experience_label.Name = "experience_label";
            this.experience_label.Size = new System.Drawing.Size(750, 200);
            this.experience_label.TabIndex = 24;
            this.experience_label.Text = "Work Experience Details";

            // Add controls to form
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.headerPanel);

            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.educationHeaderPanel.ResumeLayout(false);
            this.educationHeaderPanel.PerformLayout();
            this.skillsHeaderPanel.ResumeLayout(false);
            this.skillsHeaderPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.objectiveHeaderPanel.ResumeLayout(false);
            this.objectiveHeaderPanel.PerformLayout();
            this.experienceHeaderPanel.ResumeLayout(false);
            this.experienceHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Control declarations
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label full_name_text;
        private System.Windows.Forms.Label phonenumber_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label objectives_label;
        private System.Windows.Forms.Label jhs_label;
        private System.Windows.Forms.Label jhs_year_label;
        private System.Windows.Forms.Label shs_label;
        private System.Windows.Forms.Label shs_year_label;
        private System.Windows.Forms.Label college_label;
        private System.Windows.Forms.Label college_year_label;
        private System.Windows.Forms.Label nationality_label;
        private System.Windows.Forms.Label birthday_label;
        private System.Windows.Forms.Label company_name_label;
        private System.Windows.Forms.Label experience_label;
        private System.Windows.Forms.Label skills_label;
        private System.Windows.Forms.Label sex_label;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel educationHeaderPanel;
        private System.Windows.Forms.Label educationTitleLabel;
        private System.Windows.Forms.Panel skillsHeaderPanel;
        private System.Windows.Forms.Label skillsTitleLabel;
        private System.Windows.Forms.Panel objectiveHeaderPanel;
        private System.Windows.Forms.Label objectiveTitleLabel;
        private System.Windows.Forms.Panel experienceHeaderPanel;
        private System.Windows.Forms.Label experienceTitleLabel;
    }
}