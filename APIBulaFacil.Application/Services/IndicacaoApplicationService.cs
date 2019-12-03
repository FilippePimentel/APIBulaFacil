using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.Indicacoes;
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
    public class IndicacaoApplicationService : IIndicacaoApplicationService
    {
        private readonly IIndicacaoDomainService domainService;

        public IndicacaoApplicationService(IIndicacaoDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(IndicacaoCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<Indicacao>(model));
        }

        public void Alterar(IndicacaoEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<Indicacao>(model));
        }

        public void Remover(int idIndicacao)
        {
            var indicacao = domainService.ObterPorId(idIndicacao);
            if (indicacao != null)
            {
                domainService.Excluir(indicacao);
            }
            else
            {
                throw new Exception("Indicação não encontrada.");
            }
        }

        public List<IndicacaoConsultaViewModel> ObterTodos()
        {
            var indicacoes = domainService.ObterTodos();
            return Mapper.Map<List<IndicacaoConsultaViewModel>>(indicacoes);
        }

        public IndicacaoConsultaViewModel ObterPorId(int idIndicacao)
        {
            var indicacao = domainService.ObterPorId(idIndicacao);
            if (indicacao != null)
                return Mapper.Map<IndicacaoConsultaViewModel>(indicacao);
            else
                throw new Exception("Indicação não encontrado.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}