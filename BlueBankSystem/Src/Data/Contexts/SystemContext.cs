using BlueBank.System.Domain.OrderManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Data.Contexts
{
    public class SystemContext : DbContext
    {
        public SystemContext(DbContextOptions<SystemContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        





        public DbSet<Customer> Customers { get; set; }

        //public DbSet<Account> Accounts { get; set; }
        
    }
}

