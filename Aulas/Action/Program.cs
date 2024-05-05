﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action.Entities;

namespace Action
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

            Action<Product> act = Updateprice;

            list.ForEach(Updateprice);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void Updateprice (Product p) {
            p.Price += p.Price * 0.1;
        }
    }
}
