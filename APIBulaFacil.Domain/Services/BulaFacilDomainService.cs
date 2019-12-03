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
    public class BulaFacilDomainService : BaseDomainService<BulaFacil, Int32>, IBulaFacilDomainService
    {
        private readonly IUnitOfWork repository;
        public BulaFacilDomainService(IUnitOfWork repository) : base(repository.BulaFacilRepository)
        {
            this.repository = repository;
        }
    }
}