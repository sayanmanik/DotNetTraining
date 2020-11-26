using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingOperation
{
    public abstract class BankAccount : IBankAccount
    {
        protected IBankAccount.BankAccountTypeEnum accounType;

        protected double balance;
        
        public abstract IBankAccount.BankAccountTypeEnum AccountType { get; set; }

        public abstract double calculateInterest();       
        public abstract void Deposit(double amt);
        public abstract double GetBalance();
        public abstract bool Transfer(IBankAccount toAccount, double amount);
        public abstract bool Withdraw(double amt);
    }
}
