using Dominio_J.iary.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloUsuario
{
    public class Usuario : EntidadeBase<Usuario>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public Usuario()
        {
            
        }
        public Usuario(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
            DataCadastro = DateTime.Now;
        }
    }
}
