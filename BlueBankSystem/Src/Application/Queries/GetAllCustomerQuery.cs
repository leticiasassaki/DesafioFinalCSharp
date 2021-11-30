using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Queries
{
    public class GetAllCustomerQuery : Handler<GetAllCustomerRequest, IEnumerable<GetAllCustomerResponse>>
    {
        public override IEnumerable<GetAllCustomerResponse> Handle(GetAllCustomerRequest request)
        {
            return CustomerRepository.Customers.Select(c => new GetAllCustomerResponse()
            {
                Id = c.Id,
                Name = c.Name,
                Telephone = c.Telephone

            });
        }        
    }
}
