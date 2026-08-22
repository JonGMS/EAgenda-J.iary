using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloRotina
{
    public class Rotina : EntidadeBase<Rotina>
    {
        public Rotina()
        {
            
        }
        public Usuario Usuario { get; set; }
        public Guid UsuarioID { get; set; }
        public Tarefa Tarefa { get; set; }
        public Guid TarefaID { get; set; }
        public List<string> Dias { get; set; }
        public Rotina(Usuario usuario, Tarefa tarefa, List<string> Dias )
        {
            UsuarioID = usuario.Id;
            TarefaID = tarefa.Id;
            this.Dias = Dias; 
        }
    }
    public class DiaRotina : EntidadeBase<DiaRotina>
    {
        public Guid UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        public Guid TarefaID { get; set; }
        public Tarefa Tarefa { get; set; }

        public string Dia { get; set; }
    }
}
