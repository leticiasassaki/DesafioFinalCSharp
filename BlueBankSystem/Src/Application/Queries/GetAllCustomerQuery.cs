using BlueBank.System.Application.Interfaces;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.OrderManagement.Entities;

using BlueBank.System.Domain.Shared.Handlers;
using BlueBank.System.Domain.Shared.Interfaces;
using Construdelas.OrderSystem.Domain.Shared.Predicates;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Queries
{
    public class GetAllCustomerQuery : IGetAllCustomerQuery
    {
        private readonly IRepository<Customer> _repository;

        public GetAllCustomerQuery(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public IQueryable<GetAllCustomerResponse> Handle(GetAllCustomerRequest request)
        {
            var predicate = PredicateBuilder.New<Customer>();
            if (request.IsActive != null) predicate = predicate.And(c => c.IsActive == request.IsActive);

            
            return _repository
                .Get(predicate)
                .Select(c => new GetAllCustomerResponse()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Telephone = c.Telephone,
                    IsActive = c.IsActive
                });
                        
        }    
    }
}
