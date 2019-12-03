using APIBulaFacil.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class UnidadeMedidaConfiguration : EntityTypeConfiguration<UnidadeMedida>
    {
        public UnidadeMedidaConfiguration()
        {
            ToTable("UNIDMEDIDA_UND");

            HasKey(map => map.IdUnidadeMedida);

            Property(u => u.IdUnidadeMedida)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("UND_IDUNIDMEDIDA");

            Property(map => map.Tipo)
            .HasColumnName("UND_TIPO")
            .HasMaxLength(150)
            .IsRequired();
        }
    }
}
