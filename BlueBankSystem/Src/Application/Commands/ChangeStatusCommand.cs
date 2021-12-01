using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Responses;
using BlueBank.System.Domain.Shared.Entities;
using BlueBank.System.Domain.Shared.Handlers;
using BlueBank.System.Domain.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Commands
{
    public abstract class ChangeStatusCommand<TEntity> : IHandler<ChangeStatusRequest, ChangeStatusResponse> where TEntity : Entity
    {
        protected IRepositoryBase<TEntity> _repository;

        protected ChangeStatusCommand(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public ChangeStatusResponse Handle(ChangeStatusRequest request)
        {
            var entity = _repository.GetById(request.Id);
            entity.IsActive = request.IsActive;
            _repository.Update(entity);
            return new ChangeStatusResponse() { Id = entity.Id, IsActive = entity.IsActive };
        }
    }
}
