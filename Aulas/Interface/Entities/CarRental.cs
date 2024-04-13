using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }

        public DateTime Finish { get; set; }
        public Veiculo  Veiculo { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Veiculo veiculo)
        {
            Start = start;
            Finish = finish;
            Veiculo = veiculo;
        }
    }
}
