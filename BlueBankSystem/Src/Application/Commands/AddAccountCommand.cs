using BlueBank.System.Application.Commands.Interfaces;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Domain.OrderManagement.Entities;
using BlueBank.System.Domain.Shared.Commands;
using BlueBank.System.Domain.Shared.Interfaces;

namespace BlueBank.System.Application.Commands
{
    public class AddAccountCommand : CommandBase<Account>, IAddAccountCommand    
    {
        public AddAccountCommand(IRepository<Account> repository) : base(repository)
        {
        }
        public AddAccountResponse Handle(AddAccountRequest request)
        {
            var account = new Account(request.CustomerId, request.Balance );
            repository.Add(account);
            return new AddAccountResponse()
            {
                CustomerId = account.CustomerId,
                Balance = account.Balance
            };
            
        }
    }
}
