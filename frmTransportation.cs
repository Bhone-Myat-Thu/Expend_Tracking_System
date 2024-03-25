using Assignment_Project.Classes;
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
    public partial class frmTransportation : Form
    {

        //DBCONNECTOR con = new DBCONNECTOR();
        ExpenseCategory expcat = new ExpenseCategory();
        //frmLogin frmLogin = new frmLogin();
        int uid = frmLogin.userid;
        int eid;


        public frmTransportation()
        {
            InitializeComponent();
            cbxMonth.SelectedIndex = 0;
            cbxPayment.SelectedIndex = 0;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            btnAdd.Padding = new Padding(15, btnAdd.Padding.Top, btnAdd.Padding.Right, btnAdd.Padding.Bottom);
            btnDelete.Padding = new Padding(8, btnDelete.Padding.Top, btnDelete.Padding.Right, btnDelete.Padding.Bottom);
            btnUpdate.Padding = new Padding(8, btnUpdate.Padding.Top, btnUpdate.Padding.Right, btnUpdate.Padding.Bottom);
            btnRefresh.Padding = new Padding(15, btnRefresh.Padding.Top, btnRefresh.Padding.Right, btnRefresh.Padding.Bottom);
        }

        private void frmTransportation_Load(object sender, EventArgs e)
        {
            dgvPanel.DataSource = expcat.retrieveExpense(uid, "Transporation"); 
            dgvPanel.ReadOnly = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmTransportation_Load(sender, e);
            txtCost.Clear();
            txtDesc.Clear();
            cbxMonth.SelectedIndex = 0;
            cbxPayment.SelectedIndex = 0;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCost.Text))
            {
                if (expcat.addExpense(cbxMonth.Text, Convert.ToInt32(txtCost.Text), cbxPayment.Text, txtDesc.Text, "Transporation", uid))
                {
                    MessageBox.Show("Successfully Added Data", "Add Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefresh_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please add cost", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (expcat.deleteExpense(eid))
            {
                MessageBox.Show("Successfully Deleted Data", "Delete Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefresh_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (expcat.updateExpense(cbxMonth.Text, Convert.ToInt32(txtCost.Text), cbxPayment.Text, txtDesc.Text, "Transporation", eid))
            {
                MessageBox.Show("Successfully Updated Data", "Update Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefresh_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dgvPanel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPanel.CurrentRow.Cells[0].Value.ToString().Equals(""))
            {
                MessageBox.Show("Please select above cells.");
            }
            else
            {
                cbxMonth.Text = dgvPanel.CurrentRow.Cells[1].Value.ToString();
                cbxPayment.Text = dgvPanel.CurrentRow.Cells[2].Value.ToString();
                txtCost.Text = dgvPanel.CurrentRow.Cells[3].Value.ToString();
                txtDesc.Text = dgvPanel.CurrentRow.Cells[4].Value.ToString();
                eid = Convert.ToInt32(dgvPanel.CurrentRow.Cells[0].Value);
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }


        // make the cost text box ony accept number
        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
