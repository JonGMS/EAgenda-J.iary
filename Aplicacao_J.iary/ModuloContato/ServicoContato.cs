using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloContatos;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao_J.iary.ModuloContato
{
    public class ServicoContato
    {
        private IContextoPersistencia ContextoPersistencia;
        private IRepositorioContato RepositorioContato;
        public ServicoContato(IContextoPersistencia contextoPersistencia, IRepositorioContato repositorioContato)
        {
            ContextoPersistencia = contextoPersistencia;
            RepositorioContato = repositorioContato;
        }
        public Result<Contato> Inserir(Contato contato) 
        {
            try
            {
                // validação dos dados do contato

                RepositorioContato.Inserir(contato);
                ContextoPersistencia.GravarDados();

                return Result.Ok(contato);
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
    }
}
