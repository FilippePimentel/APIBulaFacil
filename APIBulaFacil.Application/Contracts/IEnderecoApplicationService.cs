using APIBulaFacil.Application.ViewModels.Enderecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface IEnderecoApplicationService : IDisposable
    {
        void Incluir(EnderecoCadastroViewModel model);
        void Alterar(EnderecoEdicaoViewModel model);
        void Remover(int idEndereco);

        List<EnderecoConsultaViewModel> ObterTodos();
        EnderecoConsultaViewModel ObterPorId(int idEndereco);
    }
}
