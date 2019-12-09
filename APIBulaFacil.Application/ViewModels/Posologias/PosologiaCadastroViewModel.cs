using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Posologias
{
    public class PosologiaCadastroViewModel
    {
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        [MaxLength(100, ErrorMessage = "{0} : Informe no máximo {1} caracteres.")]
        public  string UnidadeMedida { get; set; }
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public  decimal Quantidade { get; set; }
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        [MaxLength(150, ErrorMessage = "{0} : Informe no máximo {1} caracteres.")]
        public  string Intervalo { get; set; }
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        [MaxLength(150, ErrorMessage = "{0} : Informe no máximo {1} caracteres.")]
        public  string ModoDeUso { get; set; }
    }
}
