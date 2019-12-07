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
    public class UsuarioMobileDomainService : BaseDomainService<UsuarioMobile, Int32>, IUsuarioMobileDomainService
    {
        private readonly IUnitOfWork repository;
        public UsuarioMobileDomainService(IUnitOfWork repository) : base(repository.UsuarioMobileRepository)
        {
            this.repository = repository;
        }
        
    }
}
