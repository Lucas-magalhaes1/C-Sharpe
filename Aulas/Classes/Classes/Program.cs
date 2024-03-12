using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Dados do produto");
            Console.Write("nome:");
            p.nome = Console.ReadLine();
            Console.Write("Preco:");
            p.preco = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            Console.Write("quantidade:");
            p.Quantidade = int.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("digite o  numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("dados atualizados: " + p);
            Console.WriteLine();

            Console.WriteLine("digite o numero de produtos removidos: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("dados atualizados" + p);

        }
    }
}
