using APIBulaFacil.Domain.Contracts.Repositories;
using APIBulaFacil.Domain.Entities;
using APIBulaFacil.Infra.Data.Context;
using APIBulaFacil.Infra.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Infra.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario, Int32>, IUsuarioRepository
    {
        private readonly DataContext context;

        public UsuarioRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public Usuario Find(string email, string senha)
        {
            senha = Criptografia.EncryptMD5(senha);
            using (DataContext con = new DataContext())
            {
                return con.Usuario.SingleOrDefault(u => u.Email.Equals(email) && u.Senha.Equals(senha));
            }
        }
    
        
    }
}
