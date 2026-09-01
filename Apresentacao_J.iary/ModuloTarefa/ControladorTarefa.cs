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
        private IServiceLocator Service;
        private ServicoTarefa Servico;
        public ControladorTarefa(UCInserir inserir, ServicoTarefa servicoTarefa, Usuario usuario, IServiceLocator service)
        {
            ucInserir = inserir;
            Logged = usuario;
            //ucInserir = inserir;
            Servico = servicoTarefa;
            Service = service; 
        }

        public override void Inserir()
        {

            UCTarefa tarefa = new UCTarefa(Logged, Service);
            ucInserir.panelFormulario.Controls.Clear();
            tarefa.GravarDados = Servico.Inserir;
            tarefa.Dock = DockStyle.Fill;
            ucInserir.panelFormulario.Controls.Add(tarefa);
        }


    }
}
