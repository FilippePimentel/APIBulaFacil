using APIBulaFacil.Application.ViewModels.Farmacias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface IFarmaciaApplicationService : IDisposable
    {
        void Incluir(FarmaciaCadastroViewModel model);
        void Alterar(FarmaciaEdicaoViewModel model);
        void Remover(int idFarmacia);

        List<FarmaciaConsultaViewModel> ObterTodos();
        FarmaciaConsultaViewModel ObterPorId(int idFarmacia);
    }
}
