using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.Substancias;
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
    public class SubstanciaApplicationService : ISubstanciaApplicationService
    {
        private readonly ISubstanciaDomainService domainService;

        public SubstanciaApplicationService(ISubstanciaDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(SubstanciaCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<Substancia>(model));
        }

        public void Alterar(SubstanciaEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<Substancia>(model));
        }

        public void Remover(int idSubstancia)
        {
            var substancia = domainService.ObterPorId(idSubstancia);
            if (substancia != null)
            {
                domainService.Excluir(substancia);
            }
            else
            {
                throw new Exception("Substância não encontrado.");
            }
        }

        public List<SubstanciaConsultaViewModel> ObterTodos()
        {
            var substancias = domainService.ObterTodos();
            return Mapper.Map<List<SubstanciaConsultaViewModel>>(substancias);
        }

        public SubstanciaConsultaViewModel ObterPorId(int idSubstancia)
        {
            var substancia = domainService.ObterPorId(idSubstancia);
            if (substancia != null)
                return Mapper.Map<SubstanciaConsultaViewModel>(substancia);
            else
                throw new Exception("Substancia não encontrada.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}