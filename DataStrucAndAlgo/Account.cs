using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucAndAlgo
{
    public class Account
    {
        private int id;
        private int accountNumber;
        private string firstName;
        private string middleName;
        private string lastName;
        private double balance;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int AccountNumber
        {
            get { return accountNumber;}
            set { accountNumber = value;}
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
