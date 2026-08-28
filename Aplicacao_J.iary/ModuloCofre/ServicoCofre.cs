using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloCofre;
using Dominio_J.iary.ModuloUsuario;
using FluentResults;
using FluentValidation.Results;
using Infra_BancoDadosORM_J.iary.ModuloCofre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao_J.iary.ModuloCofre
{
    public class ServicoCofre
    {
        private RepositorioCofreORM repositorioCofre;
        private IContextoPersistencia contexto;
        public ServicoCofre(RepositorioCofreORM repositorioCofre, IContextoPersistencia contextoPersistencia)
        {
            this.repositorioCofre = repositorioCofre;
            contexto = contextoPersistencia;
        }

        public Result<Cofre> Inserir(Cofre cofre) //Insere cofre caso não haja
        {
            try
            {
                var resultadoValidacao = ValidarCofre(cofre);
                if (resultadoValidacao.IsFailed)
                {
                    return resultadoValidacao;
                }

                repositorioCofre.Inserir(cofre);

                contexto.GravarDados();

                return Result.Ok(cofre);
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }

        }

        private Result<Cofre> ValidarCofre(Cofre cofre)
        {
            List<Error> erros = new List<Error>();

            var validador = new ValidadorCofre();

            var resultadoValidacao = validador.Validate(cofre);
            foreach (ValidationFailure item in resultadoValidacao.Errors)
                erros.Add(new Error(item.ErrorMessage));

            if (erros.Any())
                return Result.Fail(erros);

            return Result.Ok();
        }

        public bool VerificarCofre(Usuario usuario) // Verifica se o usuario já possui cofre
        {

            return repositorioCofre.VerificarCofre(usuario);

        }
                         
        public Result<Cofre> DesbloquearCofre(Cofre cofre)// Desbloqueia o cofre se a senha estiver correta
        {
            try
            {
                var cofreRecebido = repositorioCofre.SelecionarPorId(cofre.UsuarioId);
                
                if (Desbloquear(cofreRecebido, cofre))
                {
                    return Result.Ok(cofreRecebido);
                }
                else
                {
                    return Result.Fail("Senha incorreta");
                }
            }
            catch (Exception ex)
            {
                return Result.Fail("Erro inesperado ao desbloquear o cofre");
            }
        }

        private bool Desbloquear(Cofre cofreRecebido, Cofre cofreFornecido)
        {
            return cofreRecebido.Senha == cofreFornecido.Senha;
        }
    }
}
