using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herança.Entities;

namespace Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account  acc = new Account(100 , "Alex" , 0.0);
            BusinessAccount bacc = new BusinessAccount(102, "MAria", 0.0, 500);

            //UPCASTING 

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(103, "Bob" , 0.0 , 200);
            Account acc3 = new SavingsAccount(104, "Anna", 0.0, 0.01);

            //DOWNCASTING 

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            if(acc3 is  BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(100);
                Console.WriteLine("Loan");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.updateBalance();
                Console.WriteLine("Update");
            }

            Account a1 = new Account(1, "Alex", 500);
            Account a2 = new SavingsAccount(2, "anna", 500, 0.01);

            a1.Withdraw(100);
            a2.Withdraw(100);

            Console.WriteLine(a1.Balence);
            Console.WriteLine(a2.Balence);
            

        }
    }
}
