using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSimulation
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username=txtUsername.Text.Trim();
            string password=txtPassword.Text.Trim();

            if(username == ""||password=="")
            {
                MessageBox.Show("Please Fill in both fields.");
                return;
            }
            if(UserManager.Register(username,password))
            {
                MessageBox.Show("Registration Successful! You can now log in.");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }else
            {
                MessageBox.Show("Username already exists. Try another.");
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
