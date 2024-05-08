using Func.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, String> func = NameUpper;             // expressão lambda  func = p => p.name.ToUpper();

            List<string> result = list.Select(func).ToList();
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper (Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
