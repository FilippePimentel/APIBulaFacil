using APIBulaFacil.Domain.Contracts.Repositories;
using APIBulaFacil.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext context;
        private DbContextTransaction transaction;

        public UnitOfWork(DataContext context)
        {
            this.context = context;
        }

        public void BeginTransaction()
        {
            transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }
        public IUsuarioRepository UsuarioRepository => new UsuarioRepository(context);
        public IEnderecoRepository EnderecoRepository => new EnderecoRepository(context);
        public IFarmaciaRepository FarmaciaRepository => new FarmaciaRepository(context);
        public IContraIndicacaoRepository ContraIndicacaoRepository => new ContraIndicacaoRepository(context);
        public IIndicacaoRepository IndicacaoRepository => new IndicacaoRepository(context);
        public IMedicamentoRepository MedicamentoRepository => new MedicamentoRepository(context);
        public IBulaFacilRepository BulaFacilRepository => new BulaFacilRepository(context);
        public IMedicamentoFarmaciaRepository MedicamentoFarmaciaRepository => new MedicamentoFarmaciaRepository(context);
        public IUsuarioMobileRepository UsuarioMobileRepository => new UsuarioMobileRepository(context);
        public IPosologiaRepository PosologiaRepository => new PosologiaRepository(context);

        public void Dispose()
        {
            context.Dispose();
        }

    }
}
