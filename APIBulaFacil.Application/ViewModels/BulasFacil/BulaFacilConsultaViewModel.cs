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
    public class BulaFacilConsultaViewModel
    {
        public int IdBulaFacil { get; set; }
        public string Link { get; set; }
        public string Substancia { get; set; }
        public string Valido { get; set; }
        public MedicamentoConsultaViewModel Medicamento { get; set; }

        public virtual ICollection<PosologiaConsultaViewModel> Posologias { get; set; }
        public virtual ICollection<ContraIndicacaoConsultaViewModel> ContraIndicacoes { get; set; }
        public virtual ICollection<IndicacaoConsultaViewModel> Indicacoes { get; set; }
    }
}
