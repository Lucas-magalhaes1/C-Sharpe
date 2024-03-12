using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    internal class BusinessAccount : Account
    {
        public Double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balence, Double loanLimit) : base(number, holder, balence)
        {
            LoanLimit = loanLimit;


        }

        public void Loan(double amount) 
        {
            if (amount < LoanLimit)
            {
                Balence += amount;
            } 
            
        }
    }
}
    
