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
    public class BulaFacilCadastroViewModel
    {
        public string Link { get; set; }
        public string Substancia { get; set; }
        public string Valido { get; set; }
        public int IdMedicamento { get; set; }

        public string ContraIndicacao { get; set; }
        public string Indicacao { get; set; }

        public virtual ICollection<PosologiaBulaViewModel> Posologias { get; set; }
        //public virtual ICollection<ContraIndicacaoBulaViewModel> ContraIndicacoes { get; set; }
        //public virtual ICollection<IndicacaoBulaViewModel> Indicacoes { get; set; }
    }
}
