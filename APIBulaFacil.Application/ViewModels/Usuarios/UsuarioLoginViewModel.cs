using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Usuarios
{

    public class UsuarioLoginViewModel
    {
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string Senha { get; set; }
    }
}
