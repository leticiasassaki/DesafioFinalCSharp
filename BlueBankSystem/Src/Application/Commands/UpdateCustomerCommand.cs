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
    public class UpdateCustomerCommand : Handler<UpdateCustomerRequest, UpdateCustomerResponse>
    {
        public override UpdateCustomerResponse Handle(UpdateCustomerRequest request)
        {
            var customer = CustomerRepository.Customers.Single(c => c.Id == request.Id);
            customer.Name = request.Name;
            customer.Telephone = request.Telephone;

            var response = new UpdateCustomerResponse() { Id = customer.Id, Name = customer.Name, Telephone = customer.Telephone };

            return response;
            
        }
    }
}
