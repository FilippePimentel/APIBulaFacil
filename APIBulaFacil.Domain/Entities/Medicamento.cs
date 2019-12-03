using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Entities
{
    public class Medicamento
    {
        public int IdMedicamento { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Laboratorio { get; set; }
        public virtual ICollection<MedicamentoFarmacia> MedicamentosFarmacias { get; set; }

    }
}
