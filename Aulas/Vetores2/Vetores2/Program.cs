using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                String name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Produto { nome = name , preco = price };
            }

            double soma = 0;
            for (int i = 0;i < n;i++)
            {
                soma += vect[i].preco;
            }

            double avg = soma / n;
            Console.WriteLine("media de preços = " + avg);
        }
    }
}
