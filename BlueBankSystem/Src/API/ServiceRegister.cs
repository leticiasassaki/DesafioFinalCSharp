using BlueBank.System.Application.Commands;
using BlueBank.System.Application.Interfaces;
using BlueBank.System.Application.Queries;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Domain.OrderManagement.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            services.AddSingleton<ICustomerChangeStatusCommand, CustomerChangeStatusCommand>();
        }
        public static void RegisterQueries(IServiceCollection services)
        {
            services.AddSingleton<IGetCustomerByIdQuery, GetCustomerByIdQuery>();
            services.AddSingleton<IGetAllCustomerQuery, GetAllCustomerQuery>();
        }
        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
            services.AddSingleton<IAccountRepository, AccountRepository>();

        }

    }
}
