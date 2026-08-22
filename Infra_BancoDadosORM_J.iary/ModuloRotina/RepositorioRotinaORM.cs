using Dominio_J.iary.ModuloRotina;
using Dominio_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloUsuario;
using Infra_BancoDadosORM_J.iary.Compartilhado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloRotina
{
    public class RepositorioRotinaORM : IRepositorioRotina
    {
        private DbContext dbContext;
        public RepositorioRotinaORM( JiaryDbContext dbContext)
        {
            Dias = dbContext.Set<DiaRotina>();
            this.dbContext = dbContext;
        }
        private DbSet<DiaRotina> Dias;
        public void Editar(DiaRotina registro)
        {
            throw new NotImplementedException();
        }

        public void Excluir(DiaRotina registro)
        {
            throw new NotImplementedException();
        }

        public void Inserir(DiaRotina registro)
        {
            Dias.Add(registro);
        }

        public DiaRotina SelecionarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<DiaRotina> SelecionarTodos(Usuario logado)
        {
            throw new NotImplementedException();
        }
    }
}
