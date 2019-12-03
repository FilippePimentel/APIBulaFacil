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
    public class ModoDeUsoDomainService : BaseDomainService<ModoDeUso, Int32>, IModoDeUsoDomainService
    {
        private readonly IUnitOfWork repository;
        public ModoDeUsoDomainService(IUnitOfWork repository) : base(repository.ModoDeUsoRepository)
        {
            this.repository = repository;
        }
    }
}