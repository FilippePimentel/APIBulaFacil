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
    public class IndicacaoDomainService : BaseDomainService<Indicacao, Int32>, IIndicacaoDomainService
    {
        private readonly IUnitOfWork repository;
        public IndicacaoDomainService(IUnitOfWork repository) : base(repository.IndicacaoRepository)
        {
            this.repository = repository;
        }
    }
}