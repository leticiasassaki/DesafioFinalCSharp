using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;

namespace BlueBank.System.Application.Queries
{
    public class GetCustomerByIdQuery : Handler<GetCustomerByIdRequest, GetCustomerByIdResponse>
    {
        public override GetCustomerByIdResponse Handle(GetCustomerByIdRequest request)
        {
            return new GetCustomerByIdResponse();/*
            var customer = CustomerRepository.Customers.Single(c => c.Id == request.Id);
            return new GetCustomerByIdResponse()
            {
                Id = customer.Id,
                Name = customer.Name,
                Telephone = customer.Telephone,
                IsActive = customer.IsActive 
            };*/
        }

    }
}
