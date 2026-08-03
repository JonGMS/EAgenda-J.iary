using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa>
    {
        private Guid IDUsuario { get; set; }
        public string Titulo { get; set; }
        public char Prioridade { get; set; }
        public char Status { get; set; }
        public string Descricao { get; set; }
        public List<ValoresCheckBox> CheckBoxes { get; set; }
        public char Aramazenamento { get; set; }
        public Tarefa(Usuario usuario)
        {
            IDUsuario = ObterUsuario(usuario);
        }
        public Tarefa( string titulo, char prioridade, char status, string descricao, List<ValoresCheckBox> check, char armazenamento)
        {
            
            Titulo = titulo;
            Prioridade = prioridade;
            Status = status;
            Descricao = descricao;
            CheckBoxes = check;
            Aramazenamento = armazenamento;
        }

        private Guid ObterUsuario(Usuario usuario)
        {
            Guid usuarioID = usuario.Id;
            return usuarioID;
        }
    }
    public class ValoresCheckBox
    {
        public ValoresCheckBox(Tarefa idTarefa, string checkBoxe)
        {
            IDTarefa = idTarefa;
            CheckBoxe = checkBoxe;
        }
        public ValoresCheckBox()
        {
            
        }
        public Tarefa IDTarefa { get; set; }
        public string CheckBoxe { get; set; }
    }
}
