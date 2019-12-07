using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.ModosDeUso
{
    public class ModoDeUsoCadastroViewModel
    {
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string DescricaoAdministracao { get; set; }
    }
}
