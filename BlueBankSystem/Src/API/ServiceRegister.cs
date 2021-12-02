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
            services.AddScoped<IUpdateCustomerCommand, UpdateCustomerCommand>();
            services.AddScoped<IAddCustomerCommand, AddCustomerCommand>();
            services.AddScoped<IRemoveCustomerByIdCommand, RemoveCustomerByIdCommand>();
            services.AddScoped(typeof(IChangeStatusCommand<>), typeof(ChangeStatusCommand<>));
        }
        public static void RegisterQueries(IServiceCollection services)
        {
            services.AddScoped<IGetCustomerByIdQuery, GetCustomerByIdQuery>();
            services.AddScoped<IGetAllCustomerQuery, GetAllCustomerQuery>();
        }
        public static void RegisterRepositories(IServiceCollection services)
        {
            //services.AddSingleton<ICustomerRepository, CustomerRepository>();
            //services.AddSingleton<IAccountRepository, AccountRepository>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }

    }
}
