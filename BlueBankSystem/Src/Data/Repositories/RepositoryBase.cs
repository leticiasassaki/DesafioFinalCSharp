using BlueBank.System.Data.Contexts;
using BlueBank.System.Domain.OrderManagement.Entities;
using BlueBank.System.Domain.Shared.Entities;
using BlueBank.System.Domain.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Data.Repositories
{
    public abstract class RepositoryBase<TEntity>: IRepositoryBase<TEntity> where TEntity : Entity
    {
        protected DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }



        public TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        
        public void Update(TEntity customer)
        {
            _context.Set<TEntity>().Update(customer);
            _context.SaveChanges();

        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null
                ? _context.Set<TEntity>().AsQueryable()
                : _context.Set<TEntity>().Where(predicate).AsQueryable();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
