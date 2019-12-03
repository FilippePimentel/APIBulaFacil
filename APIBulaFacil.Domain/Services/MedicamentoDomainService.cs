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
    public class MedicamentoDomainService : BaseDomainService<Medicamento, Int32>, IMedicamentoDomainService
    {
        private readonly IUnitOfWork repository;
        public MedicamentoDomainService(IUnitOfWork repository) : base(repository.MedicamentoRepository)
        {
            this.repository = repository;
        }
    }
}