using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.MedicamentoFarmacias
{
    public class MedicamentoFarmaciaCadastroViewModel
    {
        [MinLength(6, ErrorMessage = "{0}: Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "{0}: Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "{0}: {0} : Campo obrigatório.")]
        public string Apresentacao { get; set; }
        [MinLength(6, ErrorMessage = "{0}: Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "{0}: Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "{0}: {0} : Campo obrigatório.")]
        public string Concentracao { get; set; }
        [Required(ErrorMessage = "{0}: {0} : Campo obrigatório.")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "{0}: {0} : Campo obrigatório.")]
        public string Inicio { get; set; }
        public string Fim { get; set; }
        
        #region Relacionamentos
        [Required(ErrorMessage = "{0}: {0} : Campo obrigatório.")]
        public int IdFarmacia { get; set; }
        [Required(ErrorMessage = "{0}: {0} : Campo obrigatório.")]
        public int IdMedicamento { get; set; }
        #endregion
        
    }
}
