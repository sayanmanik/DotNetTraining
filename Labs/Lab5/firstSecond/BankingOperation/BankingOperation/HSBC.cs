using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingOperation
{
    class HSBC : BankAccount
    {
        public override IBankAccount.BankAccountTypeEnum AccountType 
        {
            get
            {
                return accounType;
            }

            set
            {
                accounType = value;
            }
        }

        public override double calculateInterest()
        {
            return 0.05;
        }

        public override void Deposit(double amt)
        {
            if (amt > 0)
            {
                balance = balance + amt;
            }
        }

        public override double GetBalance()
        {
            return balance + balance * calculateInterest();
        }

        public override bool Transfer(IBankAccount toAccount, double amount)
        {
            if (amount > 0)
            {
                toAccount.Deposit(amount);
                this.Withdraw(amount);
                return true;
            }

            return false;
        }

        public override bool Withdraw(double amt)
        {
            if (amt > 0)
            {
                balance = balance - amt;
                return true;
            }

            return false;
        }
    }
}
