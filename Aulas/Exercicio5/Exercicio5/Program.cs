using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio5.Entities;
using System.Globalization;
using System.Security.Principal;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de funcionarios ?: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"Funcionario #{i} data: ");
                Console.Write("Funcionario Tercerizado(Y/N)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome:");
                String nome = Console.ReadLine();
                Console.Write("Horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("despeja adicional: ");
                    double adicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(nome, horas, valorHora, adicional));
                }
                else
                {
                    list.Add(new Employee(nome, horas, valorHora));
                }

                Console.WriteLine();
            }
            Console.WriteLine("Pagamentos:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2"));

            }
        }
     }
}
