using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.BulasFacil
{
    public class BulaFacilEdicaoViewModel
    {
        public int IdBulaFacil { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Link { get; set; }
    }
}
