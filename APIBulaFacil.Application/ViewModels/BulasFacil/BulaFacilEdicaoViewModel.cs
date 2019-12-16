using APIBulaFacil.Application.ViewModels.ContraIndicacoes;
using APIBulaFacil.Application.ViewModels.Indicacoes;
using APIBulaFacil.Application.ViewModels.Medicamentos;
using APIBulaFacil.Application.ViewModels.Posologias;
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
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public int IdBulaFacil { get; set; }
        public string Link { get; set; }
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string Substancia { get; set; }
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string Valido { get; set; }
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public int IdMedicamento { get; set; }
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string Indicacao { get; set; }
        [Required(ErrorMessage = "{0} : Campo obrigatório.")]
        public string ContraIndicacao { get; set; }
        
        public virtual ICollection<PosologiaBulaViewModel> Posologias { get; set; }
       //public virtual ICollection<ContraIndicacaoBulaViewModel> ContraIndicacoes { get; set; }
       //public virtual ICollection<IndicacaoBulaViewModel> Indicacoes { get; set; }
    }
}

