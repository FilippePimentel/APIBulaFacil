using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.Farmacias;
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
    public class FarmaciaApplicationService : IFarmaciaApplicationService
    {
        private readonly IFarmaciaDomainService domainService;

        public FarmaciaApplicationService(IFarmaciaDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(FarmaciaCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<Farmacia>(model));
        }

        public void Alterar(FarmaciaEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<Farmacia>(model));
        }

        public void Remover(int idFarmacia)
        {
            var Farmacia = domainService.ObterPorId(idFarmacia);
            if (Farmacia != null)
            {
                domainService.Excluir(Farmacia);
            }
            else
            {
                throw new Exception("Farmacia não encontrada.");
            }
        }

        public List<FarmaciaConsultaViewModel> ObterTodos()
        {
            var Farmacias = domainService.ObterTodos();
            return Mapper.Map<List<FarmaciaConsultaViewModel>>(Farmacias);
        }

        public FarmaciaConsultaViewModel ObterPorId(int idFarmacia)
        {
            var Farmacia = domainService.ObterPorId(idFarmacia);
            if (Farmacia != null)
                return Mapper.Map<FarmaciaConsultaViewModel>(Farmacia);
            else
                throw new Exception("Farmacia não encontrada.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}
