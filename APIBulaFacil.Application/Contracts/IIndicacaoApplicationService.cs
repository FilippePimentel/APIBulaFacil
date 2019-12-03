using APIBulaFacil.Application.ViewModels.Indicacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface IIndicacaoApplicationService : IDisposable
    {
        void Incluir(IndicacaoCadastroViewModel model);
        void Alterar(IndicacaoEdicaoViewModel model);
        void Remover(int idIndicacao);

        List<IndicacaoConsultaViewModel> ObterTodos();
        IndicacaoConsultaViewModel ObterPorId(int idIndicacao);
    }
}
