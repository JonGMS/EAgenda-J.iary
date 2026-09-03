using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloNota
{
    public class Nota : EntidadeBase<Nota>
    {
        public DateTime DataCriacao = DateTime.Now;
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public List<Anexo> Arquivos { get; set; }
        public Tarefa? Tarefa { get; set; }
        public Guid? IDTarefa { get; set; }
        public Categoria Categoria { get; set; }
        public Guid? CategoriaID { get; set; }
        public char Armazenamento { get; set; }
        public Usuario Usuario { get; set; }
        public Guid UsuarioId { get; set; }
        public Nota()
        {
            
        }
    }
    public class Anexo : EntidadeBase<Anexo>
    {
        public Nota Nota { get; set; }
        public Guid NotaId { get; set; }
        public string NomeArquivo { get; set; }
        public string Tipo { get; set; }
        public byte[] Arquivo { get; set; }
    }
}
