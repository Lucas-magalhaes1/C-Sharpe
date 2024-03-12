using Exercicio6.entities;
using Exercicio6.entities.Enums;
using System;
using System.Collections.Generic;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de figuras: ");
            int n = int.Parse(Console.ReadLine());

            LinkedList<Shape> list = new LinkedList<Shape>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Figura {i + 1} data:");
                Console.Write("Retângulo ou Círculo (R/C): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Digite a cor: ");

                Color color;
                bool isValidColor = Enum.TryParse(Console.ReadLine(), out color);

                if (!isValidColor)
                {
                    Console.WriteLine("Cor inválida. Escolha uma cor válida.");
                    continue; // Continue para a próxima iteração do loop
                }

                if (ch == 'R' || ch == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine());
                    list.AddLast(new Retangulo(largura, altura, color));
                }
                else if (ch == 'C' || ch == 'c')
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine());
                    list.AddLast(new Circulo(raio, color));
                }
                else
                {
                    Console.WriteLine("Opção inválida. Escolha 'R' para Retângulo ou 'C' para Círculo.");
                    i--; // Decrementa o índice para repetir a iteração atual
                }

                Console.WriteLine();
                Console.WriteLine("Áreas das figuras:");
                foreach (Shape shape in list)
                {
                    Console.WriteLine(shape.Area());
                }

                Console.WriteLine();
            }
        }
    }
}
