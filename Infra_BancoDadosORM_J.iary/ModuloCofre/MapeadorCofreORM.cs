using Dominio_J.iary.ModuloCofre;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloCofre
{
    public class MapeadorCofreORM : IEntityTypeConfiguration<Cofre>
    {
        public void Configure(EntityTypeBuilder<Cofre> builder)
        {
            builder.ToTable("TB_COFRE");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID");

            builder.Property(x => x.UsuarioId)
                .HasColumnName("ID_USUARIO")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(x => x.Senha)
                .HasColumnName("SENHA")
                .HasColumnType("varchar(300)")
                .IsRequired();

            builder.HasOne(x => x.Usuario)
                .WithOne()
                .HasForeignKey<Cofre>(x => x.UsuarioId);
        }
    }
}
