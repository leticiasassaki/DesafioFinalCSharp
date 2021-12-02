using BlueBank.System.Application.Queries.Interfaces;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Domain.OrderManagement.Entities;
using BlueBank.System.Domain.Shared.Interfaces;


namespace BlueBank.System.Application.Queries
{
    public class GetAccountByIdQuery : IGetAccountByIdQuery
    {
        private IRepository<Account> _repository;
        public GetAccountByIdQuery(IRepository<Account> repository)
        {
            _repository = repository;
        }            
        public GetAccountByIdResponse Handle(GetAccountByIdRequest request)
        {
            var account = _repository.GetById(request.Id);

            return new GetAccountByIdResponse()
            {
                Id = account.Id,
                CustomerId = account.CustomerId,
                CustomerName = account.CustomerName,
                Balance = account.Balance,
                IsActive = account.IsActive
            };
        }
    }
}
