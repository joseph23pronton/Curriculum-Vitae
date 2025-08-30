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
    public partial class Login : Form
    {

        private List<User> users = new List<User>
        {
            new User("Pronton_joseph", "joseph001"),
            new User("Roberto_francis", "francis002"),
            new User("Dagonio_jamaeca", "jam003"),
            new User("Padua_julian", "julian004")
        };
        private bool isPasswordVisible = false;

     

        public Login()
        {
            InitializeComponent();
            

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {          
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Session.LoggedInUser = user;
                this.Hide();
                var form1 = new Form1(); 
                form1.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        

    }

        private void closePassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = false; // force hidden
            txtPassword.UseSystemPasswordChar = true;
            openPassword.BringToFront();
        }

        private void openPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = true; // force visible
            txtPassword.UseSystemPasswordChar = false;
            closePassword.BringToFront();
        }

    }
}
