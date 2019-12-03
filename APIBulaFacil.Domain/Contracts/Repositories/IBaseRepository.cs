using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Contracts.Repositories
{
    public interface IBaseRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        void Modify(TEntity obj);
        void Remove(TEntity obj);

        List<TEntity> GetAll();
        List<TEntity> GetAll(Func<TEntity, bool> where);
        TEntity GetById(TKey key);
        TEntity Get(Func<TEntity, bool> where);
        int Count();
        int Count(Func<TEntity, bool> where);
    }
}
