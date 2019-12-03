using APIBulaFacil.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class MedicamentoFarmaciaConfiguration : EntityTypeConfiguration<MedicamentoFarmacia>
    {
        public MedicamentoFarmaciaConfiguration()
        {
            ToTable("MEDICAMENTOFARMACIA_MFA");

            HasKey(map => map.IdMedicamentoFarmacia);

            Property(u => u.IdMedicamentoFarmacia)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("MFA_IDMEDICAMENTOFARMACIA");

            Property(map => map.Apresentacao)
                .HasColumnName("MFA_APRESENTACAO")
                .HasMaxLength(150)
                .IsRequired();

            Property(map => map.Concentracao)
                .HasColumnName("MFA_CONCENTRACAO")
                .HasMaxLength(150);

            Property(map => map.Preco)
                .HasColumnName("MFA_VLPRECO")
                .HasPrecision(18, 2);

            Property(map => map.Inicio)
               .HasColumnName("MFA_DTINICIO")
               .IsRequired();

            Property(map => map.Fim)
               .HasColumnName("MFA_DTFIM");

            Property(map => map.IdFarmacia)
                .HasColumnName("MFA_RFFAR");

            Property(map => map.IdMedicamento)
                .HasColumnName("MFA_RFMED");

            #region Relacionamentos
            HasRequired(map => map.Farmacia)
                .WithMany(map => map.MedicamentosFarmacias) //ListaMedicamentoFarmacia
                .HasForeignKey(map => map.IdFarmacia)
                .WillCascadeOnDelete();

            HasRequired(map => map.Medicamento)
                .WithMany(map => map.MedicamentosFarmacias) //ListaMedicamentoFarmacia
                .HasForeignKey(map => map.IdMedicamento)
                .WillCascadeOnDelete();
            #endregion
        }
    }
}
