using BlueBank.System.Application.Interfaces;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.OrderManagement.Entities;

using BlueBank.System.Domain.Shared.Handlers;
using BlueBank.System.Domain.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Commands
{
    public class AddCustomerCommand : CommandBase<Customer>, IAddCustomerCommand
    {
        //private readonly IRepository<Customer> _repository;
        public AddCustomerCommand(IRepository<Customer> repository) : base(repository)
        {
           
        }
         public  AddCustomerResponse Handle(AddCustomerRequest request)
         {
             var customer = new Customer(request.Name, request.Telephone);

             repository.Add(customer);

             return new AddCustomerResponse()
             { 
                 Id = customer.Id, 
                 Name = customer.Name, 
                 Telephone = customer.Telephone 
             };

             
         }        
    }
}
