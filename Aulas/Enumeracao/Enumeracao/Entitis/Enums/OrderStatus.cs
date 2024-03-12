using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao.Entitis.Enums
{
    enum OrderStatus : int 
    {
        PendingyPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
