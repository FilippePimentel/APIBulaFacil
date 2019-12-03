using APIBulaFacil.Application.ViewModels.ModosDeUso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface IModoDeUsoApplicationService : IDisposable
    {
        void Incluir(ModoDeUsoCadastroViewModel model);
        void Alterar(ModoDeUsoEdicaoViewModel model);
        void Remover(int idModoDeUso);

        List<ModoDeUsoConsultaViewModel> ObterTodos();
        ModoDeUsoConsultaViewModel ObterPorId(int idModoDeUso);
    }
}
