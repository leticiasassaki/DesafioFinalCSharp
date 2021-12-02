using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Requests
{
    public class GetAccountByIdRequest
    {
        public GetAccountByIdRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; } 
    }

}
