using Dominio_J.iary.ModuloCofre;
using Dominio_J.iary.ModuloUsuario;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao_J.iary.ModuloCofre
{
    public class ServicoCofre
    {
        public ServicoCofre()
        {
            
        }

        public Result<Cofre> Inserir(Cofre cofre)
        {
            return Result.Ok(cofre);
        }
        public Result<bool> VerificarCofre(Usuario usuario)
        {
            return Result.Ok(true);
        }
                         
        public Result<Cofre> DesbloquearCofre(Cofre cofre)
        {
            return Result.Ok(cofre);
        }
    }
}
