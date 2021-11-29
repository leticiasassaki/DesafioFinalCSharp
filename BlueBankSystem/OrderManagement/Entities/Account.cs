using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Domain.OrderManagement.Entities
{
    class Account : Entity
    {
        public Customer Customer {get; set;}

        public decimal Balance { get; set; }


    }
}
