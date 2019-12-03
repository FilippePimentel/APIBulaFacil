using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.Usuarios;
using APIBulaFacil.Domain.Contracts.Services;
using APIBulaFacil.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Services
{
    public class UsuarioApplicationService : IUsuarioApplicationService
    {
        private readonly IUsuarioDomainService domainService;

        public UsuarioApplicationService(IUsuarioDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(UsuarioCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<Usuario>(model));
        }

        public void Alterar(UsuarioEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<Usuario>(model));
        }

        public void Remover(int idUsuario)
        {
            var usuario = domainService.ObterPorId(idUsuario);
            if (usuario != null)
            {
                domainService.Excluir(usuario);
            }
            else
            {
                throw new Exception("Usuário não encontrado.");
            }
        }
        public List<UsuarioConsultaViewModel> ObterTodos()
        {
            var usuarios = domainService.ObterTodos();
            return Mapper.Map<List<UsuarioConsultaViewModel>>(usuarios);
        }
        public UsuarioConsultaViewModel ObterPorId(int idUsuario)
        {
            var usuario = domainService.ObterPorId(idUsuario);
            if (usuario != null)
                return Mapper.Map<UsuarioConsultaViewModel>(usuario);
            else
                throw new Exception("Usuário não encontrado.");
        }

        public UsuarioConsultaViewModel ObterParaValidar(string email, string senha)
        {
            var usuario = domainService.Find(email,senha);
            if (usuario != null)
                return Mapper.Map<UsuarioConsultaViewModel>(usuario);
            else
                throw new Exception("Usuário não encontrado.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}
