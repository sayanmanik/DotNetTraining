using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI iciKol = new ICICI();
            iciKol.AccountType = IBankAccount.BankAccountTypeEnum.Savings;
            iciKol.Deposit(50000);
            Console.WriteLine("Before Transfer balance of iciKol {0} and type {1} ", iciKol.GetBalance(), iciKol.AccountType);

            ICICI iciBBS = new ICICI();
            iciBBS.AccountType = IBankAccount.BankAccountTypeEnum.Current;
            iciBBS.Deposit(20000);
            Console.WriteLine("Before Transfer balance of iciBBS {0} and type {1} ", iciBBS.GetBalance(), iciBBS.AccountType);

            iciKol.Transfer(iciBBS,5000);

            Console.WriteLine("After Transfer balance of iciKol {0} and type {1} ", iciKol.GetBalance(), iciKol.AccountType);
            Console.WriteLine("After Transfer balance of iciBBS {0} and type {1} ", iciBBS.GetBalance(), iciBBS.AccountType);
        }
    
    
    }
}
