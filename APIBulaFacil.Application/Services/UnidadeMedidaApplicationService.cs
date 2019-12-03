using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.UnidadesMedida;
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
    public class UnidadeMedidaApplicationService : IUnidadeMedidaApplicationService
    {
        private readonly IUnidadeMedidaDomainService domainService;

        public UnidadeMedidaApplicationService(IUnidadeMedidaDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(UnidadeMedidaCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<UnidadeMedida>(model));
        }

        public void Alterar(UnidadeMedidaEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<UnidadeMedida>(model));
        }

        public void Remover(int idUnidadeMedida)
        {
            var unidadeMedida = domainService.ObterPorId(idUnidadeMedida);
            if (unidadeMedida != null)
            {
                domainService.Excluir(unidadeMedida);
            }
            else
            {
                throw new Exception("Unidade de medida não encontrada.");
            }
        }

        public List<UnidadeMedidaConsultaViewModel> ObterTodos()
        {
            var unidadesMedida = domainService.ObterTodos();
            return Mapper.Map<List<UnidadeMedidaConsultaViewModel>>(unidadesMedida);
        }

        public UnidadeMedidaConsultaViewModel ObterPorId(int idUnidadeMedida)
        {
            var unidadeMedida = domainService.ObterPorId(idUnidadeMedida);
            if (unidadeMedida != null)
                return Mapper.Map<UnidadeMedidaConsultaViewModel>(unidadeMedida);
            else
                throw new Exception("Unidade de medida não encontrada.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}