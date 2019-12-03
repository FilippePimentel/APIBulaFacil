using APIBulaFacil.Application.ViewModels.BulasFacil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface IBulaFacilApplicationService : IDisposable
    {
        void Incluir(BulaFacilCadastroViewModel model);
        void Alterar(BulaFacilEdicaoViewModel model);
        void Remover(int idBulaFacil);

        List<BulaFacilConsultaViewModel> ObterTodos();
        BulaFacilConsultaViewModel ObterPorId(int idBulaFacil);
    }
}
