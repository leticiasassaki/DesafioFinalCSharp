using BlueBank.System.Data.Contexts;
using BlueBank.System.Domain.OrderManagement.Entities;
using BlueBank.System.Domain.OrderManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Data.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(SystemContext context) : base(context) { }
       
    }
}
