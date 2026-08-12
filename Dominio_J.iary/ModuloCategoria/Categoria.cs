using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloCategoria
{
    public class Categoria : EntidadeBase<Categoria>
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public Categoria()
        {
            
        }
        public Categoria(string nome, string cor, Usuario usuario)
        {
            UsuarioId = usuario.Id;
            Nome = nome;
            Cor = cor;
        }
    }
}
