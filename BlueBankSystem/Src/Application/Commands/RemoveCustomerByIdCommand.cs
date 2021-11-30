using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Commands
{
    public class RemoveCustomerByIdCommand : Handler<RemoveCustomerByIdRequest, RemoveCustomerByIdResponse>
    {
        public override RemoveCustomerByIdResponse Handle(RemoveCustomerByIdRequest request)
        {
            var customer = CustomerRepository.Customers.Single(c => c.Id == request.Id);

            CustomerRepository.Customers.Remove(customer);

            return new RemoveCustomerByIdResponse();
        }

        
    }
}
