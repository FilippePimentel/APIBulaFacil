using APIBulaFacil.Application.ViewModels.Enderecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Farmacias
{
   public class FarmaciaConsultaViewModel
    {
        public int IdFarmacia { get; set; }
        public string RazaoSocial { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public EnderecoConsultaViewModel Endereco { get; set; }
    }
}
