using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloCofre
{
    public class Cofre : EntidadeBase<Cofre>
    {
        public Usuario Usuario { get; set; }
        public Guid UsuarioId { get; set; }

        public string Senha { get; set; }

        public Cofre(Usuario usuario, string password)
        {
            UsuarioId = usuario.Id;
            Senha = password;
        }
        public Cofre()
        {
            
        }
    }
}
