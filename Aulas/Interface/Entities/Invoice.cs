using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Dynamic;

namespace Interface.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get
            {
                return BasicPayment + Tax;
            }
        }

        public override string ToString()
        {
            return "Basic Payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture) +
                    "\n" +
                    Tax.ToString("F2", CultureInfo.InvariantCulture) +
                    "\n" +
                    TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
