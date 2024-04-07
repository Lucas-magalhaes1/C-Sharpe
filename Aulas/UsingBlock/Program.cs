using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Lucas\Desktop\file.txt";
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                }
            }
        }
    }
}
