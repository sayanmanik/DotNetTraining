using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public class SavingsAccount : Account
    {
        private double minimumBalance;
        private double interest;

        public double Interest
        {
            get
            {
                return interest;
            }
            set
            {
                interest = value;
            }
        }

        public double MinimumBalance
        {
            get
            {
                return minimumBalance;
            }
            set
            {
                minimumBalance = value;
            }
        }


        public SavingsAccount()
        {
            minimumBalance = 500;
        }
        public SavingsAccount(int accNum, string holderName, double balance, double minBalance): base(accNum, holderName, balance)
        {

            this.minimumBalance = minBalance;


        }


        public void Display()
        {
            Console.WriteLine("Acc Number: "+base.accountNumber);
            Console.WriteLine("Balance Number: " + base.balance);
            Console.WriteLine("Holder Name: " + base.holderName);
            Console.WriteLine("Minimum Balance: " + minimumBalance);

        }

        public override bool Deposit(double amount)
        {
            return base.Deposit(amount);
        }

        public override bool Withdraw(double amount)
        {
            if(balance - amount >= minimumBalance)
            {
                return base.Withdraw(amount);
            }

            return false;
        }

        public override bool TransferFunds(Account src, Account desc, double amount)
        {
            if(amount > 0)
            {
                if(src.Balance - minimumBalance > amount)
                {
                src.Balance = src.Balance - amount;
                desc.Balance = desc.Balance + amount;

                return true;
                }

                return false;
            }

            return false;

        }
    }
}
