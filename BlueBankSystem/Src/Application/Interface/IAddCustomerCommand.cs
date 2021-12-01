using BlueBank.System.Domain.Shared.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Interface
{
    interface IAddCustomerCommand : IHandler<AddCustomerRequest, AddCustomerResponse>
    {
    }
}
