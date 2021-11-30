using System;
using BlueBank.System.Domain.OrderManagement.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueBank.System.Data.Contexts;
using System.Linq.Expressions;

namespace BlueBank.System.Data.Repositories
{
    public class CustomerRepository
    {
        private SystemContext _context;

        public CustomerRepository(SystemContext context)
        {
            _context = context;
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

       

        public Customer GetById(Guid id)
        {
            return _context.Customers.Find(id);
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();

        }

        public IQueryable<Customer> Get(Expression<Func<Customer, bool>>predicate = null)
        {
            return predicate == null
                ? _context.Customers.AsQueryable()
                : _context.Customers.Where(predicate).AsQueryable();
        }
    }
}
