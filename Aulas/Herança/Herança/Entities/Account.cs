using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balence  { get; protected set; }

        public Account() 
        {
        }

        public Account(int number, string holder, double balence)
        {
            Number = number;
            Holder = holder;
            Balence = balence;
        }

        public virtual void  Withdraw(Double amonut )
        {
             Balence -= amonut + 5;
        }

        public void Deposit (Double amonut)
        {
            Balence += amonut;
        }
    }

}
