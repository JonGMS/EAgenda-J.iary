using Dominio_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloUsuario;
using Infra_BancoDadosORM_J.iary.Compartilhado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloTarefa
{
    public class RepositorioTarefaORM : IRepositorioTarefa
    {
        private DbContext dbContext;
        public RepositorioTarefaORM(JiaryDbContext dbContext)
        {
            this.dbContext = dbContext;   
        }
        private DbSet<Tarefa> Tarefa;

        public void Editar(Tarefa registro)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Tarefa registro)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Tarefa registro)
        {
            Tarefa.Add(registro);
        }

        public Tarefa SelecionarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Tarefa> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
