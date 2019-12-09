using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Entities
{
    public class BulaFacil
    {
        public virtual int IdBulaFacil { get; set; }
        public virtual string Link { get; set; }
        public virtual string Substancia { get; set; }
        public virtual string Valido { get; set; }

        public virtual Medicamento Medicamento { get; set; }
        public virtual ICollection<Posologia> Posologias { get; set; }
        public virtual ICollection<ContraIndicacao> ContraIndicacoes { get; set; }
        public virtual ICollection<Indicacao> Indicacoes { get; set; }
       
    }
}