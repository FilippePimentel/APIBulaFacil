using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.UsuarioMobile
{
    public class UsuarioMobileConsultaViewModel 
    {
        #region Usuario
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        #endregion
        public string Cpf { get; set; }
        public char Sexo { get; set; }
        public string Nascimento { get; set; }
    }
}
