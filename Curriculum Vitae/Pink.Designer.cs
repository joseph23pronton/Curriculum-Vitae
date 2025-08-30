using System.Drawing;
using System.Windows.Forms;

namespace Curriculum_Vitae
{
    partial class Pink
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pink));
            this.full_name_text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.phonenumber_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.email_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.objective_text = new System.Windows.Forms.Label();
            this.objectives_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.skills_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.college_label = new System.Windows.Forms.Label();
            this.college_year_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.shs_label = new System.Windows.Forms.Label();
            this.shs_year_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jhs_label = new System.Windows.Forms.Label();
            this.jhs_year_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.company_name_label = new System.Windows.Forms.Label();
            this.experience_label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.birthday_label = new System.Windows.Forms.Label();
            this.nationality_label = new System.Windows.Forms.Label();
            this.sex_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // full_name_text
            // 
            this.full_name_text.AutoSize = true;
            this.full_name_text.BackColor = System.Drawing.Color.HotPink;
            this.full_name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_name_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.full_name_text.Location = new System.Drawing.Point(320, 43);
            this.full_name_text.Name = "full_name_text";
            this.full_name_text.Size = new System.Drawing.Size(627, 54);
            this.full_name_text.TabIndex = 22;
            this.full_name_text.Text = "Joseph Benedict V. Pronton";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.HotPink;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1136, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // phonenumber_label
            // 
            this.phonenumber_label.AutoSize = true;
            this.phonenumber_label.BackColor = System.Drawing.Color.HotPink;
            this.phonenumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumber_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.phonenumber_label.Location = new System.Drawing.Point(395, 123);
            this.phonenumber_label.Name = "phonenumber_label";
            this.phonenumber_label.Size = new System.Drawing.Size(145, 24);
            this.phonenumber_label.TabIndex = 12;
            this.phonenumber_label.Text = "0905-558-2903";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(43, 43);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 226);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 53);
            this.panel1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(16, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Education";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.HotPink;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(335, 114);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(55, 46);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.HotPink;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(335, 166);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(55, 46);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox12.TabIndex = 25;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.HotPink;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(335, 219);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(55, 46);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox13.TabIndex = 26;
            this.pictureBox13.TabStop = false;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.BackColor = System.Drawing.Color.HotPink;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.email_label.Location = new System.Drawing.Point(395, 175);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(225, 24);
            this.email_label.TabIndex = 27;
            this.email_label.Text = "ganbaruby@gmail.com";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.BackColor = System.Drawing.Color.HotPink;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.address_label.Location = new System.Drawing.Point(395, 228);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(322, 24);
            this.address_label.TabIndex = 28;
            this.address_label.Text = "123. Camarin, Caloocan City 1400";
            // 
            // objective_text
            // 
            this.objective_text.AutoSize = true;
            this.objective_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.objective_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objective_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.objective_text.Location = new System.Drawing.Point(3, 6);
            this.objective_text.Name = "objective_text";
            this.objective_text.Size = new System.Drawing.Size(137, 29);
            this.objective_text.TabIndex = 13;
            this.objective_text.Text = "Objectives";
            // 
            // objectives_label
            // 
            this.objectives_label.AutoSize = true;
            this.objectives_label.BackColor = System.Drawing.Color.White;
            this.objectives_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectives_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.objectives_label.Location = new System.Drawing.Point(443, 417);
            this.objectives_label.Name = "objectives_label";
            this.objectives_label.Size = new System.Drawing.Size(600, 24);
            this.objectives_label.TabIndex = 29;
            this.objectives_label.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer ";
            this.objectives_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(201)))));
            this.panel2.Controls.Add(this.skills_label);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.college_label);
            this.panel2.Controls.Add(this.college_year_label);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.shs_label);
            this.panel2.Controls.Add(this.shs_year_label);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.jhs_label);
            this.panel2.Controls.Add(this.jhs_year_label);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-1, 292);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 1227);
            this.panel2.TabIndex = 31;
            // 
            // skills_label
            // 
            this.skills_label.AutoSize = true;
            this.skills_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(201)))));
            this.skills_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skills_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skills_label.Location = new System.Drawing.Point(19, 502);
            this.skills_label.Name = "skills_label";
            this.skills_label.Size = new System.Drawing.Size(155, 24);
            this.skills_label.TabIndex = 44;
            this.skills_label.Text = "Communication";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(0, 432);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 53);
            this.panel3.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label15.Location = new System.Drawing.Point(16, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 29);
            this.label15.TabIndex = 13;
            this.label15.Text = "Skills";
            // 
            // college_label
            // 
            this.college_label.AutoSize = true;
            this.college_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(201)))));
            this.college_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.college_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.college_label.Location = new System.Drawing.Point(19, 382);
            this.college_label.Name = "college_label";
            this.college_label.Size = new System.Drawing.Size(139, 24);
            this.college_label.TabIndex = 41;
            this.college_label.Text = "College School";
            // 
            // college_year_label
            // 
            this.college_year_label.AutoSize = true;
            this.college_year_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(201)))));
            this.college_year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.college_year_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.college_year_label.Location = new System.Drawing.Point(328, 332);
            this.college_year_label.Name = "college_year_label";
            this.college_year_label.Size = new System.Drawing.Size(54, 24);
            this.college_year_label.TabIndex = 42;
            this.college_year_label.Text = "2025";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(201)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label14.Location = new System.Drawing.Point(19, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 24);
            this.label14.TabIndex = 40;
            this.label14.Text = "College";
            // 
            // shs_label
            // 
            this.shs_label.AutoSize = true;
            this.shs_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(201)))));
            this.shs_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shs_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.shs_label.Location = new System.Drawing.Point(19, 273);
            this.shs_label.Name = "shs_label";
            this.shs_label.Size = new System.Drawing.Size(174, 24);
            this.shs_label.TabIndex = 38;
            this.shs_label.Text = "Senior High School";
            // 
            // shs_year_label
            // 
            this.shs_year_label.AutoSize = true;
            this.shs_year_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(201)))));
            this.shs_year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shs_year_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.shs_year_label.Location = new System.Drawing.Point(328, 224);
            this.shs_year_label.Name = "shs_year_label";
            this.shs_year_label.Size = new System.Drawing.Size(54, 24);
            this.shs_year_label.TabIndex = 39;
            this.shs_year_label.Text = "2025";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(201)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(19, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Junior High School";
            // 
            // jhs_label
            // 
            this.jhs_label.AutoSize = true;
            this.jhs_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(201)))));
            this.jhs_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jhs_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.jhs_label.Location = new System.Drawing.Point(19, 164);
            this.jhs_label.Name = "jhs_label";
            this.jhs_label.Size = new System.Drawing.Size(233, 24);
            this.jhs_label.TabIndex = 36;
            this.jhs_label.Text = "Bading Elementary School";
            // 
            // jhs_year_label
            // 
            this.jhs_year_label.AutoSize = true;
            this.jhs_year_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(201)))));
            this.jhs_year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jhs_year_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.jhs_year_label.Location = new System.Drawing.Point(331, 119);
            this.jhs_year_label.Name = "jhs_year_label";
            this.jhs_year_label.Size = new System.Drawing.Size(54, 24);
            this.jhs_year_label.TabIndex = 37;
            this.jhs_year_label.Text = "2001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(201)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(19, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Senior High School";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.panel4.Controls.Add(this.objective_text);
            this.panel4.Location = new System.Drawing.Point(439, 342);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(669, 53);
            this.panel4.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.panel5.Controls.Add(this.label21);
            this.panel5.Location = new System.Drawing.Point(439, 580);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(669, 53);
            this.panel5.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label21.Location = new System.Drawing.Point(3, 7);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(212, 29);
            this.label21.TabIndex = 13;
            this.label21.Text = "Work Experience";
            // 
            // company_name_label
            // 
            this.company_name_label.AutoSize = true;
            this.company_name_label.BackColor = System.Drawing.Color.White;
            this.company_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.company_name_label.Location = new System.Drawing.Point(444, 655);
            this.company_name_label.Name = "company_name_label";
            this.company_name_label.Size = new System.Drawing.Size(111, 24);
            this.company_name_label.TabIndex = 39;
            this.company_name_label.Text = "Concentrix";
            // 
            // experience_label
            // 
            this.experience_label.AutoSize = true;
            this.experience_label.BackColor = System.Drawing.Color.White;
            this.experience_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experience_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.experience_label.Location = new System.Drawing.Point(445, 690);
            this.experience_label.Name = "experience_label";
            this.experience_label.Size = new System.Drawing.Size(535, 24);
            this.experience_label.TabIndex = 40;
            this.experience_label.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.HotPink;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(861, 175);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.HotPink;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(861, 114);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // birthday_label
            // 
            this.birthday_label.AutoSize = true;
            this.birthday_label.BackColor = System.Drawing.Color.HotPink;
            this.birthday_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.birthday_label.Location = new System.Drawing.Point(921, 123);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(169, 24);
            this.birthday_label.TabIndex = 52;
            this.birthday_label.Text = "October 12, 2003";
            // 
            // nationality_label
            // 
            this.nationality_label.AutoSize = true;
            this.nationality_label.BackColor = System.Drawing.Color.HotPink;
            this.nationality_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationality_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nationality_label.Location = new System.Drawing.Point(921, 182);
            this.nationality_label.Name = "nationality_label";
            this.nationality_label.Size = new System.Drawing.Size(100, 24);
            this.nationality_label.TabIndex = 53;
            this.nationality_label.Text = "Japanese";
            // 
            // sex_label
            // 
            this.sex_label.AutoSize = true;
            this.sex_label.BackColor = System.Drawing.Color.HotPink;
            this.sex_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sex_label.Location = new System.Drawing.Point(921, 228);
            this.sex_label.Name = "sex_label";
            this.sex_label.Size = new System.Drawing.Size(55, 24);
            this.sex_label.TabIndex = 54;
            this.sex_label.Text = "Male";
            // 
            // Pink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1136, 1055);
            this.Controls.Add(this.sex_label);
            this.Controls.Add(this.nationality_label);
            this.Controls.Add(this.birthday_label);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.experience_label);
            this.Controls.Add(this.company_name_label);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.objectives_label);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.full_name_text);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.phonenumber_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pink";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Pink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
        private Label full_name_text;
        private PictureBox pictureBox1;
        private Label phonenumber_label;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox7;
        private Label address_label;
        private Label email_label;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private Label objective_text;
        private Label objectives_label;
        private Panel panel2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label jhs_label;
        private Label jhs_year_label;
        private Label shs_label;
        private Label shs_year_label;
        private Label college_label;
        private Label college_year_label;
        private Label label14;
        private Panel panel3;
        private Label label15;
        private Panel panel4;
        private Label skills_label;
        private Panel panel5;
        private Label label21;
        private Label company_name_label;
        private Label experience_label;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label birthday_label;
        private Label nationality_label;
        private Label sex_label;
    }
}