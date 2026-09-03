using Dominio_J.iary.ModuloNota;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloNota
{
    public class MapeadorNotaORM : IEntityTypeConfiguration<Nota>
    {
        public void Configure(EntityTypeBuilder<Nota> builder)
        {
            builder.ToTable("TB_NOTA");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID");

            builder.Property(x => x.DataCriacao)
                .HasColumnName("DATA_CRIACAO")
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(x => x.Titulo)
                .HasColumnName("TITULO")
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnName("DESCRICAO")
                .HasColumnType("varchar(max)");

            builder.Property(x => x.Armazenamento)
                .HasColumnName("ARMAZENAMENTO")
                .HasColumnType("char(1)")
                .IsRequired();

            builder.Property(x => x.IDTarefa)
                .HasColumnName("ID_TAREFA")
                .IsRequired(false);
                

            builder.Property(x => x.CategoriaID)
                .HasColumnName("ID_CATEGORIA");

            builder.Property(x => x.UsuarioId)
                .HasColumnName("ID_USUARIO")
                .IsRequired();

            builder.HasOne(x => x.Tarefa)
                .WithMany()
                .HasForeignKey(x => x.IDTarefa)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Categoria)
                .WithMany()
                .HasForeignKey(x => x.CategoriaID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Usuario)
                .WithMany()
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Arquivos)
                .WithOne(x => x.Nota)
                .HasForeignKey(x => x.NotaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
    public class MapeadorAnexoORM :
        IEntityTypeConfiguration<Anexo>
    {
        public void Configure(EntityTypeBuilder<Anexo> builder)
        {
            builder.ToTable("TB_ANEXO");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID");

            builder.Property(x => x.NomeArquivo)
                .HasColumnName("NOME_ARQUIVO")
                .HasColumnType("varchar(260)")
                .IsRequired();

            builder.Property(x => x.Tipo)
                .HasColumnName("TIPO")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Arquivo)
                .HasColumnName("ARQUIVO")
                .HasColumnType("varbinary(max)")
                .IsRequired();

            builder.Property(x => x.NotaId)
                .HasColumnName("ID_NOTA")
                .IsRequired();

            builder.HasOne(x => x.Nota)
                .WithMany(x => x.Arquivos)
                .HasForeignKey(x => x.NotaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
