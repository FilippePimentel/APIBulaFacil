using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Entities
{
    public class Farmacia
    {
        public virtual int IdFarmacia { get; set; }
        public virtual string Cnpj { get; set; }
        public virtual string RazaoSocial { get; set; }
        public virtual string Telefone { get; set; }
        public virtual string Email { get; set; }
        public virtual string Site { get; set; }
        public virtual Endereco Endereco { get; set; }

        public virtual ICollection<MedicamentoFarmacia> MedicamentosFarmacias { get; set; }
    }
}
