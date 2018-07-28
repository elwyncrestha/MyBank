using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{

    class CustomerBLL
    {
        DbConnection dbConnection = new DbConnection();

        private String firstName;
        private String lastName;
        private String address;
        private char gender;
        private String dob;
        private String phoneNumber;
        private int accountNo;
        private int pinNo;
        private float balance;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public char Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public int AccountNo
        {
            get
            {
                return accountNo;
            }

            set
            {
                accountNo = value;
            }
        }

        public int PinNo
        {
            get
            {
                return pinNo;
            }

            set
            {
                pinNo = value;
            }
        }

        public float Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public CustomerBLL() { }

        public CustomerBLL(String firstName, String lastName, String address, char gender, String dob, String phoneNumber, int accountNo, int pinNo, float balance) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.gender = gender;
            this.dob = dob;
            this.phoneNumber = phoneNumber;
            this.accountNo = accountNo;
            this.pinNo = pinNo;
            this.balance = balance;
        }

        public int generateACNo() {
            String query = "select MAX(customerACNo) from Customer;";
            DataTable dataTable = dbConnection.retrieve(query);

            if (dataTable.Rows[0][0].ToString() != "")
            {
                return int.Parse(dataTable.Rows[0][0].ToString()) + 1;
            }
            else {
                return 20100;
            }
        }

        public int generatePin() {
            Random random = new Random();
            return random.Next(1000, 9999);
        }

        public void addCustomer() {
            String query = "insert into Customer(customerFname, customerLName, customerAddress, customerGender, customerDOB, customerPhone, customerACNo, customerPin, customerBalance) values('" + firstName + "','" + lastName + "','" + address + "','" + gender + "','" + dob + "','" + phoneNumber + "'," + accountNo + "," + pinNo + ",1);";
            dbConnection.manipulate(query);
        }

        public DataTable displayAllCustomer() {
            String query = "select customerId, customerFname, customerLName, customerAddress, customerGender, customerDOB, customerPhone, customerACNo, customerPin, customerBalance from Customer;";
            return dbConnection.retrieve(query);
        }

        public DataTable getCustomerById(int id)
        {
            String query = "select customerFname, customerLName, customerAddress, customerGender, customerDOB, customerPhone, customerACNo, customerPin, customerBalance from Customer where customerId = " + id + ";";
            return dbConnection.retrieve(query);
        }

        public DataTable getCustomerByAC(int ACNo)
        {
            String query = "select customerFname, customerLName, customerAddress, customerGender, customerDOB, customerPhone, customerACNo, customerPin, customerBalance from Customer where customerACNo = " + ACNo + ";";
            return dbConnection.retrieve(query);
        }

        public void deleteCustomer(int id) {
            String query = "delete from customer where customerId = " + id;
            dbConnection.manipulate(query);
        }

        public void updateCustomer(int id) {
            String query = "update customer set customerFName = '" + firstName + "', customerLName = '" + lastName + "', customerAddress = '" + address + "', customerGender = '" + gender + "', customerDOB = '" + dob + "', customerPhone = '" + phoneNumber + "' where customerId = " + id;
            dbConnection.manipulate(query);
        }

    }
}
