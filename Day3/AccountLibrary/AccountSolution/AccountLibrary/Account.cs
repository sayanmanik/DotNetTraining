using System;

namespace AccountLibrary
{
    public abstract class Account
    {

        #region Fields
        protected int accountNumber;
        protected string holderName;
        protected double balance;
        private static string bankName;

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

        public double Interest
        {
            get;
            set;
        }



        #endregion




        #region Constructor
        static Account()
        {
            bankName = "HDFC";
            
        }
        
        
        public Account()
        {
            accountNumber = 1;
            holderName = "Sayan";
            balance = 100.0;

        }


        public Account(int num,string name, double bal)
        {

            //if (num <= 0)
            //{
            //    throw new ArgumentException("Account number must be positive");
            //}
            //if(name == null || name == "")
            //{
            //    throw new ArgumentException("Holder name cannot be empty");
            //}

            //if (balance < 0)
            //{
            //    throw new ArgumentException("Balance should be positive");
            //}

            if (name.Length <= 6)
            {
                throw new CustomException("length should be greater than 6");
            }
            accountNumber = num;
            holderName = name;
            balance = bal;

        }
        #endregion

        #region Methods
        public virtual bool Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
                return true;
            }

            return false;
        }

        public virtual bool Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                return true;
            }

            return false;
        }

        public abstract bool TransferFunds(Account src, Account desc,double amount);


        public void Display()
        {
            Console.WriteLine("Acc Number: " + accountNumber);
            Console.WriteLine("Balance Number: " + balance);
            Console.WriteLine("Holder Name: " + holderName);


        }



        public static void showName()
        {
            Console.WriteLine("Bank name: "+bankName);
        }
        #endregion

    }
}
