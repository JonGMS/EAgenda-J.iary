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

        public class MapeadorDiaRotinaORM : IEntityTypeConfiguration<DiaRotina>
        {
            public void Configure(EntityTypeBuilder<DiaRotina> builder)
            {
                builder.ToTable("TB_ROTINA");

                builder.HasKey(x => x.Id);

                builder.Property(x => x.Id)
                    .HasColumnName("ID");

                builder.Property(x => x.UsuarioID)
                    .HasColumnName("ID_USUARIO")
                    .IsRequired();

                builder.Property(x => x.TarefaID)
                    .HasColumnName("ID_TAREFA")
                    .IsRequired();

                builder.Property(x => x.Dia)
                    .HasColumnName("DIA")
                    .HasColumnType("char(3)")
                    .IsRequired();

                builder.HasOne(x => x.Usuario)
                    .WithMany()
                    .HasForeignKey(x => x.UsuarioID);

                builder.HasOne(x => x.Tarefa)
                    .WithMany()
                    .HasForeignKey(x => x.TarefaID);
            }
        }
    
}
