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
    public class UsuarioDomainService : BaseDomainService<Usuario, Int32>, IUsuarioDomainService
    {
        private readonly IUnitOfWork repository;
        public UsuarioDomainService(IUnitOfWork repository) : base(repository.UsuarioRepository)
        {
            this.repository = repository;
        }

        public Usuario Find(string email, string senha)
        {
            return repository.UsuarioRepository.Find(email, senha);           
        }

    }
}
