using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBank
{
    public partial class Customer : Form
    {
        CustomerBLL customerBLL = new CustomerBLL();

        public Customer()
        {
            InitializeComponent();
        }

        public void loadCustomerDGV() {
            DataTable dataTable = customerBLL.displayAllCustomer();
            dgvCustomer.DataSource = dataTable;
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (btnCustomerAdd.Text == "Add")
            {
                if (txtCustomerFName.Text == "")
                {
                    MessageBox.Show("Enter first name !!!");
                    txtCustomerFName.Focus();
                    return;
                }
                else if (txtCustomerLName.Text == "")
                {
                    MessageBox.Show("Enter last name !!!");
                    txtCustomerLName.Focus();
                    return;
                }
                else if (txtCustomerAddress.Text == "")
                {
                    MessageBox.Show("Enter address !!!");
                    txtCustomerAddress.Focus();
                    return;
                }
                else if (rdoMale.Checked == false && rdoFemale.Checked == false && rdoOthers.Checked == false)
                {
                    MessageBox.Show("Choose your gender !!!");
                    rdoMale.Focus();
                    return;
                }
                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Enter phone number !!!");
                    txtPhone.Focus();
                    return;
                }
                else
                {
                    customerBLL.FirstName = txtCustomerFName.Text;
                    customerBLL.LastName = txtCustomerLName.Text;
                    customerBLL.Address = txtCustomerAddress.Text;
                    if (rdoMale.Checked)
                    {
                        customerBLL.Gender = 'M';
                    }
                    else if (rdoFemale.Checked)
                    {
                        customerBLL.Gender = 'F';
                    }
                    else if (rdoOthers.Checked)
                    {
                        customerBLL.Gender = 'O';
                    }
                    customerBLL.Dob = dtpCustomerDOB.Text;
                    customerBLL.PhoneNumber = txtPhone.Text;
                    customerBLL.AccountNo = customerBLL.generateACNo();
                    customerBLL.PinNo = customerBLL.generatePin();

                    customerBLL.addCustomer();

                    MessageBox.Show("Your account number: " + customerBLL.AccountNo + "\nPin number: " + customerBLL.PinNo);
                    loadCustomerDGV();
                }
            }
            else if (btnCustomerAdd.Text == "Update") {
                if (txtCustomerFName.Text == "")
                {
                    MessageBox.Show("Enter first name !!!");
                    txtCustomerFName.Focus();
                    return;
                }
                else if (txtCustomerLName.Text == "")
                {
                    MessageBox.Show("Enter last name !!!");
                    txtCustomerLName.Focus();
                    return;
                }
                else if (txtCustomerAddress.Text == "")
                {
                    MessageBox.Show("Enter address !!!");
                    txtCustomerAddress.Focus();
                    return;
                }
                else if (rdoMale.Checked == false && rdoFemale.Checked == false && rdoOthers.Checked == false)
                {
                    MessageBox.Show("Choose your gender !!!");
                    rdoMale.Focus();
                    return;
                }
                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Enter phone number !!!");
                    txtPhone.Focus();
                    return;
                }
                else
                {
                    customerBLL.FirstName = txtCustomerFName.Text;
                    customerBLL.LastName = txtCustomerLName.Text;
                    customerBLL.Address = txtCustomerAddress.Text;
                    if (rdoMale.Checked)
                    {
                        customerBLL.Gender = 'M';
                    }
                    else if (rdoFemale.Checked)
                    {
                        customerBLL.Gender = 'F';
                    }
                    else if (rdoOthers.Checked)
                    {
                        customerBLL.Gender = 'O';
                    }
                    customerBLL.Dob = dtpCustomerDOB.Text;
                    customerBLL.PhoneNumber = txtPhone.Text;

                    customerBLL.updateCustomer(cusCode);
                    
                    loadCustomerDGV();
                    btnCustomerAdd.Text = "Add";
                }
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            loadCustomerDGV();
        }

        int cusCode;
        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            int columnIndex = dgvCustomer.CurrentCell.ColumnIndex;
            cusCode = int.Parse(dgvCustomer.CurrentRow.Cells["customerId"].Value.ToString());

            if (dgvCustomer.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                btnCustomerAdd.Text = "Update";
                DataTable dataTable = customerBLL.getCustomerById(cusCode);

                txtCustomerFName.Text = dataTable.Rows[0][0].ToString();
                txtCustomerLName.Text = dataTable.Rows[0][1].ToString();
                txtCustomerAddress.Text = dataTable.Rows[0][2].ToString();
                char gender = char.Parse(dataTable.Rows[0][3].ToString().ToString());
                if (gender == 'M')
                {
                    rdoMale.Focus();
                }
                else if (gender == 'F')
                {
                    rdoFemale.Focus();
                }
                else if (gender == 'O')
                {
                    rdoOthers.Focus();
                }
                dtpCustomerDOB.Text = dataTable.Rows[0][4].ToString();
                txtPhone.Text = dataTable.Rows[0][5].ToString();

            }
            else if (dgvCustomer.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    customerBLL.deleteCustomer(cusCode);
                    txtCustomerFName.Text = txtCustomerLName.Text = txtCustomerAddress.Text = txtPhone.Text = "";
                    loadCustomerDGV();
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.displayDashboard();
            this.Close();
        }
    }
}
