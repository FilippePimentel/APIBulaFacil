using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Indicacoes
{
    public class IndicacaoCadastroViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string DescricaoIndicacao { get; set; }
    }
}
