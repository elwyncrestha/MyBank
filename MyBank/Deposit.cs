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
    public partial class Deposit : Form
    {
        DepositBLL depositBLL = new DepositBLL();

        public Deposit()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (txtCustomerACNo.Text == "")
            {
                MessageBox.Show("Enter account number !!!");
                txtCustomerACNo.Focus();
                return;
            }
            else if (txtDepositAmount.Text == "")
            {
                MessageBox.Show("Enter deposit amount !!!");
                txtDepositAmount.Focus();
                return;
            }
            else {
                int customerACNo = int.Parse(txtCustomerACNo.Text);
                float depositBalance = float.Parse(txtDepositAmount.Text);

                bool customerStatus = depositBLL.validateCustomerByACNo(customerACNo);

                if (customerStatus)
                {
                    depositBLL.depositAmount(customerACNo, depositBalance);
                    txtCustomerACNo.Text = txtDepositAmount.Text = "";
                    txtDepositAmount.Enabled = false;
                }
                else {
                    MessageBox.Show("Invalid customer !!!");
                    txtCustomerACNo.Text = txtDepositAmount.Text = "";
                }
            }
        }

        private void txtCustomerACNo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerACNo.Text))
            {
                int customerACNo = int.Parse(txtCustomerACNo.Text);
                DataTable dataTable = depositBLL.getNamePhoneAddress(customerACNo);

                if (dataTable.Rows.Count > 0)
                {
                    lblCustomerName.Text = dataTable.Rows[0][0].ToString();
                    lblCustomerAddress.Text = dataTable.Rows[0][2].ToString();
                    lblCustomerPhone.Text = dataTable.Rows[0][1].ToString();
                    txtDepositAmount.Enabled = true;
                }
                else
                {
                    lblCustomerName.Text = lblCustomerAddress.Text = lblCustomerPhone.Text = "null";
                    txtDepositAmount.Enabled = false;
                }
            }
            else
            {
                lblCustomerName.Text = lblCustomerAddress.Text = lblCustomerPhone.Text = "null";
            }
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.displayDashboard();
            this.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            txtDepositAmount.Enabled = false;
        }
    }
}
