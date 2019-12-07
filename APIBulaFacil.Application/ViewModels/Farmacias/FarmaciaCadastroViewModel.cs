using APIBulaFacil.Application.ViewModels.Enderecos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Farmacias
{

    public class FarmaciaCadastroViewModel
    {
        [MinLength(14, ErrorMessage = "{0} : Informe no mínimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "{0} : Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cnpj { get; set; }

        [MinLength(5, ErrorMessage = "{0} : Informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "{0} : Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string RazaoSocial { get; set; }

        [MinLength(8, ErrorMessage = "{0} : Informe no mínimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "{0} : Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Telefone { get; set; }

        [MaxLength(100, ErrorMessage = "{0} : Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Email { get; set; }

        [MaxLength(100, ErrorMessage = "{0} : Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Site { get; set; }

        #region Endereco

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

        #endregion
    }
}
