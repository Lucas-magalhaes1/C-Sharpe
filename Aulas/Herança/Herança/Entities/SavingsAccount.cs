using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    sealed internal class SavingsAccount : Account //palavra sealed nao deixa criar subclasses 
    {
        public Double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balence, double interestRate) : base(number,holder,balence)
        {
            InterestRate = interestRate;
        }

        public void updateBalance()
        {
            Balence += Balence * InterestRate;
        }

        public sealed override void Withdraw(double amonut) //nao pode ser sobreescrita novamente em outra subclasse esse função usando a palvra sealed
        {
            Balence -= amonut;
        }
    }
}
