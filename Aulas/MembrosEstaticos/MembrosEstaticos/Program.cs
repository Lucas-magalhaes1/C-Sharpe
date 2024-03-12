using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture); 

            double cir = Calculadora. Circuferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("circuferencia: " +  cir.ToString("F2" , CultureInfo.InvariantCulture));
            Console.WriteLine("Volume:" +  volume.ToString("F2" , CultureInfo.CurrentCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.pi.ToString("F2" , CultureInfo.InvariantCulture));
        }

       
    }
}
