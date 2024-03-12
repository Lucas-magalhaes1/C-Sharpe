using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio3.Entities.enums;
using Exercicio3.Entities;
using System.Globalization;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o departamento name:");
            String deptName = Console.ReadLine();

            Console.WriteLine("Name:");
            String name = Console.ReadLine();

            Console.Write("Level (Junior/Pleno/Senior):");
            string levelStr = Console.ReadLine();

            WorkerLevel level;
            if (!Enum.TryParse(levelStr, true, out level))
            {
                Console.WriteLine("Invalid input. Please enter Junior, Pleno, or Senior.");
                return;
            }

            Console.WriteLine("Base salary:");
            double basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, basesalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Entre #{i} contract date");
                Console.WriteLine("Date (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value Hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name " + worker.Name);
            Console.WriteLine("Department " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ":" + worker.Income(year, month));
        }
    }
}