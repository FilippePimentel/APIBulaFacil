using APIBulaFacil.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class SubstanciaConfiguration : EntityTypeConfiguration<Substancia>
    {
        public SubstanciaConfiguration()
        {
            ToTable("SUBSTANCIA_SUB");

            HasKey(map => map.IdSubstancia);
            
            Property(u => u.IdSubstancia)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("SUB_IDSUBSTANCIA");
            
            Property(map => map.Nome)
            .HasColumnName("SUB_NOME")
            .HasMaxLength(150)
            .IsRequired();

            Property(map => map.Concentracao)
            .HasColumnName("SUB_CONCENTRACAO")
            .HasMaxLength(150);
        }
    }
}
