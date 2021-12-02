using BlueBank.System.Domain.Shared.Entities;
using BlueBank.System.Domain.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Domain.Shared.Commands
{
    public abstract class CommandBase<TEntity> where TEntity : Entity
    {
        protected readonly IRepository<TEntity> repository;

        protected CommandBase(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }
                    
    }
}
