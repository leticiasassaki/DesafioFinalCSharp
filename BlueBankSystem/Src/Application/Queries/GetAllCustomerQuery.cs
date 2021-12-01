using BlueBank.System.Application.Interfaces;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.OrderManagement.Interfaces;
using BlueBank.System.Domain.Shared.Handlers;
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
        private readonly ICustomerRepository _repository;

        public GetAllCustomerQuery(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<GetAllCustomerResponse> Handle(GetAllCustomerRequest request)
        {
            return _repository
                .Get(c => c.IsActive)
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
