using APIBulaFacil.Application.Contracts;
using APIBulaFacil.Application.Services;
using APIBulaFacil.Domain.Contracts.Repositories;
using APIBulaFacil.Domain.Contracts.Services;
using APIBulaFacil.Domain.Services;
using APIBulaFacil.Infra.Data.Context;
using APIBulaFacil.Infra.Data.Repositories;
using SimpleInjector;
using SimpleInjector.Lifestyles;


namespace APIBulaFacil.IoC
{
    public class DependencyResolver
    {
        public static Container CreateContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<IUsuarioApplicationService, UsuarioApplicationService>(Lifestyle.Scoped);
            container.Register<IUsuarioDomainService, UsuarioDomainService>(Lifestyle.Scoped);
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);

            container.Register<IEnderecoApplicationService, EnderecoApplicationService>(Lifestyle.Scoped);
            container.Register<IEnderecoDomainService, EnderecoDomainService>(Lifestyle.Scoped);
            container.Register<IEnderecoRepository, EnderecoRepository>(Lifestyle.Scoped);

            container.Register<IFarmaciaApplicationService, FarmaciaApplicationService>(Lifestyle.Scoped);
            container.Register<IFarmaciaDomainService, FarmaciaDomainService>(Lifestyle.Scoped);
            container.Register<IFarmaciaRepository, FarmaciaRepository>(Lifestyle.Scoped);

            container.Register<IContraIndicacaoApplicationService, ContraIndicacaoApplicationService>(Lifestyle.Scoped);
            container.Register<IContraIndicacaoDomainService, ContraIndicacaoDomainService>(Lifestyle.Scoped);
            container.Register<IContraIndicacaoRepository, ContraIndicacaoRepository>(Lifestyle.Scoped);

            container.Register<IIndicacaoApplicationService, IndicacaoApplicationService>(Lifestyle.Scoped);
            container.Register<IIndicacaoDomainService, IndicacaoDomainService>(Lifestyle.Scoped);
            container.Register<IIndicacaoRepository, IndicacaoRepository>(Lifestyle.Scoped);

            container.Register<IMedicamentoApplicationService, MedicamentoApplicationService>(Lifestyle.Scoped);
            container.Register<IMedicamentoDomainService, MedicamentoDomainService>(Lifestyle.Scoped);
            container.Register<IMedicamentoRepository, MedicamentoRepository>(Lifestyle.Scoped);

            container.Register<IBulaFacilApplicationService, BulaFacilApplicationService>(Lifestyle.Scoped);
            container.Register<IBulaFacilDomainService, BulaFacilDomainService>(Lifestyle.Scoped);
            container.Register<IBulaFacilRepository, BulaFacilRepository>(Lifestyle.Scoped);

            container.Register<IMedicamentoFarmaciaApplicationService, MedicamentoFarmaciaApplicationService>(Lifestyle.Scoped);
            container.Register<IMedicamentoFarmaciaDomainService, MedicamentoFarmaciaDomainService>(Lifestyle.Scoped);
            container.Register<IMedicamentoFarmaciaRepository, MedicamentoFarmaciaRepository>(Lifestyle.Scoped);

            container.Register<IUsuarioMobileApplicationService, UsuarioMobileApplicationService>(Lifestyle.Scoped);
            container.Register<IUsuarioMobileDomainService, UsuarioMobileDomainService>(Lifestyle.Scoped);
            container.Register<IUsuarioMobileRepository, UsuarioMobileRepository>(Lifestyle.Scoped);

            container.Register<IPosologiaApplicationService, PosologiaApplicationService>(Lifestyle.Scoped);
            container.Register<IPosologiaDomainService, PosologiaDomainService>(Lifestyle.Scoped);
            container.Register<IPosologiaRepository, PosologiaRepository>(Lifestyle.Scoped);

            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<DataContext>(Lifestyle.Scoped);

            return container;
        }

    }
}
