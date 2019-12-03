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
    public class FarmaciaDomainService : BaseDomainService<Farmacia, Int32>, IFarmaciaDomainService
    {
        private readonly IUnitOfWork repository;
        public FarmaciaDomainService(IUnitOfWork repository) : base(repository.FarmaciaRepository)
        {
            this.repository = repository;
        }
        
    }
}
