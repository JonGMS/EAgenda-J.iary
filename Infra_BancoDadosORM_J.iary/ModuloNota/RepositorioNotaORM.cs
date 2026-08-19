using Dominio_J.iary.ModuloNota;
using Dominio_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloUsuario;
using Infra_BancoDadosORM_J.iary.Compartilhado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloNota
{
    public class RepositorioNotaORM : IRepositorioNota
    {
        private DbContext dbContext;
        public RepositorioNotaORM(JiaryDbContext dbContext)
        {
            notas = dbContext.Set<Nota>();
            this.dbContext = dbContext;
        }
        private DbSet<Nota> notas;
        public void Editar(Nota registro)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Nota registro)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Nota registro)
        {
            notas.Add(registro);
        }

        public Nota SelecionarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Nota> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        public List<Nota> SelecionarTodos(Usuario logado)
        {
            throw new NotImplementedException();
        }

        public Nota SelecionarNotaPorTitulo(Nota registro, Usuario logado)
        {
            return notas.Where(x => x.UsuarioId == logado.Id).FirstOrDefault(x => x.Titulo == registro.Titulo);
        }
    }
}
