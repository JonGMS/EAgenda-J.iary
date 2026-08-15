using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloTarefa;
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
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public List<Anexo> Arquivos { get; set; }
        public List<ValoresCheckBox> Checkboxes {get;set;}
        public Tarefa Tarefa { get; set; }
        public Guid IDTarefa { get; set; }
        public Color Cor { get; set; }
        public char Armazenamento { get; set; }
        public Nota()
        {
            
        }
    }
    public class Anexo : EntidadeBase<Anexo>
    {
        public string NomeArquivo { get; set; }
        public string Tipo { get; set; }
        public byte[] Arquivo { get; set; }
    }
}
