using BlueBank.System.Application.Commands.Interfaces;
using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Domain.OrderManagement.Entities;
using BlueBank.System.Domain.Shared.Commands;
using BlueBank.System.Domain.Shared.Interfaces;


namespace BlueBank.System.Application.Commands
{
    public class AddCustomerCommand : CommandBase<Customer>, IAddCustomerCommand
    {  
        public AddCustomerCommand(IRepository<Customer> repository) : base(repository)
        {           
        }
         public  AddCustomerResponse Handle(AddCustomerRequest request)
         {
             var customer = new Customer(request.Name, request.Telephone);
             repository.Add(customer);
             return new AddCustomerResponse()
             { 
                 Id = customer.Id, 
                 Name = customer.Name, 
                 Telephone = customer.Telephone 
             };             
         }        
    }
}
