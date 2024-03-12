using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] vet = new string[] { "maria", "alex", "bob" };


            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.WriteLine();

            foreach (string v in vet)
            {
                Console.WriteLine(v);
            }
        }
    }
}
