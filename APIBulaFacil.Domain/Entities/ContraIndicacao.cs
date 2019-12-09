using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Entities
{
    public class ContraIndicacao
    {
        public int IdContraIndicacao { get; set; }
        public string DescricaoContraIndicacao { get; set; }
        public virtual ICollection<BulaFacil> BulasFaceis { get; set; }
    }
}
