using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Domain.OrderManagement.Entities
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Telephone { get; set; }

        public Customer(string name, string telephone)
        {
            Name = name;
            Telephone = telephone;
        }

    }
}
