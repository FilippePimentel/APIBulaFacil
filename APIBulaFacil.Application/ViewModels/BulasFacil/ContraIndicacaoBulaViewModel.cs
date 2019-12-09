using System.ComponentModel.DataAnnotations;

namespace APIBulaFacil.Application.ViewModels.BulasFacil
{
    public class ContraIndicacaoBulaViewModel
    {
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public int IdContraIndicacao { get; set; }
    }
}
