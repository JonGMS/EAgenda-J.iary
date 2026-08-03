using Aplicacao_J.iary.ModuloTarefa;
using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloInserir;
using Apresentacao_J.iary.ModuloLogin;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao_J.iary.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        public UCInserir ucInserir;
        private Usuario Logged;

        private ServicoTarefa Servico;
        public ControladorTarefa(UCInserir inserir, ServicoTarefa servicoTarefa, Usuario usuario)
        {
            ucInserir = inserir;
            Logged = usuario;
            //ucInserir = inserir;
            Servico = servicoTarefa;

        }

        public override void Inserir()
        {
            MessageBox.Show("Entrou no método Inserir");

            if (ucInserir == null)
            {
                MessageBox.Show("ucInserir está nulo");
                return;
            }

            if (ucInserir.panelFormulario == null)
            {
                MessageBox.Show("panelFormulario está nulo");
                return;
            }
            UCTarefa tarefa = new UCTarefa(Logged);
            ucInserir.panelFormulario.Controls.Clear();
            tarefa.GravarDados = Servico.Inserir;
            tarefa.Dock = DockStyle.Fill;
            ucInserir.panelFormulario.Controls.Add(tarefa);
        }
    }
}
