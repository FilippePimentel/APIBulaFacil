using APIBulaFacil.Application.ViewModels.BulasFacil;
using APIBulaFacil.Application.ViewModels.ContraIndicacoes;
using APIBulaFacil.Application.ViewModels.Enderecos;
using APIBulaFacil.Application.ViewModels.Farmacias;
using APIBulaFacil.Application.ViewModels.Indicacoes;
using APIBulaFacil.Application.ViewModels.MedicamentoFarmacias;
using APIBulaFacil.Application.ViewModels.Medicamentos;
using APIBulaFacil.Application.ViewModels.Posologias;
using APIBulaFacil.Application.ViewModels.UsuarioMobile;
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
            CreateMap<BulaFacil, BulaFacilConsultaViewModel>();
            CreateMap<MedicamentoFarmacia, MedicamentoFarmaciaConsultaViewModel>()
                .ForMember(dest => dest.NomeMedicamento,
               opts => opts.MapFrom(src => src.Medicamento.Nome))
                .ForMember(dest => dest.NomeFarmacia,
               opts => opts.MapFrom(src => src.Farmacia.Nome));
            CreateMap<UsuarioMobile, UsuarioMobileConsultaViewModel>();
            CreateMap<Posologia, PosologiaConsultaViewModel>();
        }
    }
}
