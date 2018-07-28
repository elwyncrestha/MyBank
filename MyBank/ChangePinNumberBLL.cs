using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class ChangePinNumberBLL
    {
        DbConnection dbConnection = new DbConnection();
        public void updatePin(int accountNumber, int pinNumber) {
            String sql = "update Customer set customerPin = " + pinNumber + " where customerACNo = " + accountNumber;
            dbConnection.manipulate(sql);
        }

        public bool validatePin(int pinNum, int accountNum)
        {
            bool status = false;
            String sql = "select * from Customer where customerPin = " + pinNum + "and customerACNo = " + accountNum;
            DataTable dataTable = dbConnection.retrieve(sql);

            if (dataTable.Rows.Count > 0) {
                status = true;
            }

            return status;
        }
    }
}
