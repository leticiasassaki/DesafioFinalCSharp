using System;
using BlueBank.System.Domain.OrderManagement.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueBank.System.Data.Contexts;
using System.Linq.Expressions;
using BlueBank.System.Domain.OrderManagement.Interfaces;

namespace BlueBank.System.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(SystemContext context) : base(context) { }
        
    }
}
