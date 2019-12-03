using APIBulaFacil.Application.ViewModels.Medicamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface IMedicamentoApplicationService : IDisposable
    {
        void Incluir(MedicamentoCadastroViewModel model);
        void Alterar(MedicamentoEdicaoViewModel model);
        void Remover(int idMedicamento);

        List<MedicamentoConsultaViewModel> ObterTodos();
        MedicamentoConsultaViewModel ObterPorId(int idMedicamento);
    }
}
