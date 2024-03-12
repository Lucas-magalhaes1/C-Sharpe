using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<String> list = new List<String> {"maria" , "joao"};
            list.Add("leo");
            list.Add("alex");
            list.Insert(2, "marco"); //adiciona na posição escolhida
            list.Add("anna");


            foreach (String s in list)
            {
                Console.WriteLine(s); 
            }

            Console.WriteLine("tamnho: " + list.Count); //nuemro de elementos na lista

            String s1 = list.Find(x => x[0] == 'a'); // encontrar o primeiro elemento que começa com a letra A nos nomes
            Console.WriteLine(s1);

            String s2 = list.FindLast(x => x[0] == 'a');
            Console.WriteLine(s2);

            int pos1 = list.FindIndex(x => x[0] == 'a');//primeiro elementro que começa com a 
            Console.WriteLine(pos1);


            int pos2 = list.FindLastIndex(x => x[0] == 'a');//ultimo elementro que começa com a 
            Console.WriteLine(pos2);

            Console.WriteLine();

            List<String> list2 = list.FindAll(x=> x.Length == 5 );// imprimir todos os elementos da lista com o numero de carcteres == 5
            foreach (String s in list2)
            {
                
                Console.WriteLine(s);
            }

            Console.WriteLine();

            list.Remove("alex");
            

            list.RemoveAll(x => x[0] == 'm' ); //remove elesmentos que começa com m 

            foreach (String s in list)
            {
                Console.WriteLine(s);
            }




        }
    }
}
