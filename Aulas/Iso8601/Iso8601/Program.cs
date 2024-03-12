using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iso8601
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 55, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 55, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 55);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d1.Kind);
            Console.WriteLine(d1.ToLocalTime());
            Console.WriteLine(d1.ToUniversalTime());

        }

    }
}
