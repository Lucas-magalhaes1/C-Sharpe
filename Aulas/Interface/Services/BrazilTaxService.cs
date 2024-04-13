using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    internal class BrazilTaxService
    {
        public double Tax (Double amount)
        {
            if (amount <= 100.00) {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
