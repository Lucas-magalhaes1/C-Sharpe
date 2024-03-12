using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio2
{
    internal class Operacoes
    {
        public int NumConta { get; private set; }
        public String Titular {  get; set; }
        public  double Saldo { get; private set; }

        public Operacoes(int numConta, string titular)
        {
            NumConta = numConta;
            Titular = titular;
        }

        public Operacoes(int numConta, string titular, double DepositoInicial) : this(numConta, titular)
        {
            Deposito(DepositoInicial);

        }

        public void  Deposito(double deposito)
        {
             Saldo += deposito;
        }

        public void Saque(double saque)
        {
             Saldo -= saque + 5;
            
        }

        public override string ToString()
        {
            return "Conta:"
                + NumConta
                + ", Titular:"
                + Titular
                + ", Saldo$: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }



    }
}
