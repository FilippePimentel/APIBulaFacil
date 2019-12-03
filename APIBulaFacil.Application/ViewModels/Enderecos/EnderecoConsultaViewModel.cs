using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Enderecos
{
   public class EnderecoConsultaViewModel
    {
        public int IdEndereco { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Pluscode { get; set; }
    }
}
