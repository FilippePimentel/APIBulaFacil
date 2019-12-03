using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.ViewModels.Enderecos;
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
    public class EnderecoApplicationService : IEnderecoApplicationService
    {
        private readonly IEnderecoDomainService domainService;

        public EnderecoApplicationService(IEnderecoDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Incluir(EnderecoCadastroViewModel model)
        {
            domainService.Incluir(Mapper.Map<Endereco>(model));
        }

        public void Alterar(EnderecoEdicaoViewModel model)
        {
            domainService.Alterar(Mapper.Map<Endereco>(model));
        }

        public void Remover(int idEndereco)
        {
            var endereco = domainService.ObterPorId(idEndereco);
            if (endereco != null)
            {
                domainService.Excluir(endereco);
            }
            else
            {
                throw new Exception("Endereco não encontrado.");
            }
        }

        public List<EnderecoConsultaViewModel> ObterTodos()
        {
            var enderecos = domainService.ObterTodos();
            return Mapper.Map<List<EnderecoConsultaViewModel>>(enderecos);
        }

        public EnderecoConsultaViewModel ObterPorId(int idEndereco)
        {
            var endereco = domainService.ObterPorId(idEndereco);
            if (endereco != null)
                return Mapper.Map<EnderecoConsultaViewModel>(endereco);
            else
                throw new Exception("Endereço não encontrado.");
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}
