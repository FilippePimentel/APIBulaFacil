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
    public class ContraIndicacaoDomainService : BaseDomainService<ContraIndicacao, Int32>, IContraIndicacaoDomainService
    {
        private readonly IUnitOfWork repository;
        public ContraIndicacaoDomainService(IUnitOfWork repository) : base(repository.ContraIndicacaoRepository)
        {
            this.repository = repository;
        }
    }
}