using APIBulaFacil.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class ModoDeUsoConfiguration : EntityTypeConfiguration<ModoDeUso>
    {
        public ModoDeUsoConfiguration()
        {
            ToTable("MODOUSO_MUS");

            HasKey(map => map.IdModoDeUso);

            Property(u => u.IdModoDeUso)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("MUS_IDMODOUSO");

            Property(map => map.DescricaoAdministracao)
            .HasColumnName("MUS_DSADMINISTRACAO")
            .HasMaxLength(150)
            .IsRequired();
        }
    }
}
