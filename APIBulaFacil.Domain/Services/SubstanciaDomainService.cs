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
    public class SubstanciaDomainService : BaseDomainService<Substancia, Int32>, ISubstanciaDomainService
    {
        private readonly IUnitOfWork repository;
        public SubstanciaDomainService(IUnitOfWork repository) : base(repository.SubstanciaRepository)
        {
            this.repository = repository;
        }
    }
}