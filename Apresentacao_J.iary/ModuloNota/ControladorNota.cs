using Aplicacao_J.iary.ModuloCategoria;
using Aplicacao_J.iary.ModuloNota;
using Aplicacao_J.iary.ModuloTarefa;
using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloInserir;
using Apresentacao_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloTarefa;
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
        private IServiceLocator ServiceLocator;
        private UCInserir UCInserir;
        private ServicoNota ServicoNota;
        private Usuario Logged;
        private ServicoCategoria ServicoCategoria;
        private ServicoTarefa ServicoTarefa;
        public ControladorNota(UCInserir uCInserir,
            ServicoNota servicoNota,
            Usuario usuario,
            IServiceLocator service,
            ServicoCategoria servicoCategoria,
            ServicoTarefa servicoTarefa) //ucInserir, servicoNota, Logged
        {

            UCInserir = uCInserir;
            ServicoNota = servicoNota;
            Logged = usuario;
            ServiceLocator = service;
            ServicoCategoria = servicoCategoria;
            ServicoTarefa = servicoTarefa;
        }
        public override void Inserir()
        {
            UCNotas nota = new UCNotas(Logged, ServiceLocator, ObterCategorias(), ObterTarefa());
            UCInserir.panelFormulario.Controls.Clear();
            nota.AtualizarCategorias = ObterCategorias;
            nota.GravarDados = ServicoNota.Inserir;
            nota.Dock = DockStyle.Fill;
            UCInserir.panelFormulario.Controls.Add(nota);
        }
        public List<Categoria> ObterCategorias()
        {
            var resultadoListagem =
                ServicoCategoria.SelecionarTodos(Logged);

            if (resultadoListagem.IsSuccess)
                return resultadoListagem.Value;

            return new List<Categoria>();
        }
        public List<Tarefa> ObterTarefa()
        {
            var resultadoListagem = ServicoTarefa.SelecioarTodos(Logged);
            if(resultadoListagem.IsSuccess)
                return resultadoListagem.Value;

            return new List<Tarefa>();
        }
    }
}
