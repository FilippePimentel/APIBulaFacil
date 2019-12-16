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
using System;
using System.Globalization;

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
            CreateMap<BulaFacil, BulaFacilConsultaViewModel>()
                .ForMember(dest => dest.NomeMedicamento,
               opts => opts.MapFrom(src => src.Medicamento.Nome))
                .ForMember(dest => dest.IdMedicamento,
               opts => opts.MapFrom(src => src.Medicamento.IdMedicamento));
            CreateMap<MedicamentoFarmacia, MedicamentoFarmaciaConsultaViewModel>()
                .ForMember(dest => dest.NomeMedicamento,
               opts => opts.MapFrom(src => src.Medicamento.Nome))
                .ForMember(dest => dest.NomeFarmacia,
               opts => opts.MapFrom(src => src.Farmacia.Nome))
               .AfterMap((src, dest) => dest.Inicio
                 = (src.Inicio).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture))
               .AfterMap((src, dest) => dest.Fim
                 = (src.Fim)!= null ? (src.Fim).Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) : "n/a");
            CreateMap<UsuarioMobile, UsuarioMobileConsultaViewModel>();
            CreateMap<Posologia, PosologiaConsultaViewModel>();
        }
    }
}
