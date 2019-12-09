using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.Posologias;
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
    public class PosologiaApplicationService : IPosologiaApplicationService
    {
        private readonly IPosologiaDomainService domainService;

        public PosologiaApplicationService(IPosologiaDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(PosologiaCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<Posologia>(model));
        }

        public void Alterar(PosologiaEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<Posologia>(model));
        }

        public void Remover(int idPosologia)
        {
            var Posologia = domainService.ObterPorId(idPosologia);
            if (Posologia != null)
            {
                domainService.Excluir(Posologia);
            }
            else
            {
                throw new Exception("Posologia não encontrada.");
            }
        }

        public List<PosologiaConsultaViewModel> ObterTodos()
        {
            var enderecos = domainService.ObterTodos();
            return Mapper.Map<List<PosologiaConsultaViewModel>>(enderecos);
        }

        public PosologiaConsultaViewModel ObterPorId(int idPosologia)
        {
            var endereco = domainService.ObterPorId(idPosologia);
            if (endereco != null)
                return Mapper.Map<PosologiaConsultaViewModel>(endereco);
            else
                throw new Exception("Posologia não encontrada.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}