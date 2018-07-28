using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class TransactionBLL
    {
        DbConnection dbConnection = new DbConnection();

        public String getBalance(int acNo, int pin) {
            String sql = "select customerBalance from Customer where customerACNo = " + acNo + " and customerPin = " + pin;
            DataTable dataTable = dbConnection.retrieve(sql);
            String customerBalance = dataTable.Rows[0][0].ToString();
            return customerBalance;
        }

        public void withdrawAmount(int acNo, int pin, float amount) {
            String sql = "update Customer set customerBalance = customerBalance - " + amount + " where customerACNo = " + acNo + " and customerPin = " + pin;
            dbConnection.manipulate(sql);

            DepositBLL depositBLL = new DepositBLL();
            int customerId = depositBLL.getCustomerIdByACNo(acNo);
            sql = "insert into Transactions(customerId, transactionStatus, transactionAmount) values(" + customerId + ", 'Withdraw'," + amount + ");";
            dbConnection.manipulate(sql);
        }

        public DataTable getReceiptInfo(int acNo, String transactionStatus)
        {
            String sql = "select customerId from customer where customerACNo = " + acNo;
            int customerId = int.Parse(dbConnection.retrieve(sql).Rows[0][0].ToString());

            sql = "select c.customerFName+' '+c.customerLName as 'Full name', c.customerAddress, c.customerGender, c.customerDOB, c.customerPhone, c.customerACNo, c.customerBalance, t.transactionDate, t.transactionStatus, t.transactionAmount, t.transactionId from Customer c, Transactions t where c.customerId = t.customerId and t.transactionStatus='" + transactionStatus + "' and c.customerId = " + customerId + " order by t.transactionId desc ";
            return dbConnection.retrieve(sql);
        }
    }
}
