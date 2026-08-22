using Dominio_J.iary.ModuloTarefa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloTarefa
{
    public class MapeadorTarefaORM : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("TB_TAREFA");
            builder.Property(x => x.IDUsuario)
                .HasColumnName("ID_USUARIO")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.HasOne(x => x.Usuario)
                .WithMany()
                .HasForeignKey(x => x.IDUsuario);

            builder.Property(x => x.Titulo)
                .HasColumnName("TITULO");

            builder.Property(x => x.Descricao)
                .HasColumnName("DESCRICAO");

            builder.Property(x => x.Prioridade)
                .HasColumnName("PRIORIDADE");

            builder.Property(x => x.DataMarcada)
                .HasColumnName("DATA_MARCADA")
                .IsRequired(false);

            //builder.Property(x => x.Rotina). // ESSE TEM QUE ARMAZENAR NA TB(ROTINA), COM O USUARIO E O ID DA TAREFA

            builder.Property(x => x.Status)
                .HasColumnName("STATUS_TAREFA");

            builder.Property(x => x.Armazenamento)
                .HasColumnName("ARMAZENAMENTO");

            builder.Property(x => x.DataCriacao)
                .HasColumnName("DATA_CRIACAO");

        }
    }
    public class MapeadorCheckBoxTarefa : IEntityTypeConfiguration<ValoresCheckBox>
    {
        public void Configure(EntityTypeBuilder<ValoresCheckBox> builder)
        {
            builder.ToTable("TB_CHECKBOX");
            builder.Property(x => x.IdUsuario)
                .HasColumnName("ID_USUARIO");

            builder.Property(x => x.IDTarefa)
                .HasColumnName("ID_TAREFA");

            builder.Property(x => x.CheckBoxe)
                .HasColumnName("CHECKBOXE");

            builder.HasOne(x => x.Tarefa)
                .WithMany(x => x.CheckBoxes)
                .HasForeignKey(x => x.IDTarefa);

            builder.HasOne(x => x.Usuario)
                   .WithMany()
                   .HasForeignKey(x => x.IdUsuario);
        }
    }
}
