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
            services.AddSingleton<IAddCustomerCommand, AddCustomerCommand>();
            services.AddSingleton<IRemoveCustomerByIdCommand, RemoveCustomerByIdCommand>();
            services.AddSingleton(typeof(IChangeStatusCommand<>), typeof(ChangeStatusCommand<>));
        }
        public static void RegisterQueries(IServiceCollection services)
        {
            services.AddSingleton<IGetCustomerByIdQuery, GetCustomerByIdQuery>();
            services.AddSingleton<IGetAllCustomerQuery, GetAllCustomerQuery>();
        }
        public static void RegisterRepositories(IServiceCollection services)
        {
            //services.AddSingleton<ICustomerRepository, CustomerRepository>();
            //services.AddSingleton<IAccountRepository, AccountRepository>();
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
        }

    }
}
