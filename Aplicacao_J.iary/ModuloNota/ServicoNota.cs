using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloNota;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao_J.iary.ModuloNota
{
    public class ServicoNota
    {
        private IContextoPersistencia ContextoPersistencia;
        public ServicoNota(IContextoPersistencia contextoPersistencia, IRepositorioNota repositorioNota)
        {
            
        }

        public Result<Nota> Inserir(Nota nota)
        {
            try
            {

                return Result.Ok(nota);
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
    }
}
