using APIBulaFacil.Application.ViewModels.Farmacias;
using APIBulaFacil.Application.ViewModels.Medicamentos;

namespace APIBulaFacil.Application.ViewModels.MedicamentoFarmacias
{
    public class MedicamentoFarmaciaConsultaViewModel
    {
        public int IdMedicamentoFarmacia { get; set; }
        public string Apresentacao { get; set; }
        public string Concentracao { get; set; }
        public decimal Preco { get; set; }
        public string Inicio { get; set; }
        public string Fim { get; set; }

        #region Relacionamentos
        public FarmaciaConsultaViewModel Farmacia { get; set; }
        public MedicamentoConsultaViewModel Medicamento { get; set; }
        #endregion
    }
}
