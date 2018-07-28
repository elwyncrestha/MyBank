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
    public partial class ChangePinNumber : Form
    {
        ChangePinNumberBLL pinBLL = new ChangePinNumberBLL();

        public ChangePinNumber()
        {
            InitializeComponent();
        }

        private void btnPinChange_Click(object sender, EventArgs e)
        {
            if (txtCustomerACNo.Text == "")
            {
                MessageBox.Show("Enter account number !!!");
                txtCustomerACNo.Focus();
                return;
            }
            else if (txtOldPinNo.Text == "")
            {
                MessageBox.Show("Enter old pin number !!!");
                txtOldPinNo.Focus();
                return;
            }
            else if (txtNewPinNo.Text == "")
            {
                MessageBox.Show("Enter new pin number !!!");
                txtNewPinNo.Focus();
                return;
            }
            else if (txtConfirmNewPin.Text == "") {
                MessageBox.Show("Confirm your new pin number !!!");
            }
            else
            {
                int accountNo = int.Parse(txtCustomerACNo.Text);

                DepositBLL depositBLL = new DepositBLL();
                bool customerStatus = depositBLL.validateCustomerByACNo(accountNo);

                if (customerStatus)
                {
                    int oldPin = int.Parse(txtOldPinNo.Text);
                    bool pinStatus = pinBLL.validatePin(oldPin, accountNo);

                    if (pinStatus)
                    {
                        int newPin = int.Parse(txtNewPinNo.Text);
                        int confirmPin = int.Parse(txtConfirmNewPin.Text);

                        if (newPin == confirmPin)
                        {
                            pinBLL.updatePin(accountNo, newPin);
                            MessageBox.Show("Pin changed successfully" + "\nNew pin number: " + newPin);
                        }
                        else
                        {
                            MessageBox.Show("Pin number do not match !!!");
                            txtConfirmNewPin.Text = "";
                            txtConfirmNewPin.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong old pin number !!!");
                        txtOldPinNo.Text = "";
                        txtOldPinNo.Focus();
                        return;
                    }
                }
                else {
                    MessageBox.Show("Invalid customer account number !!!");
                    txtCustomerACNo.Text = txtOldPinNo.Text = txtNewPinNo.Text = txtConfirmNewPin.Text = "";
                    txtCustomerACNo.Focus();
                    return;
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
