using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("entre com um numero: ");
            int x = int.Parse(Console.ReadLine());
            
            if (x % 2 == 0 )
            {
                Console.WriteLine("Par");
            }
            else{
                Console.WriteLine("impar");
            }

            Console.Write("entre com um numero imapar : ");
            int y = int.Parse(Console.ReadLine());

            if (y % 2 != 0 ) 
            {
                Console.WriteLine("impar");
            }
            else{
                Console.WriteLine("par");
            }
        }
    }
}
