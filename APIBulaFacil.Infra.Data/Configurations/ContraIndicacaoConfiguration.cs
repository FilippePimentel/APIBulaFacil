using APIBulaFacil.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class ContraIndicacaoConfiguration : EntityTypeConfiguration<ContraIndicacao>
    {
        public ContraIndicacaoConfiguration()
        {

            ToTable("CONTRAINDICACAO_CON");

            HasKey(map => map.IdContraIndicacao);

            Property(u => u.IdContraIndicacao)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("CON_IDBULAFACIL");

            Property(map => map.DescricaoContraIndicacao)
            .HasColumnName("CON_CONTRAINDICACAO")
            .HasMaxLength(150)
            .IsRequired();
        }
    }
}
