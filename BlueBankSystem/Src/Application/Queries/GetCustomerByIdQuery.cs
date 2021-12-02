using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueBank.System.Application.Queries.Interfaces;
using BlueBank.System.Application.Commands.Interfaces;

using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.OrderManagement.Entities;
using BlueBank.System.Domain.Shared.Handlers;
using BlueBank.System.Domain.Shared.Interfaces;

namespace BlueBank.System.Application.Queries
{
    public class GetCustomerByIdQuery : IGetCustomerByIdQuery
    {
        private IRepository<Customer> _repository;


        public GetCustomerByIdQuery(IRepository<Customer> repository)
        {
            _repository = repository;
        }



        public GetCustomerByIdResponse Handle(GetCustomerByIdRequest request)
        {

            var customer = _repository.GetById(request.Id);

            return new GetCustomerByIdResponse()
            {
                Id = customer.Id,
                Name = customer.Name,
                Telephone = customer.Telephone,
                IsActive = customer.IsActive
            };
        }


    }

}