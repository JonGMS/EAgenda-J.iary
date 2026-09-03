using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_J.iary.Compartilhado;

namespace Dominio_J.iary.ModuloContatos
{
    public class Contato : EntidadeBase<Contato>
    {
        public string Nome {get; set;}
        public string Telefone { get; set; }
        public string Categoria { get; set; }
        public string? Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Empresa { get; set; }
        public char Armazenamento { get; set; }
        public string? TelefoneEmpresa { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public bool Favorito { get; set; }
        public Contato()
        {
            
        }
    }
}
