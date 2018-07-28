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
    public partial class Transactions : Form
    {
        TransactionBLL transactionBLL = new TransactionBLL();

        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            //buttonDisable
            btnBalance.Enabled = btnWithdraw.Enabled = btnWithdrawReceipt.Enabled = false;
            txtPinNum.Enabled = false;
            txtWithdrawAmount.Enabled = false;
            txtWithdrawReceiptAmount.Enabled = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.displayDashboard();
            this.Close();
        }

        //A/C no and pin no login
        int pin;
        int acNo;

        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNo.Text))
            {
                txtAccountNo.Text = "";
            } 
            else if(txtAccountNo.Text.Length > 5)
            {
                MessageBox.Show("Number limit exceeded");
                txtAccountNo.Text = "";
                txtAccountNo.Focus();
                return;
            }
            else
            {
                acNo = int.Parse(txtAccountNo.Text);
                CustomerBLL customerBLL = new CustomerBLL();
                DataTable dataTable = customerBLL.getCustomerByAC(acNo);

                if (dataTable.Rows.Count > 0)
                {
                    txtAccountNo.Enabled = false;
                    txtPinNum.Enabled = true;
                    txtPinNum.Focus();
                    return;
                }
            }
        }

        private void txtPinNum_TextChanged(object sender, EventArgs e)
        {
            if (txtPinNum.Text.Length == 4)
            {
                pin = int.Parse(txtPinNum.Text);

                ChangePinNumberBLL pinBLL = new ChangePinNumberBLL();
                bool customerStatus = pinBLL.validatePin(pin, acNo);

                if (customerStatus)
                { 
                    //atm button enable
                    btnBalance.Enabled = btnWithdraw.Enabled = btnWithdrawReceipt.Enabled = true;

                    panMoney.Controls.Clear();

                    txtAccountNo.Enabled = txtPinNum.Enabled = false;
                    Label lblIntro = new Label();
                    lblIntro.Name = "lblIntro";
                    lblIntro.Text = "Please \n\nselect \n\nan \n\naction !!!";
                    lblIntro.Location = new Point(70, 55);
                    lblIntro.AutoSize = true;
                    lblIntro.Font = new Font("Georgia", 16F);
                    panMoney.Controls.Add(lblIntro);
                }
                else
                {
                    MessageBox.Show("Please enter correct information !!!");
                    txtAccountNo.Text = txtPinNum.Text = "";
                    txtAccountNo.Enabled = true;
                    txtPinNum.Enabled = false;
                    txtAccountNo.Focus();
                    return;
                }
            }
        }

        

        //ATM 1st button
        private void btnBalance_Click(object sender, EventArgs e)
        {
            panMoney.Controls.Clear();
            panMoney.Controls.Add(lblHeading);

            //lblBalance
            Label lblBalance = new Label();
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Georgia", 14F);
            lblBalance.Name = "lblBalance";
            lblBalance.Text = "Available balance is:\n"  + transactionBLL.getBalance(acNo,pin);
            lblBalance.Location = new Point(22, 66);
            panMoney.Controls.Add(lblBalance);

            //lblBalanceAmount
            Label lblBalanceAmount = new Label();
            lblBalanceAmount.AutoSize = true;
            lblBalanceAmount.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblBalanceAmount.Name = "lblBalanceAmount";
            lblBalanceAmount.Text = "0";
            lblBalanceAmount.Location = new Point(22, 86);
            panMoney.Controls.Add(lblBalanceAmount);
        }

        //ATM 2nd button
        TextBox txtWithdrawAmount = new TextBox();
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            panMoney.Controls.Clear();
            panMoney.Controls.Add(lblHeading);

            txtWithdrawAmount.Enabled = true;
            //lblWithdrawDetails
            Label lblWithdrawDetails = new Label();
            lblWithdrawDetails.Text = "Enter withdraw amount !!!";
            lblWithdrawDetails.Location = new Point(22, 66);
            lblWithdrawDetails.AutoSize = true;
            lblWithdrawDetails.Font = new Font("Georgia", 12F);
            panMoney.Controls.Add(lblWithdrawDetails);

            //txtWithdrawAmount
            txtWithdrawAmount.Name = "txtWithdrawAmount";
            txtWithdrawAmount.Location = new Point(22, 87);
            txtWithdrawAmount.Size = new Size(197, 20);
            txtWithdrawAmount.PasswordChar = '*';
            txtWithdrawAmount.TabIndex = 1;
            txtWithdrawAmount.BackColor = System.Drawing.Color.White;
            txtWithdrawAmount.ForeColor = System.Drawing.Color.DimGray;
            panMoney.Controls.Add(txtWithdrawAmount);
            txtWithdrawAmount.Text = "";

            //btnWithdrawAmount
            Button btnWithdrawAmount = new Button();
            btnWithdrawAmount.BackColor = System.Drawing.Color.LightGray;
            btnWithdrawAmount.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnWithdrawAmount.Location = new System.Drawing.Point(22, 130);
            btnWithdrawAmount.Name = "btnWithdrawAmount";
            btnWithdrawAmount.Size = new System.Drawing.Size(120, 30);
            btnWithdrawAmount.TabIndex = 2;
            btnWithdrawAmount.Text = "Withdraw";
            btnWithdrawAmount.UseVisualStyleBackColor = false;
            btnWithdrawAmount.Click += new EventHandler(btnWithdrawAmount_Click);
            panMoney.Controls.Add(btnWithdrawAmount);
        }

        //ATM 2nd button - dynamic btn
        private void btnWithdrawAmount_Click(object sender, EventArgs e) {
            txtWithdrawAmount.Enabled = true;
            if (txtWithdrawAmount.Text == "")
            {
                MessageBox.Show("Please enter withdraw amount !!!");
                txtWithdrawAmount.Focus();
                return;
            }
            else {
                float oldBalance = float.Parse(transactionBLL.getBalance(acNo, pin));
                float withdrawAmount = float.Parse(txtWithdrawAmount.Text);

                if (oldBalance < withdrawAmount)
                {
                    MessageBox.Show("You do not have enough balance to withdraw !!!");
                }
                else
                {
                    transactionBLL.withdrawAmount(acNo, pin, withdrawAmount);
                    MessageBox.Show("Withdraw amount: " + withdrawAmount + "\nRemaining balance: " + transactionBLL.getBalance(acNo, pin));
                    txtWithdrawAmount.Text = "";
                }
            }
        }

        //ATM 3rd button
        TextBox txtWithdrawReceiptAmount = new TextBox();
        private void btnWithdrawReceipt_Click(object sender, EventArgs e)
        {
            /*  this event (btnWithdrawReceipt_Click) is same as that with event (btnWithdraw_Click).
                However, code was repeated because withdraw button click event is different.
             */

            panMoney.Controls.Clear();
            panMoney.Controls.Add(lblHeading);

            txtWithdrawAmount.Enabled = false;
            txtWithdrawReceiptAmount.Enabled = true;
            txtWithdrawReceiptAmount.Text = "";
            txtWithdrawAmount.Focus();
            //lblWithdrawReceiptDetails
            Label lblWithdrawReceiptDetails = new Label();
            lblWithdrawReceiptDetails.Text = "Enter withdraw amount !!!";
            lblWithdrawReceiptDetails.Location = new Point(22, 66);
            lblWithdrawReceiptDetails.AutoSize = true;
            lblWithdrawReceiptDetails.Font = new Font("Georgia", 12F);
            panMoney.Controls.Add(lblWithdrawReceiptDetails);


            //txtWithdrawReceiptAmount
            txtWithdrawReceiptAmount.Name = "txtWithdrawAmount";
            txtWithdrawReceiptAmount.Location = new Point(22, 87);
            txtWithdrawReceiptAmount.Size = new Size(197, 20);
            txtWithdrawReceiptAmount.PasswordChar = '*';
            txtWithdrawReceiptAmount.TabIndex = 1;
            txtWithdrawReceiptAmount.BackColor = System.Drawing.Color.White;
            txtWithdrawReceiptAmount.ForeColor = System.Drawing.Color.DimGray;
            panMoney.Controls.Add(txtWithdrawReceiptAmount);
            txtWithdrawAmount.Text = "";

            //btnWithdrawReceiptAmount
            Button btnWithdrawReceiptAmount = new Button();
            btnWithdrawReceiptAmount.BackColor = System.Drawing.Color.LightGray;
            btnWithdrawReceiptAmount.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnWithdrawReceiptAmount.Location = new System.Drawing.Point(22, 130);
            btnWithdrawReceiptAmount.Name = "btnWithdrawAmount";
            btnWithdrawReceiptAmount.Size = new System.Drawing.Size(120, 30);
            btnWithdrawReceiptAmount.TabIndex = 2;
            btnWithdrawReceiptAmount.Text = "Withdraw";
            btnWithdrawReceiptAmount.UseVisualStyleBackColor = false;
            btnWithdrawReceiptAmount.Click += new EventHandler(generateReceipt_Click);
            panMoney.Controls.Add(btnWithdrawReceiptAmount);
        }

        //generateReceipt_Click EventHandler
        private void generateReceipt_Click(object sender, EventArgs e) {
            if (txtWithdrawReceiptAmount.Text == "")
            {
                MessageBox.Show("Please enter withdraw amount !!!");
                txtWithdrawAmount.Focus();
                return;
            }
            else
            {
                float oldBalance = float.Parse(transactionBLL.getBalance(acNo, pin));
                float withdrawAmount = float.Parse(txtWithdrawReceiptAmount.Text);

                if (oldBalance < withdrawAmount)
                {
                    MessageBox.Show("You do not have enough balance to withdraw !!!");
                }
                else
                {
                    transactionBLL.withdrawAmount(acNo, pin, withdrawAmount);
                    DataTable dataTable = transactionBLL.getReceiptInfo(acNo,"Withdraw");
                    String name = dataTable.Rows[0][0].ToString();
                    String address = dataTable.Rows[0][1].ToString();
                    String gender = dataTable.Rows[0][2].ToString();
                    String dob = dataTable.Rows[0][3].ToString();
                    String phone = dataTable.Rows[0][4].ToString();
                    String acNum = dataTable.Rows[0][5].ToString();
                    String balance = dataTable.Rows[0][6].ToString();
                    String transactionDate = dataTable.Rows[0][7].ToString();
                    String transactionStatus = dataTable.Rows[0][8].ToString();
                    String withdraw = withdrawAmount.ToString();

                    this.Hide();
                    Receipt receipt = new Receipt(name, address, gender, dob, phone, acNum, balance, withdraw, transactionStatus, transactionDate);
                    receipt.ShowDialog();
                    this.Close();
                    txtWithdrawAmount.Text = "";
                }
            }
        }


        //ATM PINS CODES starts here
        private void btnPins_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (txtAccountNo.Enabled == true)
            {
                txtAccountNo.Text = txtAccountNo.Text + button.Text;
            }
            else if (txtPinNum.Enabled == true)
            {   
                txtPinNum.Text = txtPinNum.Text + button.Text;
            }
            else if (txtWithdrawAmount.Enabled == true)
            {
                txtWithdrawAmount.Text = txtWithdrawAmount.Text + button.Text;
            }
            else if (txtWithdrawReceiptAmount.Enabled == true)
            {    
                txtWithdrawReceiptAmount.Text = txtWithdrawReceiptAmount.Text + button.Text;
            }
        }

        

        private void btnA_Click(object sender, EventArgs e)
        {
            if (txtAccountNo.Enabled == true)
            {
                txtAccountNo.Text = "";
                txtAccountNo.Focus();
                return;
            }
            else if (txtPinNum.Enabled == true)
            {
                txtPinNum.Text = "";
                txtPinNum.Focus();
                return;
            }
            else if (txtWithdrawAmount.Enabled == true)
            {
                txtWithdrawAmount.Text = "";
                txtWithdrawAmount.Focus();
                return;
            }
            else if (txtWithdrawReceiptAmount.Enabled == true)
            {
                txtWithdrawReceiptAmount.Text = "";
                txtWithdrawReceiptAmount.Focus();
                return;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtAccountNo.Enabled == true)
            {
                String accountNum = getSubString(txtAccountNo.Text);
                txtAccountNo.Text = accountNum;
                txtAccountNo.Text = accountNum;
                txtAccountNo.Focus();
                return;
            }
            else if (txtPinNum.Enabled == true)
            {
                String pinNum = getSubString(txtPinNum.Text);
                txtPinNum.Text = pinNum;
                txtPinNum.Focus();
                return;
            }
            else if (txtWithdrawAmount.Enabled == true)
            {
                String withdrawAmount = getSubString(txtWithdrawAmount.Text);
                txtWithdrawAmount.Text = withdrawAmount;
                txtWithdrawAmount.Focus();
                return;
            }
            else if (txtWithdrawReceiptAmount.Enabled == true)
            {
                String withdrawReceiptAmount = getSubString(txtWithdrawReceiptAmount.Text);
                txtWithdrawReceiptAmount.Text = withdrawReceiptAmount;
                txtWithdrawReceiptAmount.Focus();
                return;
            }
        }
        //ATM PINS CODES finishes here

        public String getSubString(String stringValue)
        {
            stringValue = stringValue.Substring(0, stringValue.Length - 1);
            return stringValue;
        }
    }
}
