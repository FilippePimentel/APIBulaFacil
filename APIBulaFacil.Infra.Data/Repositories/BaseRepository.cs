using APIBulaFacil.Domain.Contracts.Repositories;
using APIBulaFacil.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity, TKey>
       : IBaseRepository<TEntity, TKey>
       where TEntity : class
    {
        private readonly DataContext context;
        public BaseRepository(DataContext context)
        {
            this.context = context;
        }

        public virtual void Add(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Added;
            context.SaveChanges();
        }

        public virtual void Modify(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public virtual void Remove(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public virtual List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public virtual List<TEntity> GetAll(Func<TEntity, bool> where)
        {
            return context.Set<TEntity>()
                    .Where(where)
                    .ToList();
        }

        public virtual TEntity GetById(TKey key)
        {
            return context.Set<TEntity>().Find(key);
        }

        public virtual TEntity Get(Func<TEntity, bool> where)
        {
            return context.Set<TEntity>()
                    .FirstOrDefault(where);
        }

        public virtual int Count()
        {
            return context.Set<TEntity>().Count();
        }

        public virtual int Count(Func<TEntity, bool> where)
        {
            return context.Set<TEntity>().Count(where);
        }

        public virtual void Dispose()
        {
            context.Dispose();
        }
    }
}
