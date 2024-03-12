using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0,1, 30);
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(1, 2, 11, 30);

            TimeSpan t5 = TimeSpan.FromDays(1.5);
            TimeSpan t6 = TimeSpan.FromMinutes(60);
           
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}
