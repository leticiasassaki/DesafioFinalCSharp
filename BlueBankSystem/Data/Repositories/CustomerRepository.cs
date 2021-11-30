using System;
using BlueBank.System.Domain.OrderManagement.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Data.Repositories
{
    public class CustomerRepository
    {
        public static List<Customer> Customers { get; set; } = new List<Customer>();

       
    }
}
