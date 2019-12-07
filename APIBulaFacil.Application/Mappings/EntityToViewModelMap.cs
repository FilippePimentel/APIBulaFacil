using APIBulaFacil.Application.ViewModels.BulasFacil;
using APIBulaFacil.Application.ViewModels.ContraIndicacoes;
using APIBulaFacil.Application.ViewModels.Enderecos;
using APIBulaFacil.Application.ViewModels.Farmacias;
using APIBulaFacil.Application.ViewModels.Indicacoes;
using APIBulaFacil.Application.ViewModels.MedicamentoFarmacias;
using APIBulaFacil.Application.ViewModels.Medicamentos;
using APIBulaFacil.Application.ViewModels.ModosDeUso;
using APIBulaFacil.Application.ViewModels.Substancias;
using APIBulaFacil.Application.ViewModels.UnidadesMedida;
using APIBulaFacil.Application.ViewModels.Usuarios;
using APIBulaFacil.Domain.Entities;
using AutoMapper;

namespace APIBulaFacil.Application.Mappings
{
    public class EntityToViewModelMap : Profile
    {
        public EntityToViewModelMap()
        {
            CreateMap<Usuario, UsuarioConsultaViewModel>();
            CreateMap<Endereco, EnderecoConsultaViewModel>();
            CreateMap<Farmacia, FarmaciaConsultaViewModel>();
            CreateMap<ContraIndicacao, ContraIndicacaoConsultaViewModel>();
            CreateMap<Indicacao, IndicacaoConsultaViewModel>();
            CreateMap<Medicamento, MedicamentoConsultaViewModel>();
            CreateMap<ModoDeUso, ModoDeUsoConsultaViewModel>();
            CreateMap<Substancia, SubstanciaConsultaViewModel>();
            CreateMap<UnidadeMedida, UnidadeMedidaConsultaViewModel>();
            CreateMap<BulaFacil, BulaFacilConsultaViewModel>();
            CreateMap<MedicamentoFarmaciaConsultaViewModel, MedicamentoFarmacia>();
        }
    }
}
