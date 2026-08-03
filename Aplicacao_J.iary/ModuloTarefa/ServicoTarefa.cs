using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloTarefa;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao_J.iary.ModuloTarefa
{
    public class ServicoTarefa
    {
        private IRepositorioTarefa RepositorioTarefa;
        private readonly IContextoPersistencia ContextoPersistencia;
        public ServicoTarefa(IRepositorioTarefa repositorio, IContextoPersistencia contextoPersistencia)
        {
            RepositorioTarefa = repositorio;
            ContextoPersistencia = contextoPersistencia;
        }
        public Result<Tarefa> Inserir(Tarefa tarefa)
        {
            return Result.Ok(tarefa);
        }
    }
}
