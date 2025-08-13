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
            this.contactPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.contactPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // Header Panel (Dark Red)
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.headerPanel.Controls.Add(this.pictureBox2);
            this.headerPanel.Controls.Add(this.full_name_text);
            this.headerPanel.Controls.Add(this.contactPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1200, 140);
            this.headerPanel.TabIndex = 0;
            // 
            // Profile Picture
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(30, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Full Name (Large White Text)
            // 
            this.full_name_text.AutoSize = false;
            this.full_name_text.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.full_name_text.ForeColor = System.Drawing.Color.White;
            this.full_name_text.Location = new System.Drawing.Point(170, 15);
            this.full_name_text.Name = "full_name_text";
            this.full_name_text.Size = new System.Drawing.Size(600, 45);
            this.full_name_text.TabIndex = 2;
            this.full_name_text.Text = "FULL NAME";
            // 
            // Contact Panel (Medium Red)
            // 
            this.contactPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.contactPanel.Controls.Add(this.phonenumber_label);
            this.contactPanel.Controls.Add(this.email_label);
            this.contactPanel.Controls.Add(this.address_label);
            this.contactPanel.Location = new System.Drawing.Point(170, 70);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(600, 60);
            this.contactPanel.TabIndex = 3;
            // 
            // Phone Number
            // 
            this.phonenumber_label.Font = new System.Drawing.Font("Arial", 11F);
            this.phonenumber_label.ForeColor = System.Drawing.Color.White;
            this.phonenumber_label.Location = new System.Drawing.Point(15, 8);
            this.phonenumber_label.Name = "phonenumber_label";
            this.phonenumber_label.Size = new System.Drawing.Size(180, 20);
            this.phonenumber_label.TabIndex = 4;
            this.phonenumber_label.Text = "📞 Phone Number";
            // 
            // Email
            // 
            this.email_label.Font = new System.Drawing.Font("Arial", 11F);
            this.email_label.ForeColor = System.Drawing.Color.White;
            this.email_label.Location = new System.Drawing.Point(220, 8);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(250, 20);
            this.email_label.TabIndex = 5;
            this.email_label.Text = "📧 Email Address";
            // 
            // Address
            // 
            this.address_label.Font = new System.Drawing.Font("Arial", 11F);
            this.address_label.ForeColor = System.Drawing.Color.White;
            this.address_label.Location = new System.Drawing.Point(15, 32);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(450, 25);
            this.address_label.TabIndex = 6;
            this.address_label.Text = "📍 Home Address";
            // 
            // Main Content Panel (White)
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Location = new System.Drawing.Point(20, 160);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1160, 620);
            this.mainPanel.TabIndex = 7;
            // 
            // Left Panel (Personal Info & Education)
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.nationality_label);
            this.leftPanel.Controls.Add(this.birthday_label);
            this.leftPanel.Controls.Add(this.sex_label);
            this.leftPanel.Controls.Add(this.jhs_label);
            this.leftPanel.Controls.Add(this.jhs_year_label);
            this.leftPanel.Controls.Add(this.shs_label);
            this.leftPanel.Controls.Add(this.shs_year_label);
            this.leftPanel.Controls.Add(this.college_label);
            this.leftPanel.Controls.Add(this.college_year_label);
            this.leftPanel.Location = new System.Drawing.Point(20, 10);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(360, 600);
            this.leftPanel.TabIndex = 8;
            // 
            // Personal Info Labels
            // 
            this.nationality_label.Font = new System.Drawing.Font("Arial", 11F);
            this.nationality_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nationality_label.Location = new System.Drawing.Point(20, 40);
            this.nationality_label.Name = "nationality_label";
            this.nationality_label.Size = new System.Drawing.Size(320, 25);
            this.nationality_label.TabIndex = 9;
            this.nationality_label.Text = "Nationality: ";

            this.birthday_label.Font = new System.Drawing.Font("Arial", 11F);
            this.birthday_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.birthday_label.Location = new System.Drawing.Point(20, 70);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(320, 25);
            this.birthday_label.TabIndex = 10;
            this.birthday_label.Text = "Birthday: ";

            this.sex_label.Font = new System.Drawing.Font("Arial", 11F);
            this.sex_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sex_label.Location = new System.Drawing.Point(20, 100);
            this.sex_label.Name = "sex_label";
            this.sex_label.Size = new System.Drawing.Size(320, 25);
            this.sex_label.TabIndex = 11;
            this.sex_label.Text = "Gender: ";
            // 
            // Education Labels
            // 
            this.jhs_label.Font = new System.Drawing.Font("Arial", 11F);
            this.jhs_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.jhs_label.Location = new System.Drawing.Point(20, 160);
            this.jhs_label.Name = "jhs_label";
            this.jhs_label.Size = new System.Drawing.Size(320, 40);
            this.jhs_label.TabIndex = 12;
            this.jhs_label.Text = "Junior High School";

            this.jhs_year_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.jhs_year_label.ForeColor = System.Drawing.Color.Gray;
            this.jhs_year_label.Location = new System.Drawing.Point(20, 200);
            this.jhs_year_label.Name = "jhs_year_label";
            this.jhs_year_label.Size = new System.Drawing.Size(320, 20);
            this.jhs_year_label.TabIndex = 13;
            this.jhs_year_label.Text = "Year Graduated";

            this.shs_label.Font = new System.Drawing.Font("Arial", 11F);
            this.shs_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shs_label.Location = new System.Drawing.Point(20, 250);
            this.shs_label.Name = "shs_label";
            this.shs_label.Size = new System.Drawing.Size(320, 40);
            this.shs_label.TabIndex = 14;
            this.shs_label.Text = "Senior High School";

            this.shs_year_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.shs_year_label.ForeColor = System.Drawing.Color.Gray;
            this.shs_year_label.Location = new System.Drawing.Point(20, 290);
            this.shs_year_label.Name = "shs_year_label";
            this.shs_year_label.Size = new System.Drawing.Size(320, 20);
            this.shs_year_label.TabIndex = 15;
            this.shs_year_label.Text = "Year Graduated";

            this.college_label.Font = new System.Drawing.Font("Arial", 11F);
            this.college_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.college_label.Location = new System.Drawing.Point(20, 340);
            this.college_label.Name = "college_label";
            this.college_label.Size = new System.Drawing.Size(320, 40);
            this.college_label.TabIndex = 16;
            this.college_label.Text = "College/University";

            this.college_year_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.college_year_label.ForeColor = System.Drawing.Color.Gray;
            this.college_year_label.Location = new System.Drawing.Point(20, 380);
            this.college_year_label.Name = "college_year_label";
            this.college_year_label.Size = new System.Drawing.Size(320, 20);
            this.college_year_label.TabIndex = 17;
            this.college_year_label.Text = "Year Graduated";
            // 
            // Right Panel (Career Info)
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Controls.Add(this.objectives_label);
            this.rightPanel.Controls.Add(this.company_name_label);
            this.rightPanel.Controls.Add(this.experience_label);
            this.rightPanel.Controls.Add(this.skills_label);
            this.rightPanel.Location = new System.Drawing.Point(400, 10);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(740, 600);
            this.rightPanel.TabIndex = 18;
            // 
            // Career Labels
            // 
            this.objectives_label.Font = new System.Drawing.Font("Arial", 12F);
            this.objectives_label.ForeColor = System.Drawing.Color.Black;
            this.objectives_label.Location = new System.Drawing.Point(20, 40);
            this.objectives_label.Name = "objectives_label";
            this.objectives_label.Size = new System.Drawing.Size(700, 80);
            this.objectives_label.TabIndex = 19;
            this.objectives_label.Text = "Career Objectives";

            this.company_name_label.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.company_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.company_name_label.Location = new System.Drawing.Point(20, 160);
            this.company_name_label.Name = "company_name_label";
            this.company_name_label.Size = new System.Drawing.Size(700, 30);
            this.company_name_label.TabIndex = 20;
            this.company_name_label.Text = "Company Name";

            this.experience_label.Font = new System.Drawing.Font("Arial", 12F);
            this.experience_label.ForeColor = System.Drawing.Color.Black;
            this.experience_label.Location = new System.Drawing.Point(20, 200);
            this.experience_label.Name = "experience_label";
            this.experience_label.Size = new System.Drawing.Size(700, 150);
            this.experience_label.TabIndex = 21;
            this.experience_label.Text = "Work Experience";

            this.skills_label.Font = new System.Drawing.Font("Arial", 12F);
            this.skills_label.ForeColor = System.Drawing.Color.Black;
            this.skills_label.Location = new System.Drawing.Point(20, 380);
            this.skills_label.Name = "skills_label";
            this.skills_label.Size = new System.Drawing.Size(700, 180);
            this.skills_label.TabIndex = 22;
            this.skills_label.Text = "Skills and Competencies";

            // Add controls to form
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.headerPanel.ResumeLayout(false);
            this.contactPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel contactPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
    }
}