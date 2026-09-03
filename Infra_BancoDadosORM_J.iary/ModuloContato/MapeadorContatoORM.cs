using Dominio_J.iary.ModuloContatos;
using Dominio_J.iary.ModuloNota;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloContato
{
    public class MapeadorContatoORM : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("TB_CONTATO");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(x => x.Telefone)
                .HasColumnName("TELEFONE")
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(x => x.Categoria)
                .HasColumnName("CATEGORIA")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnName("EMAIL")
                .HasColumnType("varchar(200)")
                .IsRequired(false);

            builder.Property(x => x.DataNascimento)
                .HasColumnName("DATA_NASCIMENTO")
                .HasColumnType("datetime2")
                .IsRequired(false);

            builder.Property(x => x.Empresa)
                .HasColumnName("EMPRESA")
                .HasColumnType("varchar(150)")
                .IsRequired(false);

            builder.Property(x => x.Armazenamento)
                .HasColumnName("ARMAZENAMENTO")
                .HasColumnType("char(1)")
                .IsRequired();

            builder.Property(x => x.TelefoneEmpresa)
                .HasColumnName("TELEFONE_EMPRESA")
                .HasColumnType("varchar(20)")
                .IsRequired(false);

            builder.Property(x => x.DataCadastro)
                .HasColumnName("DATA_CADASTRO")
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(x => x.Favorito)
                .HasColumnName("FAVORITO")
                .HasColumnType("bit")
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
