using BlueBank.System.Application.Interfaces;
using BlueBank.System.Domain.OrderManagement.Entities;
using BlueBank.System.Domain.OrderManagement.Interfaces;
using BlueBank.System.Domain.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Commands
{
    public class CustomerChangeStatusCommand : ChangeStatusCommand<Customer>, ICustomerChangeStatusCommand
    {
        public CustomerChangeStatusCommand(ICustomerRepository repository) : base(repository)
        {
        }
    }
}
