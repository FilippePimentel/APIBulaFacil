using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.Posologias
{
    public class PosologiaConsultaViewModel
    {
        public int IdPosologia { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal Quantidade { get; set; }
        public string Intervalo { get; set; }
        public string ModoDeUso { get; set; }
    }
}
