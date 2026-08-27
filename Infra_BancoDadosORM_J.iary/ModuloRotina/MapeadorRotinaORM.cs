using Dominio_J.iary.ModuloRotina;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloRotina
{
    public class MapeadorRotinaORM : IEntityTypeConfiguration<Rotina>
    {
        public void Configure(EntityTypeBuilder<Rotina> builder)
        {
            builder.ToTable("TB_ROTINA");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID");

            builder.Property(x => x.TarefaID)
                .HasColumnName("ID_TAREFA")
                .IsRequired();

            builder.Property(x => x.UsuarioID)
                .HasColumnName("ID_USUARIO")
                .IsRequired();

            builder.HasOne(x => x.Tarefa)
                .WithMany(x => x.Rotina)
                .HasForeignKey(x => x.TarefaID);

            builder.Ignore(x => x.Dias);

            builder.HasOne(x => x.Usuario)
                .WithMany()
                .HasForeignKey(x => x.TarefaID);
            
        }
    }
}
