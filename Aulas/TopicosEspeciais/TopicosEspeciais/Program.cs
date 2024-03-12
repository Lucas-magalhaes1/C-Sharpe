using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicosEspeciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            String day;

            switch (x)
            {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda";
                    break;
                case 3:
                    day = "terça";
                    break;
                case 4:
                    day = "Quarta";
                    break;
                case 5:
                    day = "Quinta";
                    break;
                case 6:
                    day = "Sexta";
                    break;
                case 7:
                    day = "Sabado";
                    break;
                default:
                    day = "invalid value";
                    break;

            }
            Console.WriteLine("Day " + day );
            
        }
    }
}
