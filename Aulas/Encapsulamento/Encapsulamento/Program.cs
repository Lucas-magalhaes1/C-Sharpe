using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Produto p= new Produto("Tv" , 500 , 10);

            p.Nome = "t";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Quantidade);
            Console.WriteLine(p.Preco);
            
        }
    }
}
