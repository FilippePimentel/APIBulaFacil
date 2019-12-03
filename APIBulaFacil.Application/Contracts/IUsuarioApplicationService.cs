using APIBulaFacil.Application.ViewModels.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface IUsuarioApplicationService : IDisposable
    {
        void Incluir(UsuarioCadastroViewModel model);
        void Alterar(UsuarioEdicaoViewModel model);
        void Remover(int idUsuario);

        List<UsuarioConsultaViewModel> ObterTodos();
        UsuarioConsultaViewModel ObterPorId(int idUsuario);
        UsuarioConsultaViewModel ObterParaValidar(string email, string senha);
    }
}
