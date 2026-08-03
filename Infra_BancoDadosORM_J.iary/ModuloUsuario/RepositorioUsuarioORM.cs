using Dominio_J.iary.ModuloUsuario;
using Infra_BancoDadosORM_J.iary.Compartilhado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloUsuario
{
 
    public class RepositorioUsuarioORM : IRepositorioUsuario
    {
        private readonly DbContext dbContext;
        public RepositorioUsuarioORM(JiaryDbContext dbContext)
        {
            usuarios = dbContext.Set<Usuario>();
            this.dbContext = dbContext;
        }
        private DbSet<Usuario> usuarios;
        public void Editar(Usuario registro)
        {
            usuarios.Update(registro);
        }

        public void Excluir(Usuario registro)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Usuario registro)
        {
            usuarios.Add(registro);
        }

        public Usuario SelecionarPorId(Guid id)
        {
            throw new NotImplementedException();
        }
        public Usuario SelecionarUsuarioPorLogin(string login)
        {
            return usuarios.FirstOrDefault(x => x.Username == login);
        }
        public List<Usuario> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
