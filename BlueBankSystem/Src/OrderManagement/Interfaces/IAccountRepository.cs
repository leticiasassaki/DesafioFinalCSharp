using BlueBank.System.Domain.Shared.Interfaces;
using BlueBank.System.Domain.OrderManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Domain.OrderManagement.Interfaces
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
    }
}
