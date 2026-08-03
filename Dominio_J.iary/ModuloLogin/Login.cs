using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloLogin
{
    public class Login
    {
        public Usuario Usuario { get; set; }
        public bool Logged { get; set; }
        public Login()
        {
            
        }
        public Login(Usuario usuario, bool logged)
        {
            Usuario = usuario;
            Logged = logged;    
        }

    }
}
