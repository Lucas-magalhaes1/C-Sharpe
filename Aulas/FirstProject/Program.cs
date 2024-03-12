using System;
using System.Data;
using System.Globalization;

namespace Firstprojec 
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong x = 10000000000000000000;
            x++; 
            Console.WriteLine(x);

            bool completo = false;
            Console.WriteLine(completo);

            char genero = 'a';
            char genero2 = '\u0041';
            Console.WriteLine(genero);
            Console.WriteLine(genero2); 

            string nome = "maria";
            Console.WriteLine(nome); //Imutavel,trehd safe, não muda o nome o original 

            String Produto1 = "Computador";
            String produto2 = "Mesa";

            byte idade = 30;
            int codigo = 100;

            double preco = 200;
            double preco2 = 100;
            double media = 5023094230423; 

            Console.WriteLine(Produto1 + " cujo o preço é $" + preco + "\nmesa de escritorio cujo preço é " + preco2);
            Console.WriteLine("meida é igual a " + media.ToString("F2", CultureInfo.InvariantCulture )) ; // adicionar ponto em vez de virgula

           // float x1 = 4.5f;
            //double y = x1;
            //Console.Write(y);

            //double a; 
            //float f;
            //n é possivel converter uma valor double em float por conta de double ser 8bits ja float 4 bits. 

            //a = 5.1;
            //f = a; 

            //para conseguir fazer essa converção teria que fazer um casting na frente confirmando que quero fazer isso ex : f = (float)a; 

            //double a; 
            int f;
           

            //a = 5.1;
            //f = (int)a;  //mesma coisa um numero inteiro. utilzo o casting e me responsabilizo caso haja alguma perca


            int g = 2;
            int h = 3;

            double divisao = (double)  g/h;
            Console.WriteLine(divisao);
            Console.WriteLine("\n \n \n \n");

            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);
            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);
            int n3 = 17 % 3; 
            Console.WriteLine(n3);

            
            double soma =  10.0 / 8.0;
            Console.WriteLine(soma);
            Console.WriteLine("\n \n ");

            //formula de bascara
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b , 2.0) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(delta);


        }

    }
}