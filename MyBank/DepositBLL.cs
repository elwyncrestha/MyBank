using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class DepositBLL
    {
        DbConnection dbConnection = new DbConnection();

        public bool validateCustomerByACNo(int ACNo) {
            bool customerStatus = false;
            String query = "select * from customer where customerACNo = " + ACNo;
            DataTable dataTable = dbConnection.retrieve(query);
            int countCustomer = dataTable.Rows.Count;

            if (countCustomer > 0) {
                customerStatus = true;
            }

            return customerStatus;
        }

        public DataTable getNamePhoneAddress(int ACNo) {
            String query = "select customerFName+' '+customerLName as 'customerFullName', customerPhone, customerAddress from Customer where customerACNo = " + ACNo + ";";
            return dbConnection.retrieve(query);
        }

        public int getCustomerIdByACNo(int ACNo) {
            String query = "select customerId from customer where customerACNo = " + ACNo;
            DataTable dataTable = dbConnection.retrieve(query);
            int customerId = int.Parse(dataTable.Rows[0][0].ToString());
            return customerId;
        }

        public void depositAmount(int ACNo, float amount) {
            int customerId = getCustomerIdByACNo(ACNo);
            String query = "insert into Transactions(customerId, transactionStatus, transactionAmount) values(" + customerId + ",'Deposit'," + amount + ");";
            dbConnection.manipulate(query);

            query = "update customer set customerBalance =  customerBalance + " + amount + " where customerACNo = " + ACNo;
            dbConnection.manipulate(query);
        }

    }
}
