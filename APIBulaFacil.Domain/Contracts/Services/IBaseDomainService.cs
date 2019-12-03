using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Contracts.Services
{
    public interface IBaseDomainService<TEntity, Tkey> : IDisposable
        where TEntity : class
    {
        void Incluir(TEntity obj);
        void Alterar(TEntity obj);
        void Excluir(TEntity obj);

        List<TEntity> ObterTodos();
        TEntity ObterPorId(Tkey key);
    }
}
