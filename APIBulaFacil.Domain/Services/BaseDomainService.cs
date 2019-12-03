using APIBulaFacil.Domain.Contracts.Repositories;
using APIBulaFacil.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Services
{
    public abstract class BaseDomainService<TEntity,TKey> : IBaseDomainService<TEntity,TKey> where TEntity : class
    {

        private readonly IBaseRepository<TEntity, TKey> repository;

        public BaseDomainService(IBaseRepository<TEntity,TKey> repository)
        {
            this.repository = repository;
        }

        public void Incluir(TEntity obj)
        {
            repository.Add(obj);
        }

        public void Alterar(TEntity obj)
        {
            repository.Modify(obj);
        }

        public void Excluir(TEntity obj)
        {
            repository.Remove(obj);
        }

        public List<TEntity> ObterTodos()
        {
           return  repository.GetAll();
        }

        public TEntity ObterPorId(TKey key)
        {
            return repository.GetById(key);
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
}
