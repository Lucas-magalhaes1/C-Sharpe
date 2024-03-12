using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            
            while (x > 0)
            {
             double raiz = Math.Sqrt(x);
             Console.WriteLine(raiz.ToString("F3" , CultureInfo.InvariantCulture));
             Console.Write("digite um numero: ");
               x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("numero negtivo");
        }
    }
}
