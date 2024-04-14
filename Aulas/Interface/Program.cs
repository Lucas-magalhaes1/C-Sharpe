    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Interface.Entities;
using System.Net.Http.Headers;
using Interface.Services;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a data: ");
            Console.WriteLine("Modelo do carro: ");
            string model = Console.ReadLine();
            Console.WriteLine("Horario de entrada (dd/MM/yyyy): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("horario de devolução (dd/MM/yyyy): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            
            Console.WriteLine("Preço da hora: ");
            double Hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Preço por dia: ");
            double Day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental car = new CarRental(start, finish , new Veiculo(model));

            RentalSevice rentalSevice = new RentalSevice(Hour ,Day, new BrazilTaxService());

            rentalSevice.ProcessInvoice(car);

            Console.WriteLine(car.Invoice);

        }
    }
}
