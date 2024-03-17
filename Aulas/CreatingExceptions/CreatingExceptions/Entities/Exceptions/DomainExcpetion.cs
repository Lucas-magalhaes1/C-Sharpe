using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingExceptions.Entities.Exceptions
{
    internal class DomainExcpetion : ApplicationException 
    {
        public DomainExcpetion(String message) : base(message) 
        {
        } 

    }
}
