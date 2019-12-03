using APIBulaFacil.Application.ViewModels.Substancias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface ISubstanciaApplicationService : IDisposable
    {
        void Incluir(SubstanciaCadastroViewModel model);
        void Alterar(SubstanciaEdicaoViewModel model);
        void Remover(int idSubstancia);

        List<SubstanciaConsultaViewModel> ObterTodos();
        SubstanciaConsultaViewModel ObterPorId(int idSubstancia);
    }
}
