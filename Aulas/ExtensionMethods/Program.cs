using ExtensionMethods.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
