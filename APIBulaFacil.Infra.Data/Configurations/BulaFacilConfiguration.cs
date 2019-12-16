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
            .HasMaxLength(500);

            Property(map => map.Substancia)
            .HasColumnName("BFA_SUBSTANCIA")
            .HasMaxLength(1000);

            Property(map => map.Valido)
            .HasColumnName("BFA_VALIDO")
            .HasMaxLength(1)
            .IsRequired();

            Property(map => map.IdMedicamento)
                    .HasColumnName("BFA_RFMED");

            HasRequired(s => s.Medicamento).WithMany(a => a.Bulas)
                .HasForeignKey(map => map.IdMedicamento).WillCascadeOnDelete();
            
            //HasMany(u => u.Indicacoes).WithMany(t => t.BulasFaceis)
            //.Map(m =>
            //{
            //    m.ToTable("BULAINDICACAO_BIN");
            //    m.MapLeftKey("BIN_RFBFA");
            //    m.MapRightKey("BIN_RFIND");
            //});
            Property(map => map.Indicacao)
            .HasColumnName("BFA_INDICACAO")
            .HasMaxLength(1000);

            HasMany(u => u.Posologias).WithMany(t => t.BulasFaceis)
                .Map(m =>
            {
                m.ToTable("BULAPOSOLOGIA_BPO");
                m.MapLeftKey("BPO_RFBFA");
                m.MapRightKey("BPO_RFPOS");
            });

            Property(map => map.ContraIndicacao)
            .HasColumnName("BFA_CONTRAINDICACAO")
            .HasMaxLength(1000);

            //HasMany(u => u.ContraIndicacoes).WithMany(t => t.BulasFaceis)
            //    .Map(m =>
            //{
            //    m.ToTable("BULACONTRAINDICACAO_BCI");
            //    m.MapLeftKey("BCI_RFBFA");
            //    m.MapRightKey("BCI_RFCON");
            //});
        }
    }
}
