using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Domain.Shared.Handlers
{
    interface IHandler <TRequest, TResponse>
    {
        TResponse Handle(TRequest request);
    }
}
