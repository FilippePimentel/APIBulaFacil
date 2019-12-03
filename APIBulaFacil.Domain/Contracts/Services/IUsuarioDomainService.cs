using APIBulaFacil.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Contracts.Services
{
    public interface IUsuarioDomainService : IBaseDomainService<Usuario,Int32>
    {
        Usuario Find(string email, string senha);
    }
}
