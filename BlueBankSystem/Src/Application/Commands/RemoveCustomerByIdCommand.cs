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
using BlueBank.System.Domain.Shared.Entities;
using BlueBank.System.Application.Interfaces;

namespace BlueBank.System.Application.Commands
{
    public class RemoveCustomerByIdCommand : IRemoveCustomerByIdCommand
    {
        private readonly CustomerRepository _repository;

        public RemoveCustomerByIdCommand(CustomerRepository repository)
        {
            _repository = repository;
        }
        public RemoveCustomerByIdResponse Handle(RemoveCustomerByIdRequest request)
        {
            var customer = _repository.GetById(request.Id);

            customer.IsActive = false;

            _repository.Update(customer);

            return new RemoveCustomerByIdResponse() { IsActive = customer.IsActive};
        }        
    }
}
