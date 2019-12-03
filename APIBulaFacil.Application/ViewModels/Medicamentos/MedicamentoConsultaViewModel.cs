using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Medicamentos
{
    public class MedicamentoConsultaViewModel
    {
        public int IdMedicamento { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Laboratorio { get; set; }
    }
}
