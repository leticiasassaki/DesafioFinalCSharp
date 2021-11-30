using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueBank.System.Domain.Shared.Entities;

namespace BlueBank.System.Domain.OrderManagement.Entities
{
    public class Account : Entity
    {
        public Customer Customer {get; set;}
        public decimal Balance { get; set; }

        public Account(Customer customer, decimal balance)
        {
            Customer = customer;
            Balance = balance;
        }
        // A CONTA TEM UM HISTORY DE TRANSAÇÕES
    }
}
