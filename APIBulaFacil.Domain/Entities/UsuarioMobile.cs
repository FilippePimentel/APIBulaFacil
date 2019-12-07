using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Entities
{
    public class UsuarioMobile : Usuario
    {
        public virtual string Cpf { get; set; }
        public virtual string Sexo { get; set; }
        public virtual DateTime Nascimento { get; set; }
    }
}
