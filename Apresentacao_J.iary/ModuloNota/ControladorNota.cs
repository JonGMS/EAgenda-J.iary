using Aplicacao_J.iary.ModuloNota;
using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.ModuloInserir;
using Apresentacao_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao_J.iary.ModuloNota
{
    public class ControladorNota : ControladorBase
    {
        private UCInserir UCInserir;
        private ServicoNota ServicoNota;
        private Usuario Logged;

        public ControladorNota(UCInserir uCInserir, ServicoNota servicoNota, Usuario usuario) //ucInserir, servicoNota, Logged
        {
            UCInserir = uCInserir;
            ServicoNota = servicoNota;
            Logged = usuario;
        }
        public override void Inserir()
        {
            UCNotas nota = new UCNotas(Logged);
            UCInserir.panelFormulario.Controls.Clear();
            nota.GravarDados = ServicoNota.Inserir;
            nota.Dock = DockStyle.Fill;
            UCInserir.panelFormulario.Controls.Add(nota);
        }
    }
}
