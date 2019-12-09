using APIBulaFacil.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class MedicamentoConfiguration : EntityTypeConfiguration<Medicamento>
    {
        public MedicamentoConfiguration()
        {
            ToTable("MEDICAMENTO_MED");

            HasKey(map => map.IdMedicamento);

            Property(u => u.IdMedicamento)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("MED_IDMEDICAMENTO");

            Property(map => map.Nome)
            .HasColumnName("MED_NOME")
            .HasMaxLength(150)//50
            .IsRequired();

            Property(map => map.Tipo)
                .HasColumnName("MED_TIPO")
                .HasMaxLength(150)//50
                .IsRequired();

            Property(map => map.Laboratorio)
                .HasColumnName("MED_LABORATORIO")
                .HasMaxLength(150);
        }
    }
}
