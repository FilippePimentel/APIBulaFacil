using APIBulaFacil.Domain.Contracts.Repositories;
using APIBulaFacil.Domain.Contracts.Services;
using APIBulaFacil.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Services
{
    public class UnidadeMedidaDomainService : BaseDomainService<UnidadeMedida, Int32>, IUnidadeMedidaDomainService
    {
        private readonly IUnitOfWork repository;
        public UnidadeMedidaDomainService(IUnitOfWork repository) : base(repository.UnidadeMedidaRepository)
        {
            this.repository = repository;
        }
    }
}