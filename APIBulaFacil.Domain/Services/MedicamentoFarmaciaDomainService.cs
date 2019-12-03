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
    public class MedicamentoFarmaciaDomainService : BaseDomainService<MedicamentoFarmacia, Int32>, IMedicamentoFarmaciaDomainService
    {
        private readonly IUnitOfWork repository;
        public MedicamentoFarmaciaDomainService(IUnitOfWork repository) : base(repository.MedicamentoFarmaciaRepository)
        {
            this.repository = repository;
        }
    }
}
