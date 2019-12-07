using APIBulaFacil.Application.ViewModels.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.UsuarioMobile
{
    public class UsuarioMobileCadastroViewModel : UsuarioCadastroViewModel
    {
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public char Sexo { get; set; }
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string Nascimento { get; set; }
    }
}