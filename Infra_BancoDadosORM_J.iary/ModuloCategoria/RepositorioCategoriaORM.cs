using Dominio_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloUsuario;
using Infra_BancoDadosORM_J.iary.Compartilhado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloCategoria
{
    public class RepositorioCategoriaORM : IRepositorioCategoria
    {
        private DbContext dbContext;
        public RepositorioCategoriaORM(JiaryDbContext dbContext)
        {
            categorias = dbContext.Set<Categoria>();
            this.dbContext = dbContext;
        }
        private DbSet<Categoria> categorias;
        public void Editar(Categoria registro)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Categoria registro)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Categoria registro)
        {
            categorias.Add(registro);
        }

        public Categoria SelecionarCategoriaPorNome(string nome, Usuario logado)
        {
            return categorias.FirstOrDefault(x => x.Nome == nome && x.Usuario.Id == logado.Id);
        }

        public Categoria SelecionarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
