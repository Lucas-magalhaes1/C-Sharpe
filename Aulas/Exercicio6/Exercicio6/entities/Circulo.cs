using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio6.entities.Enums;

namespace Exercicio6.entities
{
    internal class Circulo : Shape
    {
        public double Raio {  get; set; }

        public Circulo(double raio , Color color) : base (color)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
