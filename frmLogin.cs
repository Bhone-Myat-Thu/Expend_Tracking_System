using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_Project.Classes;

namespace Assignment_Project
{
    public partial class frmLogin : Form
    {

        User user = new User();

        public static string uname;
        public static int userid;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
                username.ForeColor = Color.DarkGray;
            }
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username" && username.ForeColor == Color.DarkGray)
            {
                username.Text = null;
                username.ForeColor = Color.Black;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password" && password.ForeColor == Color.DarkGray)
            {
                password.Text = null;
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
                password.ForeColor = Color.DarkGray;
                password.UseSystemPasswordChar = false;
            }
        }


        // show password button
        private void ckbPassShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPassShow.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            this.Hide();
            frmRegister.ShowDialog();
        }


        // register the user
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (user.loginUser(username.Text, password.Text))
            {
                uname = username.Text;
                userid = user.getUser(username.Text, password.Text);
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.ShowDialog();

            }
            else
            {
                MessageBox.Show("Username and Password not found.\nPlease check Username and Password.", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Text = "";
                password.Text = "";
            }
        }
    }
}
