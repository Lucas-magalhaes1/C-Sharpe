using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInfo_IOException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String sourcePath = @"C:\Users\Lucas\Desktop\file.txt";
            String targetPath = @"C:\Users\Lucas\Desktop\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                String[] lines = File.ReadAllLines(sourcePath);
                foreach (String line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
