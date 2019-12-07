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
using APIBulaFacil.Application.ViewModels.UsuarioMobile;
using APIBulaFacil.Application.ViewModels.Usuarios;
using APIBulaFacil.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
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
                      Rua = endereco.Rua,
                      Cep = endereco.Cep,
                      Cidade = endereco.Cidade,
                      Complemento = endereco.Complemento,
                      Latitude = endereco.Latitude,
                      Longitude = endereco.Longitude,
                      Pluscode = endereco.Pluscode,
                      Uf = endereco.Uf
                  }));

            CreateMap<ContraIndicacaoCadastroViewModel, ContraIndicacao>();
            CreateMap<ContraIndicacaoEdicaoViewModel, ContraIndicacao>();

            CreateMap<IndicacaoCadastroViewModel, Indicacao>();
            CreateMap<IndicacaoEdicaoViewModel, Indicacao>();

            CreateMap<MedicamentoCadastroViewModel, Medicamento>();
            CreateMap<MedicamentoEdicaoViewModel, Medicamento>();

            CreateMap<ModoDeUsoCadastroViewModel, ModoDeUso>();
            CreateMap<ModoDeUsoEdicaoViewModel, ModoDeUso>();

            CreateMap<SubstanciaCadastroViewModel, Substancia>();
            CreateMap<SubstanciaEdicaoViewModel, Substancia>();

            CreateMap<UnidadeMedidaCadastroViewModel, UnidadeMedida>();
            CreateMap<UnidadeMedidaEdicaoViewModel, UnidadeMedida>();

            CreateMap<BulaFacilCadastroViewModel, BulaFacil>();
            CreateMap<BulaFacilEdicaoViewModel, BulaFacil>();

            CreateMap<MedicamentoFarmaciaCadastroViewModel, MedicamentoFarmacia>();
            CreateMap<MedicamentoFarmaciaEdicaoViewModel, MedicamentoFarmacia>();

            CreateMap<UsuarioMobileCadastroViewModel, UsuarioMobile>();
            CreateMap<UsuarioMobileEdicaoViewModel, UsuarioMobile>();
        }
    }
}
