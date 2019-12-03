using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.ContraIndicacoes;
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
    public class ContraIndicacaoApplicationService : IContraIndicacaoApplicationService
    {
        private readonly IContraIndicacaoDomainService domainService;

        public ContraIndicacaoApplicationService(IContraIndicacaoDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(ContraIndicacaoCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<ContraIndicacao>(model));
        }

        public void Alterar(ContraIndicacaoEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<ContraIndicacao>(model));
        }

        public void Remover(int idContraIndicacao)
        {
            var contraIndicacao = domainService.ObterPorId(idContraIndicacao);
            if (contraIndicacao != null)
            {
                domainService.Excluir(contraIndicacao);
            }
            else
            {
                throw new Exception("Contra indicação não encontrada.");
            }
        }

        public List<ContraIndicacaoConsultaViewModel> ObterTodos()
        {
            var contraIndicacoes = domainService.ObterTodos();
            return Mapper.Map<List<ContraIndicacaoConsultaViewModel>>(contraIndicacoes);
        }

        public ContraIndicacaoConsultaViewModel ObterPorId(int idContraIndicacao)
        {
            var contraIndicacao = domainService.ObterPorId(idContraIndicacao);
            if (contraIndicacao != null)
                return Mapper.Map<ContraIndicacaoConsultaViewModel>(contraIndicacao);
            else
                throw new Exception("Contra indicação não encontrada.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}