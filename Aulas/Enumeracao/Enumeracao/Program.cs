using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumeracao.Entitis;
using Enumeracao.Entitis.Enums;

namespace Enumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { 
                Id = 1030 , 
                Moment = DateTime.Now,
                Status = OrderStatus.PendingyPayment
            };
            
            Console.WriteLine(order);

            string txt = OrderStatus.PendingyPayment.ToString(); 
            Console.WriteLine(txt);

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            Console.WriteLine(os);
        }
    }
}
