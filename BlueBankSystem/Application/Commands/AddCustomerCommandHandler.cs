using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.OrderManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Commands
{
    public class AddCustomerCommandHandler : Handler<AddCustomerRequest, AddCustomerResponse>
    {

         public  override AddCustomerResponse Handle(AddCustomerRequest request)
         {
             var customer = new Customer(request.Name, request.Telephone);

             CustomerRepository.Customers.Add(customer);

             var response = new AddCustomerResponse() { Id = customer.Id, Name = customer.Name, Telephone = customer.Telephone };

             return response;
         }        
    }
}
