using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.MedicamentoFarmacias;
using APIBulaFacil.Domain.Contracts.Services;
using APIBulaFacil.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIBulaFacil.Domain.Services;

namespace APIBulaFacil.Application.Services
{
    public class MedicamentoFarmaciaApplicationService : IMedicamentoFarmaciaApplicationService
    {
        private readonly IMedicamentoFarmaciaDomainService domainService;

        public MedicamentoFarmaciaApplicationService(IMedicamentoFarmaciaDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(MedicamentoFarmaciaCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<MedicamentoFarmacia>(model));
        }

        public void Alterar(MedicamentoFarmaciaEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<MedicamentoFarmacia>(model));
        }

        public void Remover(int idMedicamentoFarmacia)
        {
            var MedicamentoFarmacia = domainService.ObterPorId(idMedicamentoFarmacia);
            if (MedicamentoFarmacia != null)
            {
                domainService.Excluir(MedicamentoFarmacia);
            }
            else
            {
                throw new Exception("Medicamento-Farmacia não encontrado.");
            }
        }

        public List<MedicamentoFarmaciaConsultaViewModel> ObterTodos()
        {
            var MedicamentoFarmacias = domainService.ObterTodos();
            return Mapper.Map<List<MedicamentoFarmaciaConsultaViewModel>>(MedicamentoFarmacias);
        }

        public MedicamentoFarmaciaConsultaViewModel ObterPorId(int idMedicamentoFarmacia)
        {
            var MedicamentoFarmacia = domainService.ObterPorId(idMedicamentoFarmacia);
            if (MedicamentoFarmacia != null)
                return Mapper.Map<MedicamentoFarmaciaConsultaViewModel>(MedicamentoFarmacia);
            else
                throw new Exception("Medicamento-Farmacia não encontrado.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}

