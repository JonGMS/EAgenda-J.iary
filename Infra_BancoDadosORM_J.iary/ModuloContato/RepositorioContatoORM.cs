using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloContatos;
using Dominio_J.iary.ModuloNota;
using Dominio_J.iary.ModuloUsuario;
using Infra_BancoDadosORM_J.iary.Compartilhado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_BancoDadosORM_J.iary.ModuloContato
{
    public class RepositorioContatoORM : IRepositorioContato
    {
        private DbContext dbContext;
        public RepositorioContatoORM(JiaryDbContext dbContext)
        {
            Contatos = dbContext.Set<Contato>();
            this.dbContext = dbContext;
        }
        private DbSet<Contato> Contatos;
        public void Editar(Contato registro)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Contato registro)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Contato registro)
        {
            Contatos.Add(registro);
        }

        public Contato SelecionarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Contato> SelecionarTodos(Usuario logado)
        {
            throw new NotImplementedException();
        }
    }
}
