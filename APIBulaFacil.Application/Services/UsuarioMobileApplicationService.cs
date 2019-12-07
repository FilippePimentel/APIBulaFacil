using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.UsuarioMobile;
using APIBulaFacil.Domain.Contracts.Services;
using APIBulaFacil.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace APIBulaFacil.Application.Services
{
    public class UsuarioMobileApplicationService : IUsuarioMobileApplicationService
    {
        private readonly IUsuarioMobileDomainService domainService;

        public UsuarioMobileApplicationService(IUsuarioMobileDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(UsuarioMobileCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<UsuarioMobile>(model));
        }

        public void Alterar(UsuarioMobileEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<UsuarioMobile>(model));
        }

        public void Remover(int idUsuarioMobile)
        {
            var usuarioMobile = domainService.ObterPorId(idUsuarioMobile);
            if (usuarioMobile != null)
            {
                domainService.Excluir(usuarioMobile);
            }
            else
            {
                throw new Exception("Usuário não encontrado.");
            }
        }

        public List<UsuarioMobileConsultaViewModel> ObterTodos()
        {
            var Usuarios = domainService.ObterTodos();
            return Mapper.Map<List<UsuarioMobileConsultaViewModel>>(Usuarios);
        }

        public UsuarioMobileConsultaViewModel ObterPorId(int idUsuarioMobile)
        {
            var usuarioMobile = domainService.ObterPorId(idUsuarioMobile);
            if (usuarioMobile != null)
                return Mapper.Map<UsuarioMobileConsultaViewModel>(usuarioMobile);
            else
                throw new Exception("Usuário não encontrado.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}
