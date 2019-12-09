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
    public class PosologiaDomainService : BaseDomainService<Posologia, Int32>, IPosologiaDomainService
    {
        private readonly IUnitOfWork repository;
        public PosologiaDomainService(IUnitOfWork repository) : base(repository.PosologiaRepository)
        {
            this.repository = repository;
        }
    }
}