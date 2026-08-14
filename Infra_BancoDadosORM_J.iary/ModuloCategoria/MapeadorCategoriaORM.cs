using Dominio_J.iary.ModuloCategoria;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloCategoria
{
    public class MapeadorCategoriaORM : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("TB_CATEGORIA");
            builder.Property(x => x.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder.Property(x => x.Cor)
                .HasColumnName("COR")
                .HasColumnType("varchar(20)")
                .IsRequired();
            builder.Property(x =>  x.UsuarioId)
                .HasColumnName("ID_USUARIO")
                .HasColumnType("uniqueidentifier")
                .IsRequired();
            builder.HasOne(x => x.Usuario)
                .WithMany()
                .HasForeignKey(x => x.UsuarioId);
        }
    }
}
