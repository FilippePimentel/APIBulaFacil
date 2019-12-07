using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Substancias
{
   public class SubstanciaCadastroViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }
        public string Concentracao { get; set; }
    }
}
