using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Entities
{
    public class Indicacao
    {
        public int IdIndicacao { get; set; }
        public string DescricaoIndicacao { get; set; }
        public virtual ICollection<BulaFacil> BulasFaceis { get; set; }
    }
}
