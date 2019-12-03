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
    public class EnderecoDomainService : BaseDomainService<Endereco, Int32>, IEnderecoDomainService
    {
        private readonly IUnitOfWork repository;
        public EnderecoDomainService(IUnitOfWork repository) : base(repository.EnderecoRepository)
        {
            this.repository = repository;
        }
    }
}
