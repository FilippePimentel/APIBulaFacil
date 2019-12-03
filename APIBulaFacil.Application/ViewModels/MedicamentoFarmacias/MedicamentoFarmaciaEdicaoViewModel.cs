using System.ComponentModel.DataAnnotations;

namespace APIBulaFacil.Application.ViewModels.MedicamentoFarmacias
{
    public class MedicamentoFarmaciaEdicaoViewModel
    {
        [Required(ErrorMessage = "{0}: Campo obrigatório.")]
        public int IdMedicamentoFarmacia { get; set; }

        [MinLength(6, ErrorMessage = "{0}: Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "{0}: Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "{0}: Campo obrigatório.")]
        public string Apresentacao { get; set; }

        [MinLength(6, ErrorMessage = "{0}: Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "{0}: Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "{0}: Campo obrigatório.")]
        public string Concentracao { get; set; }

        [Required(ErrorMessage = "{0}: Campo obrigatório.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "{0}: Campo obrigatório.")]
        public string Inicio { get; set; }

        public string Fim { get; set; }

        #region Relacionamentos
        [Required(ErrorMessage = "{0}: Campo obrigatório.")]
        public int IdFarmacia { get; set; }
        [Required(ErrorMessage = "{0}: Campo obrigatório.")]
        public int IdMedicamento { get; set; }
        #endregion
    }
}
