using BlueBank.System.Application.Commands.Interfaces;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Domain.OrderManagement.Entities;
using BlueBank.System.Domain.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Commands
{
    public class AddTransactionCommand : IAddTransactionCommand
    {
        private readonly IRepository<Account> _repository;
        private readonly IRepository<Transaction> _transactionRepository;
        public AddTransactionCommand(IRepository<Account> repository, IRepository<Transaction> transactionRepository)
        {
            _repository = repository;
            _transactionRepository = transactionRepository;
        }

        public AddTransactionResponse Handle(AddTransactionRequest request)
        {
            var accountOrigin = _repository.GetById(request.AccountOrigin);
            var accountRecipient = _repository.GetById(request.AccountRecipient);

            if (!accountOrigin.IsActive) throw new ArgumentException("A conta está inativo");
            if (!accountRecipient.IsActive) throw new ArgumentException("A conta está inativo");
            if (accountOrigin.Balance < request.Value ) throw new ArgumentException("Sem Saldo suficiente");

            accountOrigin.Balance = accountOrigin.Balance - request.Value;
            accountRecipient.Balance = accountRecipient.Balance + request.Value;

            _repository.Update(accountOrigin);
            _repository.Update(accountRecipient);
            var transaction = new Transaction(        
               request.AccountOrigin,
               request.AccountRecipient,
               DateTime.Now,
               request.Value
            );
            _transactionRepository.Add(transaction);

            return new AddTransactionResponse()
            {
                Id = transaction.Id,
                AccountOrigin = transaction.AccountOrigin,
                AccountRecipient = transaction.AccountRecipient,
                Date = transaction.Date,
                Value = transaction.Value
            };
        }
    }
}
