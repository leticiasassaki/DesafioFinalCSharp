using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Requests
{
    public class RemoveAccountByIdRequest
    {
        public RemoveAccountByIdRequest(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
