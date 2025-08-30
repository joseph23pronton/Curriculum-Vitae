using Calculator;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            lblUserInfo.ForeColor = Color.White;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (Session.LoggedInUser != null)
            {
                lblUserInfo.Text = Session.LoggedInUser.Username;
            }
        }

        private void btnDagonio_Click(object sender, EventArgs e)
        {
            CV_FormD newCV_FormD = new CV_FormD();
            newCV_FormD.Show();
            this.Hide();
        }

        private void btnRoberto_Click(object sender, EventArgs e)
        {
            CV_Form2 newCV_Form1 = new CV_Form2();
            newCV_Form1.Show();
            this.Hide();
        }

        private void btnPadua_Click(object sender, EventArgs e)
        {
            CV_Form3 newCV_Form1 = new CV_Form3();
            newCV_Form1.Show();
            this.Hide();
        }

        private void btnPronton_Click(object sender, EventArgs e)
        {
            CV_Form4 newCV_Form1 = new CV_Form4();
            newCV_Form1.Show();
            this.Hide();
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

     

        private void button1_Click(object sender, EventArgs e)
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order_system order_System = new Order_system();
            order_System.Show();
            this.Hide();
        }
    }
}
