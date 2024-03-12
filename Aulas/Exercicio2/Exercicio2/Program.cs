using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacoes conta;

            Console.Write("Entra com o numero da conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Nome titular da conta:");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial S/N ?");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com o valor do deposito incial:");
                double depositoinicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new Operacoes(numero, titular, depositoinicial);
            }
            else
            {
                conta = new Operacoes(numero,titular);
            }


            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nInforme um valor para deposito:");
            double Quantia = int.Parse(Console.ReadLine());
            if (Quantia> 0 ) {
                conta.Deposito(Quantia);
                Console.WriteLine(conta);
            }else
            {
                Console.WriteLine("Erro ao depositar");
            }

            Console.Write("\nInforme um valor para saque:");
            Quantia = int.Parse(Console.ReadLine());
            if (Quantia > 0)
            {
                if (Quantia > conta.Saldo)
                {
                    Console.WriteLine("Erro ao sacar: Saldo insuficiente");
                }
                else
                {
                    conta.Saque(Quantia);
                    Console.WriteLine(conta);
                }
            }
            else
            {
                Console.WriteLine("Erro ao sacar: Valor inválido");
            }

        }
    }
}
