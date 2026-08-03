using Dominio_J.iary.ModuloUsuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloUsuario
{
    public class MapeadorUsuarioORM : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TB_USUARIO");
            builder.Property(x => x.Username).HasColumnType("varchar(300)").IsRequired();
            builder.Property(x => x.Password).HasColumnType("varchar(300)").IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar(300)").IsRequired();
            builder.Property(x => x.DataCadastro).IsRequired();
        }
    }
}
