using Exercicio6.entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio6.entities.Enums;
namespace Exercicio6.entities
{
    internal class Retangulo : Shape
    {
        public double  Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura , Color color ) : base( color ) 
        {
            Largura = largura;
            Altura = altura;
            
        }



        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
