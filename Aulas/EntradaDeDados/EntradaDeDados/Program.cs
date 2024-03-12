using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Principal;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();  
            string z = Console.ReadLine();


            Console.WriteLine("voce digitou");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c); */ 

            /*
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2" , CultureInfo.InvariantCulture)); */

            /*
            String[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse (vet[1]);
            int idade = int.Parse (vet[2]);
            double altura = double.Parse (vet[3]);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2")); */

            Console.WriteLine("Digite seu nome?");
            string n = Console.ReadLine();

            Console.WriteLine("quantos quartos tem na sua casa?");
            int q = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço de um produto");
            double p = double.Parse(Console.ReadLine());

            Console.WriteLine("nome idade e altura ( mesma linha )");
            string[] info = Console.ReadLine().Split(' ');
            string no = info[0];
            int ida = int.Parse(info[1]);
            double al = double.Parse(info[2]);
            Console.WriteLine("\n");

            Console.WriteLine(n);
            Console.WriteLine(q);
            Console.WriteLine(p);
            Console.WriteLine(no);
            Console.WriteLine(ida);
            Console.WriteLine(al);






        }
    }
}
        