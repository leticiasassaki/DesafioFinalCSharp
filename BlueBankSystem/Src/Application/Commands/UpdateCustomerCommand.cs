using BlueBank.System.Application.Queries.Interfaces;
using BlueBank.System.Application.Commands.Interfaces;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.OrderManagement.Entities;
using BlueBank.System.Domain.Shared.Commands;
using BlueBank.System.Domain.Shared.Handlers;
using BlueBank.System.Domain.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlueBank.System.Application.Commands
{
    public class UpdateCustomerCommand : CommandBase<Customer>, IUpdateCustomerCommand
    {      
        public UpdateCustomerCommand(IRepository<Customer> repository) : base(repository)
        {           
        }
        public UpdateCustomerResponse Handle(UpdateCustomerRequest request) 
        {
            var customer = repository.GetById(request.Id);
            
            if (!customer.IsActive) throw new ArgumentException("O produto está inativo");
            customer.Name = request.Name;
            customer.Telephone = request.Telephone;

            repository.Update(customer);

            return new UpdateCustomerResponse() 
            { 
                Id = customer.Id, 
                Name = customer.Name, 
                Telephone = customer.Telephone 
            };
        }
    }
}
