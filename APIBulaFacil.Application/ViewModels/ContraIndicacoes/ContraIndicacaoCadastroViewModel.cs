using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.ContraIndicacoes
{
    public class ContraIndicacaoCadastroViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string DescricaoContraIndicacao { get; set; }
    }
}
