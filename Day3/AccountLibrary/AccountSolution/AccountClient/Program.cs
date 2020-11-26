using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;

namespace AccountClient
    
{
    class Program
    {
        static void Main(string[] args)
        {

         
            // Account.showName();

            //Account a = new SavingsAccount();
            //Console.WriteLine(a.AccountNumber+"\n"+a.Balance+"\n"+a.HolderName);
            //a.Deposit(1000);
            //Console.WriteLine("Updated Balance: "+a.Balance);

            //Console.WriteLine("Enter the amount to withdraw");



            //bool reslt = a.Withdraw(Convert.ToDouble(Console.ReadLine()));
            //if (reslt == true)
            //{
            //    Console.WriteLine("Withdraw successful");
            //}
            //else
            //{
            //    Console.WriteLine("Withdraw failed");
            //}

                //SavingsAccount s1 = new SavingsAccount();

            try
            {
                SavingsAccount s2 = new SavingsAccount(120, "sayan", 1500, 700);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(CustomException e)
            {
                Console.WriteLine(e.Message);
            }


            //Account s3 = new SavingsAccount();

            //    s1.Display();
            //    s3.Display();

            //    bool res = s1.TransferFunds(a, s2, 100);

            //    if (res)
            //    {
            //        Console.WriteLine("Successful");
            //        a.Display();
            //        s2.Display();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed");
            //        a.Display();
            //        s2.Display();
            //    }

            

        }

    }
}
