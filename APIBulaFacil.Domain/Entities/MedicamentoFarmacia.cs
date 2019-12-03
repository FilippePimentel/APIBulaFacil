using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Domain.Entities
{
    public class MedicamentoFarmacia
    {
        public virtual int IdMedicamentoFarmacia { get; set; }
        public virtual string Apresentacao { get; set; }
        public virtual string Concentracao { get; set; }
        public virtual decimal Preco { get; set; }
        public virtual DateTime Inicio { get; set; }
        public virtual DateTime? Fim { get; set; }
        public virtual int IdFarmacia { get; set; }
        public virtual int IdMedicamento { get; set; }

        #region Relacionamentos
        public virtual Farmacia Farmacia { get; set; }
        public virtual Medicamento Medicamento { get; set; }
        #endregion
    }
}
