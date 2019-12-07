using APIBulaFacil.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class UsuarioMobileConfiguration : EntityTypeConfiguration<UsuarioMobile>
    {
        public UsuarioMobileConfiguration()
        {
            ToTable("USUMOBILE_USM");

            Property(map => map.IdUsuario)
            .HasColumnName("USM_USUARIO_USU_FK");

            Property(map => map.Cpf)
                .HasColumnName("USM_CPF")
                .HasMaxLength(15)
                .IsRequired();

            Property(map => map.Nascimento)
                .HasColumnName("USM_DTNASCIMENTO")
                .IsRequired();

            Property(map => map.Sexo)
               .HasColumnName("USM_SEXO")
               .HasMaxLength(1)
               .IsRequired();
        }
    }
}
