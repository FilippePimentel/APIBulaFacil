using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Enderecos
{

    public class EnderecoCadastroViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Rua { get; set; }
        public string Complemento { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Uf { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Pluscode { get; set; }
    }
}
