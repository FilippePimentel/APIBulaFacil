using APIBulaFacil.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class BulaFacilConfiguration : EntityTypeConfiguration<BulaFacil>
    {
        public BulaFacilConfiguration()
        {
            ToTable("BULAFACIL_BFA");

            HasKey(map => map.IdBulaFacil);

            Property(u => u.IdBulaFacil)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("BFA_IDBULAFACIL");

            Property(map => map.Link)
            .HasColumnName("BFA_BULALINK")
            .HasMaxLength(150)
            .IsRequired();
        }
    }
}
