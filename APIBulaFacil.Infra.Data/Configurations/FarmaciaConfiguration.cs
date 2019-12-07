using APIBulaFacil.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class FarmaciaConfiguration : EntityTypeConfiguration<Farmacia>
    {
        public FarmaciaConfiguration()
        {
            ToTable("FARMACIA_FAR");

            HasKey(map => map.IdFarmacia);

            Property(u => u.IdFarmacia)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("FAR_IDFARMACIA");

            Property(map => map.Cnpj)
                .HasColumnName("FAR_CNPJ")
                .HasMaxLength(50)//50
                .IsRequired();

            Property(map => map.RazaoSocial)
                .HasColumnName("FAR_RAZAOSOCIAL")
                .HasMaxLength(100)
                .IsRequired();

            Property(map => map.Telefone)
               .HasColumnName("FAR_TELEFONE")
               .HasMaxLength(20)
               .IsRequired();

            Property(map => map.Email)
                .HasColumnName("FAR_EMAIL")
                .HasMaxLength(80)
                .IsRequired();

            Property(map => map.Site)
                .HasColumnName("FAR_SITE")
                .HasMaxLength(80)
                .IsRequired();
            
            #region Relacionamentos
            HasOptional(s => s.Endereco) // Mark Address property optional in Student entity
                .WithRequired(ad => ad.Farmacia).Map(m => m.MapKey("FAR_ENDERECOFARMACIA_FK"));
            #endregion

        }
    }
}
