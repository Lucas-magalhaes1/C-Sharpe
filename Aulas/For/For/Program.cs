using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros voce va idigitar ? : ");
            int N = int.Parse(Console.ReadLine());

            int Soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor {0}:", i);
                int valor = int.Parse(Console.ReadLine());
                Soma += valor;
            }
            Console.WriteLine("Soma dos valores = " + Soma);
        }
    }
}
