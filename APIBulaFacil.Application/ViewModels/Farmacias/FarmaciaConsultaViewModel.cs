using APIBulaFacil.Application.ViewModels.Enderecos;
using APIBulaFacil.Application.ViewModels.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Farmacias
{
   public class FarmaciaConsultaViewModel
    {
        #region Usuario
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        #endregion        
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Site { get; set; }
        public EnderecoConsultaViewModel Endereco { get; set; }
    }
}
