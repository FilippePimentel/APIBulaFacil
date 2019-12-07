using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.BulasFacil
{
    public class BulaFacilCadastroViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Link { get; set; }
    }
}
