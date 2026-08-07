using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloLogin;
using Dominio_J.iary.ModuloUsuario;
using FluentResults;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao_J.iary.ModuloUsuario
{
    public class ServicoUsuario 
    {
        private Login logged;
        public IRepositorioUsuario RepositorioUsuario;
        private readonly IContextoPersistencia ContextoPersistencia;

        public ServicoUsuario(IRepositorioUsuario repositorioUsuario, IContextoPersistencia contextoPersistencia)
        {
            RepositorioUsuario = repositorioUsuario;
            ContextoPersistencia = contextoPersistencia;

        }
        public Result<Login> Login(Usuario usuario)
        {
            try
            {
                var UsuarioEncontrado = RepositorioUsuario.SelecionarUsuarioPorLogin(usuario.Username);
                if (UsuarioEncontrado == null)
                    return Result.Fail("Usuario não encontrado");
                bool comparacao = UsuarioEncontrado.Username == usuario.Username && UsuarioEncontrado.Password == usuario.Password;                logged = new Login(UsuarioEncontrado, comparacao);
                if (!comparacao)
                {
                    return Result.Fail("Usuario ou senha incorreto");
                }
                return Result.Ok(logged);
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
        public Result<Usuario> Inserir(Usuario usuario)
        {
            try
            {
                var validador = ValidarUsuario(usuario);

                if (validador.IsFailed)
                {
                    Result.Fail(validador.Errors.Concat(validador.Errors));
                }

                RepositorioUsuario.Inserir(usuario);

                ContextoPersistencia.GravarDados();

                return Result.Ok(usuario);
            }
            catch (Exception ex)
            {
                string msgErro = ex.Message;
                return Result.Fail(msgErro);
            }
        }
        public Result<string> GerarCodigo(Usuario usuario) 
        {
            try
            {
                Random rnd = new Random();
                int numeroSeisDigitos = rnd.Next(100000, 1000000);

                string codigo = Convert.ToString(numeroSeisDigitos);

                return Result.Ok(codigo);
            }
            catch (Exception ex)
            {
                string msgErro = ex.Message;
                return Result.Fail(msgErro);
            }
        }

        public Result<Usuario> ValidarUsuario(Usuario usuario)
        {
            var validador = new ValidadorUsuario();

            var resultadoValidacao = validador.Validate(usuario);

            List<Error> erros = new List<Error>();

            foreach (ValidationFailure item in resultadoValidacao.Errors)
                erros.Add(new Error(item.ErrorMessage));

            var resultadoComparacao = CompararUsername(usuario);

            if (resultadoComparacao.IsSuccess)
            {
                if (resultadoComparacao.Value == true)
                    erros.Add(new Error("Login já está cadastrado!"));
            }
            else
                erros.Add(new Error(resultadoComparacao.Errors[0].Message));

            if (erros.Any())
                return Result.Fail(erros);

            return Result.Ok();
        }
        public Result<bool> CompararUsername(Usuario usuario)
        {
            try
            {
                var UsuarioEncontrado = RepositorioUsuario.SelecionarUsuarioPorLogin(usuario.Username);
                
                bool comparacao = UsuarioEncontrado != null && UsuarioEncontrado.Username.Equals(usuario.Username, StringComparison.OrdinalIgnoreCase) && 
                    UsuarioEncontrado.Id != usuario.Id;

                return Result.Ok(comparacao);
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }

    }
}
