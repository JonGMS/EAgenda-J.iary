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
        public Guid IDUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public string Titulo { get; set; }
        public char Prioridade { get; set; }
        public char Status { get; set; }
        public string Descricao { get; set; }
        public List<ValoresCheckBox> CheckBoxes { get; set; }
        public char Armazenamento { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public Tarefa()
        {
            
        }
        public Tarefa(Usuario usuario)
        {
            IDUsuario = usuario.Id ;
        }
        public Tarefa( string titulo, char prioridade, char status, string descricao, List<ValoresCheckBox> check, char armazenamento)
        {
            
            Titulo = titulo;
            Prioridade = prioridade;
            Status = status;
            Descricao = descricao;
            CheckBoxes = check;
            Armazenamento = armazenamento;
        }

        private Guid ObterUsuario(Usuario usuario)
        {
            Guid usuarioID = usuario.Id;
            return usuarioID;
        }
    }
    public class ValoresCheckBox : EntidadeBase<ValoresCheckBox>
    {
        public ValoresCheckBox()
        {
            
        }
        public ValoresCheckBox( string checkBoxe)
        {

            CheckBoxe = checkBoxe;
        }
        public ValoresCheckBox(Usuario logged,Tarefa idTarefa)
        {
            IdUsuario = logged.Id;
            IDTarefa = idTarefa.Id;
        }
        public Usuario Usuario { get; set; }
        public Guid IdUsuario { get; set; }
        public Tarefa Tarefa { get; set; }  
        public Guid IDTarefa { get; set; }
        public string CheckBoxe { get; set; }

        private Guid ObterTarefa(Tarefa tarefa)
        {
            Guid tarefaID = tarefa.Id;
            return tarefaID;
        }
    }
}
