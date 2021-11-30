using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.OrderManagement.Entities;
using BlueBank.System.Domain.Shared.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Commands
{
    public class AddCustomerCommand : IHandler<AddCustomerRequest, AddCustomerResponse>
    {
         private CustomerRepository _repository;
        public AddCustomerCommand(CustomerRepository repository)
        {
            _repository = repository;
        }
         public  AddCustomerResponse Handle(AddCustomerRequest request)
         {
             var customer = new Customer(request.Name, request.Telephone);

             _repository.Add(customer);

             return new AddCustomerResponse()
             { 
                 Id = customer.Id, 
                 Name = customer.Name, 
                 Telephone = customer.Telephone 
             };

             
         }        
    }
}
