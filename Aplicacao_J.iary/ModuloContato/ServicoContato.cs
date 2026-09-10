using Aplicacao_J.iary.ModuloCriptografar;
using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloContatos;
using Dominio_J.iary.ModuloUsuario;
using FluentResults;
using FluentValidation.Results;
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
        private ServicoCriptografia ServicoCriptografia;
        public ServicoContato(IContextoPersistencia contextoPersistencia, IRepositorioContato repositorioContato, ServicoCriptografia servicoCriptografia)
        {
            ContextoPersistencia = contextoPersistencia;
            RepositorioContato = repositorioContato;
            ServicoCriptografia = servicoCriptografia;
        }
        public Result<Contato> Inserir(Contato contato) 
        {
            try
            {
                var resultadoValidacao = ValidarContato(contato);

                if (resultadoValidacao.IsFailed)
                    return resultadoValidacao;
                
                if(contato.Armazenamento == 'C')
                {
                    ServicoCriptografia.Criptografar(contato.Nome);
                    ServicoCriptografia.Criptografar(contato.Telefone);
                    ServicoCriptografia.Criptografar(contato.Email);
                    ServicoCriptografia.Criptografar(contato.Empresa);
                    ServicoCriptografia.Criptografar(contato.TelefoneEmpresa);
                }

                RepositorioContato.Inserir(contato);
                ContextoPersistencia.GravarDados();

                return Result.Ok(contato);
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }

        private Result<Contato> ValidarContato(Contato contato)
        {
            List<Error> erros = new List<Error>();

            var validador = new ValidadorContato();

            var resultadoValidaco = validador.Validate(contato); 
            
            foreach(ValidationFailure item in resultadoValidaco.Errors)
            {
                erros.Add(new Error(item.ErrorMessage));
            }

            if (erros.Any())
                return Result.Fail(erros);
            return Result.Ok();
        }

        public Result<List<Contato>> SelecionarTodos(Usuario logado)
        {
            try
            {
                return Result.Ok(RepositorioContato.SelecionarTodos(logado));
            }
            catch(Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
    }

}
