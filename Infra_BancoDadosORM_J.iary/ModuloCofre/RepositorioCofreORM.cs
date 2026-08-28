using Dominio_J.iary.ModuloCofre;
using Dominio_J.iary.ModuloUsuario;
using Infra_BancoDadosORM_J.iary.Compartilhado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloCofre
{
    public class RepositorioCofreORM : IRepositorioCofre
    {
        private DbContext dbContext;
        public RepositorioCofreORM(JiaryDbContext dbContext)
        {
            cofres = dbContext.Set<Cofre>();
            this.dbContext = dbContext;

        }
        private DbSet<Cofre> cofres;
        public void Editar(Cofre registro)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Cofre registro)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Cofre registro)
        {
            cofres.Add(registro);
        }

        public Cofre SelecionarPorId(Guid id)
        {
            return cofres.FirstOrDefault(x => x.UsuarioId == id);
        }

        public List<Cofre> SelecionarTodos(Usuario logado)
        {
            throw new NotImplementedException();
        }

        public bool VerificarCofre(Usuario usuario)
        {
            return cofres.Any(x => x.UsuarioId == usuario.Id);
        }
    }
}
