using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloContatos;
using Dominio_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloUsuario;
using FluentResults;
using FluentValidation.Results;
using Infra_BancoDadosORM_J.iary.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao_J.iary.ModuloCategoria
{
    public class ServicoCategoria
    {
        private IRepositorioCategoria RepositorioCategoria;
        private IContextoPersistencia ContextoPersistencia;
        private JiaryDbContext contexto;
        public ServicoCategoria(IContextoPersistencia contextoPersistencia, IRepositorioCategoria repositorioCategoria, JiaryDbContext contexto)
        {
            this.contexto = contexto;
            ContextoPersistencia = contextoPersistencia;
            RepositorioCategoria = repositorioCategoria;
        }
        public Result<Categoria> Inserir(Categoria categoria, Usuario logado)
        {
            try
            {
                var resultadoValidacao = ValidarCategoria(categoria, logado);
                if (resultadoValidacao.IsFailed)
                {
                    return resultadoValidacao;
                }

                contexto.Attach(logado);

                categoria.Usuario = logado;
                categoria.UsuarioId = logado.Id;

                RepositorioCategoria.Inserir(categoria);
                ContextoPersistencia.GravarDados();

                return Result.Ok(categoria);
            }
            catch
            {
                return Result.Fail("Falha ao inserir categoria");
            }
            
        }

        private Result<Categoria> ValidarCategoria(Categoria categoria, Usuario logado)
        {
            List<Error> erros = new List<Error>();

            var validador = new ValidadorCategoria();

            var resultadoValidacao = validador.Validate(categoria);
            foreach (ValidationFailure item in resultadoValidacao.Errors)
                erros.Add(new Error(item.ErrorMessage));

            var resultadoComparacao = CompararTitulo(categoria, logado);

            if (resultadoComparacao.IsSuccess)
            {
                if (resultadoComparacao.Value == true)
                    erros.Add(new Error("Já existe uma categoria com esse título!"));
            }
            else
            {
                erros.Add(new Error(resultadoComparacao.Errors.ToString()));
            }

            if (erros.Any())
                return Result.Fail(erros);

            return Result.Ok();
        }
        private Result<bool> CompararTitulo(Categoria categoria, Usuario usuarioLogado)
        {
            try
            {
                var categoriaEncontrada = RepositorioCategoria.SelecionarCategoriaPorNome(categoria.Nome, usuarioLogado);

                bool comparacao = categoriaEncontrada != null && categoriaEncontrada.Nome.Equals(categoria.Nome, StringComparison.OrdinalIgnoreCase) &&
                    categoriaEncontrada.Id != categoria.Id;

                return Result.Ok(comparacao);
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        public Result<List<Categoria>> SelecionarTodos(Usuario logado) 
        {
            try
            {
                List<Categoria> categorias = new List<Categoria>();

                categorias = RepositorioCategoria.SelecionarTodos(logado);

                return Result.Ok(categorias);
            }
            catch(Exception ex)
            {
                return Result.Fail("Falha ao listar categorias" + ex);
            }
            
        
        }

    }
}
