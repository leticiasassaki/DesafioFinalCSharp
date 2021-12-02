using System;
using BlueBank.System.Domain.Shared.Entities;


namespace BlueBank.System.Domain.OrderManagement.Entities
{
    public class Account : Entity
    {
        public string CustomerId {get; set;}
        public decimal Balance { get; set; }

        public Account(String customer, decimal balance)
        {
            CustomerId = customer;
            Balance = balance;
        }        
    }
}
