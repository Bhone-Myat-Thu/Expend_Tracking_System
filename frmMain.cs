using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            btnEducation.Padding = new Padding(15, btnEducation.Padding.Top, btnEducation.Padding.Right, btnEducation.Padding.Bottom);
            btnSaving.Padding = new Padding(15, btnSaving.Padding.Top, btnSaving.Padding.Right, btnSaving.Padding.Bottom);
            btnTransporation.Padding = new Padding(8, btnTransporation.Padding.Top, btnTransporation.Padding.Right, btnTransporation.Padding.Bottom);
            btnHealth.Padding = new Padding(15, btnHealth.Padding.Top, btnHealth.Padding.Right, btnHealth.Padding.Bottom);
            btnLogout.Padding = new Padding(15, btnLogout.Padding.Top, btnLogout.Padding.Right, btnLogout.Padding.Bottom);
            btnBarchart.Padding = new Padding(15, btnBarchart.Padding.Top, btnBarchart.Padding.Right, btnBarchart.Padding.Bottom);
            btnHome.Padding = new Padding(15, btnHome.Padding.Top, btnHome.Padding.Right, btnHome.Padding.Bottom);
        }

        public void loadForm(object Form)
        {
            frmLogin frmLogin = new frmLogin();
            lblLogin.Text = frmLogin.uname;

            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            loadForm(new frmWelcome());
            lblTitle.Visible = false;
        }

        private void btnEducation_Click(object sender, EventArgs e)
        {
            loadForm(new frmEducation());
            lblTitle.Visible = true;
            lblTitle.Text = "Education Expense";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadForm(new frmWelcome());
            lblTitle.Visible = false;
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            loadForm(new frmHealth());
            lblTitle.Visible = true;
            lblTitle.Text = "Health Expense";
        }

        private void btnSaving_Click(object sender, EventArgs e)
        {
            loadForm(new frmSaving());
            lblTitle.Visible = true;
            lblTitle.Text = "Saving Expense";
        }

        private void btnTransporation_Click(object sender, EventArgs e)
        {
            loadForm(new frmTransportation());
            lblTitle.Visible = true;
            lblTitle.Text = "Transporation Expense";
        }

        private void btnBarchart_Click(object sender, EventArgs e)
        {
            loadForm(new frmBarchart());
            lblTitle.Visible = false;
            lblTitle.Text = "Barchart";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Ask the user if they really want to exit
                DialogResult result = MessageBox.Show("Do you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user chooses not to exit, cancel the form closing
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
