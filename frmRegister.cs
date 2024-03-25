using Assignment_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Project
{
    public partial class frmRegister : Form
    {

        ExpenseTracker expensetracker = new ExpenseTracker();
        User user = new User();

        public frmRegister()
        {
            InitializeComponent();
            passwordChk.Text = "8 Chars Long and Contains \n1 Uppercase and 1 Lowercase";
        }



        private void Login_Load(object sender, EventArgs e)
        {
            usernameChk.Enabled = false;
            passwordChk.Enabled = false;           
        }

        // the warning message show when the username enter special character and white space 
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)){
                usernameChk.Visible = true;
                usernameChk.ForeColor = Color.Red;
                usernameChk.Enabled = true;
            }
            else
            {
                usernameChk.Visible = false;
            }
        }


        // validating for password which contain one uppercase character and one lowercase character
        private bool password_validate()
        {
            if (!Regex.IsMatch(password.Text, "[a-z]"))
            {
                return false;
            }
            else if (!Regex.IsMatch(password.Text, "[A-Z]"))
            {
                return false;
            }
            return true;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (password.ForeColor == Color.DarkGray || username.ForeColor == Color.DarkGray || confPass.ForeColor == Color.DarkGray)
            {
                MessageBox.Show("Cannot empty in username and password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (username.Text.Length == 0)
                {
                    MessageBox.Show("Cannot empty in username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (expensetracker.duplicateUser(username.Text) == 1)
                {
                    MessageBox.Show("This user already exists.\nPlease change the username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Login_Load(sender, e);
                    username.Text = "";
                    username.Select();
                }else if (password.Text != confPass.Text)
                {
                    MessageBox.Show("Password and Confirm Password are not same.\nPlease check again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (user.registerUser(username.Text, password.Text))
                    {
                        MessageBox.Show("Congratulations, your account \nhas been successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmLogin frmLogin = new frmLogin();
                        this.Hide();
                        frmLogin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Somethings gonna wrong.\nPlease check again.", "Fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPassShow.Checked)
            {
                password.UseSystemPasswordChar = false;
                confPass.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                confPass.UseSystemPasswordChar = true;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "" )
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

        private void confPass_Enter(object sender, EventArgs e)
        {
            if (confPass.Text == "Confirm Password" && confPass.ForeColor == Color.DarkGray)
            {
                confPass.Text = null;
                confPass.ForeColor = Color.Black;
                confPass.UseSystemPasswordChar = true;
            }
        }

        private void confPass_Leave(object sender, EventArgs e)
        {
            if (confPass.Text == "")
            {
                confPass.Text = "Confirm Password";
                confPass.ForeColor = Color.DarkGray;
                confPass.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsSymbol((char)e.KeyChar) || char.IsPunctuation((char)e.KeyChar)))
            {
                passwordChk.Visible = true;
                passwordChk.ForeColor = Color.Red;
                passwordChk.Enabled = true;
            }
            else
            {
                passwordChk.Visible = false;
            }
        }


        // the warning message shows when password is not valid and password length is lower than 8
        private void password_TextChanged(object sender, EventArgs e)
        {
            if ((password.Text.Length < 8) || (!password_validate()))
            {
                passwordChk.ForeColor = Color.Red;
                passwordChk.Visible = true;
                passwordChk.Enabled = true;
            }
            else
            {
                passwordChk.Visible = false;
            }
        }
    }
}
