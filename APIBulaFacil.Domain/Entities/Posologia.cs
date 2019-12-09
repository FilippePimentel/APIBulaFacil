using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Entities
{
    public class Posologia
    {
        public virtual int IdPosologia { get; set; }
        public virtual string UnidadeMedida { get; set; }
        public virtual decimal Quantidade { get; set; }
        public virtual string Intervalo { get; set; }
        public virtual string ModoDeUso { get; set; }
        public virtual ICollection<BulaFacil> BulasFaceis { get; set; }
    }
}
