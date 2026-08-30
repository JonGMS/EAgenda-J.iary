using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloNota;
using Dominio_J.iary.ModuloUsuario;
using FluentResults;
using FluentValidation.Results;
using Infra_BancoDadosORM_J.iary.ModuloNota;
using Error = FluentResults.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Dominio_J.iary.ModuloTarefa;
using Aplicacao_J.iary.ModuloCriptografar;

namespace Aplicacao_J.iary.ModuloNota
{
    public class ServicoNota
    {
        private IContextoPersistencia ContextoPersistencia;
        private RepositorioNotaORM RepositorioNotaORM;
        private ServicoCriptografia servicoCriptografia;
        public ServicoNota(IContextoPersistencia contextoPersistencia, RepositorioNotaORM repositorioNota, ServicoCriptografia servicoCriptografia)
        {
            ContextoPersistencia = contextoPersistencia;
            RepositorioNotaORM = repositorioNota;
            this.servicoCriptografia = servicoCriptografia;
        }

        public Result<Nota> Inserir(Nota nota, Usuario logado)
        {
            try
            {
                var resultadoValidacao = ValidarNota(nota, logado);

                if (resultadoValidacao.IsFailed)
                {
                    return Result.Fail(resultadoValidacao.Errors);
                }

                if (nota.Armazenamento == 'C')
                {
                    var tarefaCriptografada = CriptografarNota(nota);
                    RepositorioNotaORM.Inserir(tarefaCriptografada);
                }
                else
                    RepositorioNotaORM.Inserir(nota);


                ContextoPersistencia.GravarDados();
                return Result.Ok(nota);
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        private Nota CriptografarNota(Nota nota)
        {
            nota.Titulo = servicoCriptografia.Criptografar(nota.Titulo);

            if (!string.IsNullOrWhiteSpace(nota.Descricao))
                nota.Descricao =
                    servicoCriptografia.Criptografar(nota.Descricao);

            foreach(Anexo anexo in nota.Arquivos)
            {
                anexo.Arquivo = servicoCriptografia.Criptografar(anexo.Arquivo);
            }

                return nota;
        }

        private Result<Nota> ValidarNota(Nota nota, Usuario logado)
        {
            List<Error> errors = new List<Error>();
            var validador = new ValidadorNota();

            var resultadoValidacao = validador.Validate(nota);
            foreach(ValidationFailure item in resultadoValidacao.Errors)
            {
             
                errors.Add(new Error(item.ErrorMessage)); 
            }
            var resultadoComparacao = CompararTitulo(nota, logado);
            if (resultadoComparacao.IsSuccess)
            {
                if(resultadoComparacao.Value == true)
                {

                    errors.Add(new Error(resultadoComparacao.Errors.ToString()));
                }
            }
            else
            {
                errors.Add(new Error(resultadoComparacao.Errors.ToString()));
            }
            if (errors.Any())
                return Result.Fail(errors);
            return Result.Ok();
        }

        private Result<bool> CompararTitulo(Nota nota, Usuario logado)
        {
            try
            {
                var notaEncontrada = RepositorioNotaORM.SelecionarNotaPorTitulo(nota, logado);
                var resultadoComparacao = notaEncontrada != null && notaEncontrada.Id != nota.Id &&
                notaEncontrada.Titulo.Equals(nota.Titulo, StringComparison.OrdinalIgnoreCase) &&
                notaEncontrada.Id != nota.Id;
                return Result.Ok(resultadoComparacao);
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
    }
}
