using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Entities
{
    public class Medicamento
    {
        public virtual int IdMedicamento { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Laboratorio { get; set; }
        public virtual ICollection<MedicamentoFarmacia> MedicamentosFarmacias { get; set; }
        public virtual ICollection<BulaFacil> Bulas { get; set; }
    }
}
