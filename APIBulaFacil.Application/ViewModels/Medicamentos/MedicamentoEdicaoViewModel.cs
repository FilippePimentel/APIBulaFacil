using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Medicamentos
{
    public class MedicamentoEdicaoViewModel
    {
        public int IdMedicamento { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Tipo { get; set; }
        public string Laboratorio { get; set; }
    }
}
