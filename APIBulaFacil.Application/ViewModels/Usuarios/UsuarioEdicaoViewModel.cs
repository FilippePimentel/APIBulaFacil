using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Usuarios
{
    public class UsuarioEdicaoViewModel
    {
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public int IdUsuario { get; set; }

        [MinLength(5, ErrorMessage = "{0} : Informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "{0} : Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string Nome { get; set; }

        [MinLength(5, ErrorMessage = "{0} : Informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "{0} : Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string Email { get; set; }

        [MinLength(5, ErrorMessage = "{0} : Informe no mínimo {1} caracteres.")]
        [MaxLength(15, ErrorMessage = "{0} : Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string Senha { get; set; }
    }
}
