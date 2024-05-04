using Course.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates

{

    delegate double BinariyNumericOperation(Double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            BinariyNumericOperation op = CalculationService.Sum;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}
