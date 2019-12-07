using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Indicacoes
{
    public class IndicacaoEdicaoViewModel
    {
        public int IdIndicacao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string DescricaoIndicacao { get; set; }
    }
}
