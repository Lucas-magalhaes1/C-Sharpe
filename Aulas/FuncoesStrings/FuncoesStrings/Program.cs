using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String original = "abcde FGHIJ ABC abc DEFG   ";
            string s1 = original.ToUpper(); //coloca tudo em maiusculo.
            String s2 = original.ToLower(); //coloca tudo em minusculo.
            string s3 = original.Trim(); //remove espaços em brancos.
            int n1 = original.IndexOf("bc"); //procurar elementos.
            int n2 = original.LastIndexOf("bc");

            String s4 = original.Substring(3); //recortar uma String
            String s5 = original.Substring(3, 5);

            String s6 = original.Replace('a' , 'x'); //Substituir algo na string por outro

            bool b1 = string.IsNullOrEmpty(original); // testa se a string é vazia
            bool b2 = string.IsNullOrWhiteSpace(original);
            

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            
        }
    }
}
