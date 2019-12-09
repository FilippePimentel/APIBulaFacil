using APIBulaFacil.Application.ViewModels.Posologias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface IPosologiaApplicationService : IDisposable
    {
        void Incluir(PosologiaCadastroViewModel model);
        void Alterar(PosologiaEdicaoViewModel model);
        void Remover(int idPosologia);

        List<PosologiaConsultaViewModel> ObterTodos();
        PosologiaConsultaViewModel ObterPorId(int idPosologia);
    }
}
