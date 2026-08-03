using Dominio_J.iary.Compartilhado;
using Infra_BancoDadosORM_J.iary.ModuloUsuario;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.Compartilhado
{
    public class JiaryDbContext : DbContext, IContextoPersistencia
    {
        private string _connectionString;
        public JiaryDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void GravarDados()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapeadorUsuarioORM());
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
