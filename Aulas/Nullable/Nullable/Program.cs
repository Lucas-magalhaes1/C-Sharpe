using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double? x = null;
            double? y = 10.0; 

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue) 
                Console.WriteLine(x.Value);
            else
            Console.WriteLine("X é nullo");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else 
                Console.WriteLine("Y é nullo");


             double ? z = null;
            double ? w = 10;

            double a = z ?? 5;
            double b = w ?? 5;

            Console.WriteLine($"{a} {b}");
        }
    }
}
