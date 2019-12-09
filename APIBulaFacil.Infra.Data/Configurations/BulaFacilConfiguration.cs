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
            
            HasRequired(s => s.Medicamento).WithOptional(a => a.BulaFacil).Map(x => x.MapKey("BFA_RFMED")); 
            
            HasMany(u => u.Indicacoes).WithMany(t => t.BulasFaceis)
            .Map(m =>
            {
                m.ToTable("BULAINDICACAO_BIN");
                m.MapLeftKey("BIN_RFBFA");
                m.MapRightKey("BIN_RFIND");
            });

            HasMany(u => u.Posologias).WithMany(t => t.BulasFaceis)
                .Map(m =>
            {
                m.ToTable("BULAPOSOLOGIA_BPO");
                m.MapLeftKey("BPO_RFBFA");
                m.MapRightKey("BPO_RFPOS");
            });

            HasMany(u => u.ContraIndicacoes).WithMany(t => t.BulasFaceis)
                .Map(m =>
            {
                m.ToTable("BULACONTRAINDICACAO_BCI");
                m.MapLeftKey("BCI_RFBFA");
                m.MapRightKey("BCI_RFCON");
            });
        }
    }
}
