using APIBulaFacil.Domain.Entities;
using APIBulaFacil.Infra.Data.Configurations;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base(ConfigurationManager.ConnectionStrings["PostgresDbConnection"].ConnectionString) //PostgresDbConnection ou APIBulaFacil_Banco
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.HasDefaultSchema("public");

            //definir ou remover preferencias do EntityFramework
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //adicionar as classes de mapeamento ORM
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new FarmaciaConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new MedicamentoConfiguration());
            modelBuilder.Configurations.Add(new MedicamentoFarmaciaConfiguration());
            //modelBuilder.Configurations.Add(new BulaFacilConfiguration());
            //modelBuilder.Configurations.Add(new ModoDeUsoConfiguration());
            //modelBuilder.Configurations.Add(new SubstanciaConfiguration());
            //modelBuilder.Configurations.Add(new UnidadeMedidaConfiguration());
            //modelBuilder.Configurations.Add(new BulaFacilConfiguration());
            //modelBuilder.Configurations.Add(new ContraIndicacaoConfiguration());
            //modelBuilder.Configurations.Add(new IndicacaoConfiguration());
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Farmacia> Farmacia { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Medicamento> Medicamento { get; set; }
        public DbSet<MedicamentoFarmacia> MedicamentoFarmacia { get; set; }

        //public DbSet<ContraIndicacao> ContraIndicacao { get; set; }
        //public DbSet<Indicacao> Indicacao { get; set; }
        //public DbSet<ModoDeUso> ModoDeUso { get; set; }
        //public DbSet<Substancia> Substancia { get; set; }
        //public DbSet<UnidadeMedida> UnidadeMedida { get; set; }
        //public DbSet<BulaFacil> BulaFacil { get; set; }
    }
    public class NpgSqlConfiguration : DbConfiguration
    {
        public NpgSqlConfiguration()
        {
            SetProviderFactory("Npgsql", NpgsqlFactory.Instance);
            SetProviderServices("Npgsql", provider: NpgsqlServices.Instance);
            SetDefaultConnectionFactory(new NpgsqlConnectionFactory());
        }
    }
    //enable-migrations -force
    //update-database -script
    //update-database -verbose
}
