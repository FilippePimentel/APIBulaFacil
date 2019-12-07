using APIBulaFacil.Application.ViewModels.UsuarioMobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Contracts
{
    public interface IUsuarioMobileApplicationService : IDisposable
    {
        void Incluir(UsuarioMobileCadastroViewModel model);
        void Alterar(UsuarioMobileEdicaoViewModel model);
        void Remover(int idFarmacia);

        List<UsuarioMobileConsultaViewModel> ObterTodos();
        UsuarioMobileConsultaViewModel ObterPorId(int idUsuarioMobile);
    }
}
