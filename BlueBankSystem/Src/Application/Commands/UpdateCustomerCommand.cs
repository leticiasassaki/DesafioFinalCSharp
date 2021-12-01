using BlueBank.System.Application.Interfaces;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.Shared.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlueBank.System.Application.Commands
{
    public class UpdateCustomerCommand : IUpdateCustomerCommand
    {
        private readonly CustomerRepository _repository;

        public UpdateCustomerCommand(CustomerRepository repository)
        {
            _repository = repository;
        }
        public UpdateCustomerResponse Handle(UpdateCustomerRequest request)
        {
            var customer = _repository.GetById(request.Id);
            customer.Name = request.Name;
            customer.Telephone = request.Telephone;

            _repository.Update(customer);

            return new UpdateCustomerResponse() 
            { 
                Id = customer.Id, 
                Name = customer.Name, 
                Telephone = customer.Telephone 
            };
        }
    }
}
