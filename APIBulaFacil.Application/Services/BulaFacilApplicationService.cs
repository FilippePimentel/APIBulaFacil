using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.BulasFacil;
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
    public class BulaFacilApplicationService : IBulaFacilApplicationService
    {
        private readonly IBulaFacilDomainService domainService;

        public BulaFacilApplicationService(IBulaFacilDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(BulaFacilCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<BulaFacil>(model));
        }

        public void Alterar(BulaFacilEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<BulaFacil>(model));
        }

        public void Remover(int idBulaFacil)
        {
            var endereco = domainService.ObterPorId(idBulaFacil);
            if (endereco != null)
            {
                domainService.Excluir(endereco);
            }
            else
            {
                throw new Exception("Bula não encontrada.");
            }
        }

        public List<BulaFacilConsultaViewModel> ObterTodos()
        {
            var bulasFacil = domainService.ObterTodos();
            return Mapper.Map<List<BulaFacilConsultaViewModel>>(bulasFacil);
        }

        public BulaFacilConsultaViewModel ObterPorId(int idBulaFacil)
        {
            var bulaFacil = domainService.ObterPorId(idBulaFacil);
            if (bulaFacil != null)
                return Mapper.Map<BulaFacilConsultaViewModel>(bulaFacil);
            else
                throw new Exception("Bula não encontrada.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}