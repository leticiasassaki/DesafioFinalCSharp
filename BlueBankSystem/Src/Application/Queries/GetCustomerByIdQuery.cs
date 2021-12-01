using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueBank.System.Application.Interfaces;
using BlueBank.System.Application.Interfaces;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.OrderManagement.Interfaces;
using BlueBank.System.Domain.Shared.Handlers;


namespace BlueBank.System.Application.Queries
{
    public class GetCustomerByIdQuery : IGetCustomerByIdQuery
    {
        private ICustomerRepository _repository;


        public GetCustomerByIdQuery(ICustomerRepository repository)
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