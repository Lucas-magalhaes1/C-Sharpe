using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Preço: ");
            Double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           

            Produto p = new Produto(nome,preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto() { 
                Nome = "TV", 
                Preco = 500.00, 
                Quantidade = 20 
            };
            

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
