using Dominio_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloLogin;
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
    //Nenhuma Tarefa Cadastrada (Campo opcional)
    public class RepositorioTarefaORM : IRepositorioTarefa
    {
        private DbContext dbContext;
        public RepositorioTarefaORM(JiaryDbContext dbContext)
        {
            Tarefa = dbContext.Set<Tarefa>();
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

        public Tarefa SelecionarTarefaPorTitulo(string titulo)
        {
            return Tarefa.FirstOrDefault(x => x.Titulo == titulo);
        }

        public List<Tarefa> SelecionarTodos(Usuario logado)
        {
            return Tarefa
            .Where(x => x.IDUsuario == logado.Id)
            .ToList();
        }
    }
}
