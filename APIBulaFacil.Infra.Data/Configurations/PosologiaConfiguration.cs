using APIBulaFacil.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class PosologiaConfiguration : EntityTypeConfiguration<Posologia>
    {
        public PosologiaConfiguration()
        {
            ToTable("POSOLOGIA_POS");

            HasKey(map => map.IdPosologia);

            Property(u => u.IdPosologia)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("POS_IDPOSOLOGIA");

            Property(map => map.UnidadeMedida)
            .HasColumnName("POS_UNIMEDIDA")
            .HasMaxLength(100)
            .IsRequired();

            Property(map => map.Quantidade)
            .HasColumnName("POS_QUANTIDADE")
            .IsRequired();

            Property(map => map.Intervalo)
            .HasColumnName("POS_INTERVALO")
            .HasMaxLength(150)
            .IsRequired(); 

            Property(map => map.ModoDeUso)
            .HasColumnName("POS_MODODEUSO")
            .HasMaxLength(150)
            .IsRequired(); 
        }
    }
}
