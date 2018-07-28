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
    public partial class Receipt : Form
    {
        private String fullName;
        private String address;
        private String gender;
        private String dob;
        private String phoneNumber;
        private String accountNo;
        private String balance;
        private String withdraw;
        private String transactionType;
        private String transactionDate;

        public Receipt(String fullName, String address, String gender, String dob, String phone, String accountNo, String balance, String withdraw, String transactionType, String transactionDate)
        {
            this.fullName = fullName;
            this.address = address;
            this.gender = gender;
            this.dob = dob;
            this.phoneNumber = phone;
            this.accountNo = accountNo;
            this.balance = balance;
            this.withdraw = withdraw;
            this.transactionType = transactionType;
            this.transactionDate = transactionDate;
            InitializeComponent();
        }
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            lblFullName.Text = fullName;
            lblAddress.Text = address;
            lblGender.Text = gender;
            lblDOB.Text = dob;
            lblPhone.Text = phoneNumber;
            lblACNo.Text = accountNo;
            lblRemaining.Text = balance;
            lblWithdrawAmount.Text = withdraw;
            lblTransactionType.Text = transactionType;
            lblTransactionDate.Text = transactionDate;
        }
    }
}
