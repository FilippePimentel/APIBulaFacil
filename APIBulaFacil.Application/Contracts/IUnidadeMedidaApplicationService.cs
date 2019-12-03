using APIBulaFacil.Application.ViewModels.UnidadesMedida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface IUnidadeMedidaApplicationService : IDisposable
    {
        void Incluir(UnidadeMedidaCadastroViewModel model);
        void Alterar(UnidadeMedidaEdicaoViewModel model);
        void Remover(int idUnidadeMedida);

        List<UnidadeMedidaConsultaViewModel> ObterTodos();
        UnidadeMedidaConsultaViewModel ObterPorId(int idUnidadeMedida);
    }
}
