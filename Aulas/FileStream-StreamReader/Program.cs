using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\Users\Lucas\Desktop\file.txt";
           
            StreamReader sr = null;
            try
            {
                
                sr = File.OpenText(path);
                String line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
               if (sr != null) sr.Close();
              
            }


        }
    }
}
