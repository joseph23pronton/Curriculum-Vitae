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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblUserInfo.ForeColor = Color.White;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Title Page";

            if (Session.LoggedInUser != null)
            {
                lblUserInfo.Text = Session.LoggedInUser.Username;
            }
        }

        private void lnkPronton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void lnkPadua_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void lnkRoberto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void lnkDagonio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Session.LoggedInUser = null;
            this.Hide();
            var login = new Login();
            login.Show();
        }
    }
}
