using GetHashCodeAndEquals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCodeAndEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // String a = "Maria";
           // String b = "Joao";

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());


            Client a = new Client { Name = "maria " , Email = "Maria@" };
            Client b = new Client { Name = "Jaoo", Email = "Maria@" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }

    }
}
