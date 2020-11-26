using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingOperation
{
    public interface IBankAccount
    {
        public enum BankAccountTypeEnum
        {
            Current = 1,
            Savings = 2
        }

        public double GetBalance();
        public void Deposit(double amt);
        public bool Withdraw(double amt);

        public bool Transfer(IBankAccount toAccount, double amount);

        public double calculateInterest();

        BankAccountTypeEnum AccountType { get; set; }

    }
}
