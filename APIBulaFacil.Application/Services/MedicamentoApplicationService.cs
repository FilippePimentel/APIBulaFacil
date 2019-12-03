using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.Medicamentos;
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
    public class MedicamentoApplicationService : IMedicamentoApplicationService
    {
        private readonly IMedicamentoDomainService domainService;

        public MedicamentoApplicationService(IMedicamentoDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(MedicamentoCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<Medicamento>(model));
        }

        public void Alterar(MedicamentoEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<Medicamento>(model));
        }

        public void Remover(int idMedicamento)
        {
            var medicamento = domainService.ObterPorId(idMedicamento);
            if (medicamento != null)
            {
                domainService.Excluir(medicamento);
            }
            else
            {
                throw new Exception("Medicamento não encontrado.");
            }
        }

        public List<MedicamentoConsultaViewModel> ObterTodos()
        {
            var enderecos = domainService.ObterTodos();
            return Mapper.Map<List<MedicamentoConsultaViewModel>>(enderecos);
        }

        public MedicamentoConsultaViewModel ObterPorId(int idMedicamento)
        {
            var endereco = domainService.ObterPorId(idMedicamento);
            if (endereco != null)
                return Mapper.Map<MedicamentoConsultaViewModel>(endereco);
            else
                throw new Exception("Medicamento não encontrado.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}