using BlueBank.System.Application.Interfaces;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.OrderManagement.Interfaces;
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
        private readonly ICustomerRepository _repository;

        public UpdateCustomerCommand(ICustomerRepository repository)
        {
            _repository = repository;
        }
        public UpdateCustomerResponse Handle(UpdateCustomerRequest request)
        {
            var customer = _repository.GetById(request.Id);
            //Vi a necissidade de colocar este If para ativar produtos ao atualizalos
            if (!customer.IsActive) throw new ArgumentException("O produto está inativo");


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
