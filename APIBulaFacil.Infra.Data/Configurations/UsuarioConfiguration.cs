using APIBulaFacil.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Infra.Data.Configurations
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            ToTable("USUARIO_USU");
            
            HasKey(map => map.IdUsuario);

            Property(u => u.IdUsuario)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("USU_IDUSUARIO");

            Property(map => map.Nome)
                .HasColumnName("USU_NOME")
                .HasMaxLength(150)//50
                .IsRequired();

            Property(map => map.Email)
                .HasColumnName("USU_EMAIL")
                .HasMaxLength(150)
                .IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("IDX_USU_EMAIL")
                { IsUnique = true }));

            Property(map => map.Senha).IsRequired()
               .HasColumnName("USU_SENHA");
        }
    }
}
