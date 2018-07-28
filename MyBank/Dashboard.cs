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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new MyBank.Customer();
            customer.ShowDialog();
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit deposit = new Deposit();
            deposit.ShowDialog();
            this.Close();
        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePinNumber changePinNumber = new ChangePinNumber();
            changePinNumber.ShowDialog();
            this.Close();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions transactions = new Transactions();
            transactions.ShowDialog();
            this.Close();
        }

        
    }
}
