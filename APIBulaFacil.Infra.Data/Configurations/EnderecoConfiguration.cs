using APIBulaFacil.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            ToTable("ENDERECO_END");

            HasKey(map => map.IdEndereco);

            Property(u => u.IdEndereco)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("END_IDENDERECO");

            Property(map => map.Rua)
                .HasColumnName("END_RUA")
                .HasMaxLength(150)//50
                .IsRequired();

            Property(map => map.Complemento)
                .HasColumnName("END_COMPLEMENTO")
                .HasMaxLength(150);

            Property(map => map.Cidade)
               .HasColumnName("END_CIDADE")
               .HasMaxLength(150)
               .IsRequired();

            Property(map => map.Cep)
                .HasColumnName("END_CEP")
                .HasMaxLength(15)
                .IsRequired();

            Property(map => map.Uf)
                .HasColumnName("END_UF")
                .HasMaxLength(2)
                .IsRequired();

            Property(map => map.Latitude)
                .HasColumnName("END_LATITUDE")
                .HasPrecision(18, 10);

            Property(map => map.Longitude)
                .HasColumnName("END_LONGITUDE")
                .HasPrecision(18, 10);

            Property(map => map.Complemento)
                .HasColumnName("END_PLUSCODE")
                .HasMaxLength(100);
        }
    }
}
