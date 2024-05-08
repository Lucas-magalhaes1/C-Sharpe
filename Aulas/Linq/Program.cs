using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Especificar o data source 

            int[] num = new int[] { 1, 2, 3, 4, 5, 6 };

            // defirnir a consulta

            var result = num
                .Where(x => x % 2 == 0)
                .Select(X => X * 10);

            //executar consulta

            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
