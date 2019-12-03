using APIBulaFacil.Application.ViewModels.ContraIndicacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface IContraIndicacaoApplicationService : IDisposable
    {
        void Incluir(ContraIndicacaoCadastroViewModel model);
        void Alterar(ContraIndicacaoEdicaoViewModel model);
        void Remover(int idContraIndicacao);

        List<ContraIndicacaoConsultaViewModel> ObterTodos();
        ContraIndicacaoConsultaViewModel ObterPorId(int idContraIndicacao);
    }
}
