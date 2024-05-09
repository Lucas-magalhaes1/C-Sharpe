using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLinq.Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Caminho do arquivo: ");
            string paht = Console.ReadLine();

            List<Product> list = new List<Product>();

            using(StreamReader sr = File.OpenText(paht)) {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1]);
                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).Average();
            Console.WriteLine("Average price = " +  avg);

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
