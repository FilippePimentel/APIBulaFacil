using APIBulaFacil.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class IndicacaoConfiguration : EntityTypeConfiguration<Indicacao>
    {
        public IndicacaoConfiguration()
        {
            //IND_ID: int
            //IND_DSINDICACAO : String

            ToTable("INDICACAO_IND");

            HasKey(map => map.IdIndicacao);

            Property(u => u.IdIndicacao)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("IND_IDINDICACAO");

            Property(map => map.DescricaoIndicacao)
            .HasColumnName("IND_DSINDICACAO")
            .HasMaxLength(150)
            .IsRequired();
        }
    }
}
