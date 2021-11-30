using System;
using BlueBank.System.Domain.OrderManagement.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueBank.System.Data.Contexts;

namespace BlueBank.System.Data.Repositories
{
    public class CustomerRepository
    {
        private SystemContext _context;

        public CustomerRepository(SystemContext context)
        {
            _context = context;
        }

        public void Add(Customer custumer)
        {
            _context.Customers.Add(custumer);
            _context.SaveChanges();
        }


    }
}
