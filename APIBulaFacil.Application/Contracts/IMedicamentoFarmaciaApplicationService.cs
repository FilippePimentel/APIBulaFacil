using APIBulaFacil.Application.ViewModels.MedicamentoFarmacias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface IMedicamentoFarmaciaApplicationService : IDisposable
    {
        void Incluir(MedicamentoFarmaciaCadastroViewModel model);
        void Alterar(MedicamentoFarmaciaEdicaoViewModel model);
        void Remover(int id);

        List<MedicamentoFarmaciaConsultaViewModel> ObterTodos();
        MedicamentoFarmaciaConsultaViewModel ObterPorId(int id);
    }
}
