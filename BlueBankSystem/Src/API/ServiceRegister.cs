using BlueBank.System.Application.Commands;
using BlueBank.System.Application.Commands.Interfaces;
using BlueBank.System.Application.Queries;
using BlueBank.System.Application.Queries.Interfaces;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.Shared.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BlueBank.System.Services.API
{
    public class ServiceRegister
    {
        public static void Register(IServiceCollection services)
        {
            RegisterQueries(services);
            RegisterRepositories(services);
            RegisterCommands(services);

        }

        public static void RegisterCommands(IServiceCollection services)
        {
            services.AddSingleton<IUpdateCustomerCommand, UpdateCustomerCommand>();
            services.AddSingleton<IUpdateAccountCommand, UpdateAccountCommand>();
            services.AddSingleton<IAddCustomerCommand, AddCustomerCommand>();
            services.AddSingleton<IAddAccountCommand, AddAccountCommand>();
            services.AddSingleton<IRemoveCustomerByIdCommand, RemoveCustomerByIdCommand>();
            services.AddSingleton<IRemoveAccountByIdCommand, RemoveAccountByIdCommand>();
            services.AddSingleton(typeof(IChangeStatusCommand<>), typeof(ChangeStatusCommand<>));
        }
        public static void RegisterQueries(IServiceCollection services)
        {
            services.AddSingleton<IGetCustomerByIdQuery, GetCustomerByIdQuery>();
            services.AddSingleton<IGetAccountByIdQuery, GetAccountByIdQuery>();
            services.AddSingleton<IGetAllCustomerQuery, GetAllCustomerQuery>();
            services.AddSingleton<IGetAllAccountQuery, GetAllAccountQuery>();
            
        }
        public static void RegisterRepositories(IServiceCollection services)
        {
            //services.AddSingleton<ICustomerRepository, CustomerRepository>();
            //services.AddSingleton<IAccountRepository, AccountRepository>();
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
        }

    }
}
