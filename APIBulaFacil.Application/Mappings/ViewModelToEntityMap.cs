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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.Mappings
{
    public class ViewModelToEntityMap : Profile
    {
        public ViewModelToEntityMap()
        {
            CreateMap<UsuarioCadastroViewModel, Usuario>()
                .Include<FarmaciaCadastroViewModel, Farmacia>()
                .Include<UsuarioMobileCadastroViewModel, UsuarioMobile>();
            CreateMap<UsuarioEdicaoViewModel, Usuario>()
                .Include<FarmaciaEdicaoViewModel, Farmacia>()
                .Include<UsuarioMobileEdicaoViewModel, UsuarioMobile>();

            CreateMap<EnderecoCadastroViewModel, Endereco>();
            CreateMap<EnderecoEdicaoViewModel, Endereco>();

            CreateMap<FarmaciaCadastroViewModel, Farmacia>()
                .ForMember(farmacia => farmacia.Endereco,
              map => map.MapFrom(
                  endereco => new Endereco
                  {
                      Rua = endereco.Rua,
                      Cep = endereco.Cep,
                      Cidade = endereco.Cidade,
                      Complemento = endereco.Complemento,
                      Latitude = endereco.Latitude,
                      Longitude = endereco.Longitude,
                      Pluscode = endereco.Pluscode,
                      Uf = endereco.Uf
                  }));

            CreateMap<FarmaciaEdicaoViewModel, Farmacia>()
             .ForMember(farmacia => farmacia.Endereco,
              map => map.MapFrom(
                  endereco => new Endereco
                  {
                      Rua = "",
                      Cep = "",
                      Cidade = "",
                      Complemento = "",
                      Latitude = 0,
                      Longitude = 0,
                      Pluscode = "",
                      Uf = ""
                  }));

            CreateMap<ContraIndicacaoCadastroViewModel, ContraIndicacao>();
            CreateMap<ContraIndicacaoEdicaoViewModel, ContraIndicacao>();

            CreateMap<IndicacaoCadastroViewModel, Indicacao>();
            CreateMap<IndicacaoEdicaoViewModel, Indicacao>();

            CreateMap<MedicamentoCadastroViewModel, Medicamento>();
            CreateMap<MedicamentoEdicaoViewModel, Medicamento>();

            CreateMap<BulaFacilCadastroViewModel, BulaFacil>().
                ForMember(BulaFacil => BulaFacil.Medicamento, map => map
                .MapFrom(medicamento => new Medicamento { IdMedicamento = medicamento.IdMedicamento }))
                .ReverseMap();
            CreateMap<BulaFacilEdicaoViewModel, BulaFacil>()
                .ForMember(BulaFacil => BulaFacil.Medicamento, map => map
                .MapFrom(medicamento => new Medicamento { IdMedicamento = medicamento.IdMedicamento }))
                .ReverseMap(); ;

            CreateMap<MedicamentoFarmaciaCadastroViewModel, MedicamentoFarmacia>()
                 .AfterMap((src, dest) => dest.Inicio
                 = Convert.ToDateTime(src.Inicio))
                 .AfterMap((src, dest) => dest.Fim
                 = Convert.ToDateTime(src.Fim));
            CreateMap<MedicamentoFarmaciaEdicaoViewModel, MedicamentoFarmacia>()
                .AfterMap((src, dest) => dest.Inicio
                 = DateTime.ParseExact((src.Inicio), "dd/MM/yyyy", CultureInfo.InvariantCulture))
                 .AfterMap((src, dest) => dest.Fim
                 = DateTime.ParseExact((src.Fim), "dd/MM/yyyy", CultureInfo.InvariantCulture));

            CreateMap<UsuarioMobileCadastroViewModel, UsuarioMobile>()
                .AfterMap((src, dest) => dest.Nascimento
                 = Convert.ToDateTime(src.Nascimento));
            CreateMap<UsuarioMobileEdicaoViewModel, UsuarioMobile>()
                .AfterMap((src, dest) => dest.Nascimento
                 = Convert.ToDateTime(src.Nascimento));

            CreateMap<PosologiaCadastroViewModel, Posologia>();
            CreateMap<PosologiaEdicaoViewModel, Posologia>();


            CreateMap<PosologiaBulaViewModel, Posologia>();
            CreateMap<IndicacaoBulaViewModel, Indicacao>();
            CreateMap<ContraIndicacaoBulaViewModel, ContraIndicacao>();
            CreateMap<MedicamentoBulaViewModel, Medicamento>();
        }


    }
}
