using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.UnidadesMedida
{
    public class UnidadeMedidaEdicaoViewModel
    {
        public int IdUnidadeMedida { get; set; }
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string Tipo { get; set; }
    }
}
