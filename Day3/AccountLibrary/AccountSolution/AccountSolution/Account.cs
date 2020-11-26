using System;

namespace AccountSolution
{
    public class Account
    {

        #region Fields
        private int accountNumber;
        private string holderName;
        private double balance;
        #endregion


        #region Properties
        

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string HolderName
        {
            get { return holderName; }
            set { holderName = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }




        #endregion




        #region Constructors
        public Account()
        {
            accountNumber = 1;
            holderName = "Sayan";
            balance = 100.0;

        }


        public Account(int num,string name, double bal)
        {
            accountNumber = num;
            holderName = name;
            balance = bal;

        }
        #endregion

        #region Methods
        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
                return true;
            }

            return false;
        }

        public bool Withdraw(double amount)
        {
            if (amount > 0)
            {
                balance = balance - amount;
                return true;
            }

            return false;
        }

        #endregion

    }
}
