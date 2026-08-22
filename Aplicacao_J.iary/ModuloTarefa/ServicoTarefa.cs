using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloUsuario;
using FluentResults;
using FluentValidation.Results;
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
            try
            {
                var validador = ValidarTarefa(tarefa);
                if(validador.IsFailed)
                    return validador;

                RepositorioTarefa.Inserir(tarefa);
                ContextoPersistencia.GravarDados();

                return Result.Ok(tarefa);
            }
            catch(Exception ex)
            {
                return Result.Fail(ex.Message);
            }

        }

        private Result<Tarefa> ValidarTarefa(Tarefa tarefa)
        {
            List<Error> erros = new List<Error>();
            
            var validador = new ValidadorTarefa();

            var resultadoValidacao = validador.Validate(tarefa);

            foreach (ValidationFailure item in resultadoValidacao.Errors)
                erros.Add(new Error(item.ErrorMessage));

            var resultadoComparacao = CompararTitulo(tarefa);

            if (resultadoComparacao.IsSuccess)
            {
                if(resultadoComparacao.Value == true)
                     erros.Add(new Error("Já existe uma tarefa com esse título!"));
            }
            else
            {
                erros.Add(new Error(resultadoComparacao.Errors.ToString()));
            }

            if(erros.Any())
                return Result.Fail(erros);

            return Result.Ok();
        }

        private Result<bool> CompararTitulo(Tarefa tarefa)
        {
            try
            {
                var TituloEncontrado = RepositorioTarefa.SelecionarTarefaPorTitulo(tarefa.Titulo);

                bool comparacao = TituloEncontrado != null && TituloEncontrado.Titulo.Equals(tarefa.Titulo, StringComparison.OrdinalIgnoreCase) &&
                    TituloEncontrado.Id != tarefa.Id;

                return Result.Ok(comparacao);
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        public Result<List<Tarefa>> SelecionarTodos(Usuario logado)
        {
            try
            {
                return RepositorioTarefa.SelecionarTodos(logado);
            }
            catch
            {
                return new List<Tarefa>();
            }
        }
    }
}
