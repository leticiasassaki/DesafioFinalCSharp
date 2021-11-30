using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Responses
{
    public class GetAllCustomerResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
       
    }
}
