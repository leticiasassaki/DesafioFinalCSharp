using BlueBank.System.Domain.Shared.Entities;
using BlueBank.System.Domain.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Domain.Shared.Handlers
{
    public abstract class Handler<TEntity, TRequest, TResponse> where TEntity : Entity
    {
        protected readonly IRepository<TEntity> repository;
        public abstract TResponse Handle(TRequest request);
    }
}

