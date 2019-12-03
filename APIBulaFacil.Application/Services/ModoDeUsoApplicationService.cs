using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.ModosDeUso;
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
    public class ModoDeUsoApplicationService : IModoDeUsoApplicationService
    {
        private readonly IModoDeUsoDomainService domainService;

        public ModoDeUsoApplicationService(IModoDeUsoDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(ModoDeUsoCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<ModoDeUso>(model));
        }

        public void Alterar(ModoDeUsoEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<ModoDeUso>(model));
        }

        public void Remover(int idModoDeUso)
        {
            var modoDeUso = domainService.ObterPorId(idModoDeUso);
            if (modoDeUso != null)
            {
                domainService.Excluir(modoDeUso);
            }
            else
            {
                throw new Exception("Modo de uso não encontrado.");
            }
        }

        public List<ModoDeUsoConsultaViewModel> ObterTodos()
        {
            var modosDeUso = domainService.ObterTodos();
            return Mapper.Map<List<ModoDeUsoConsultaViewModel>>(modosDeUso);
        }

        public ModoDeUsoConsultaViewModel ObterPorId(int idModoDeUso)
        {
            var endereco = domainService.ObterPorId(idModoDeUso);
            if (endereco != null)
                return Mapper.Map<ModoDeUsoConsultaViewModel>(endereco);
            else
                throw new Exception("Modo de uso não encontrado.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}
