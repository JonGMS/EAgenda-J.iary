using Aplicacao_J.iary.ModuloCategoria;
using Aplicacao_J.iary.ModuloContato;
using Aplicacao_J.iary.ModuloNota;
using Aplicacao_J.iary.ModuloTarefa;
using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Dominio_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloContatos;
using Dominio_J.iary.ModuloNota;
using Dominio_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao_J.iary.ModuloDashboard
{
    public class ControladorDashboard : ControladorBase
    {
        private UCTelaInicial TelaInicial; 
        private IServiceLocator ServiceLocator;
        private ServicoNota ServicoNota;
        private ServicoCategoria ServicoCategoria;
        private ServicoTarefa ServicoTarefa;
        private Usuario Logged;
        private ServicoContato ServicoContato;
        public ControladorDashboard(UCTelaInicial telaInicial, IServiceLocator serviceLocator, ServicoTarefa servicoTarefa, Usuario usuarioLogado, ServicoNota servicoNota, ServicoCategoria servicoCategoria, ServicoContato servicoContato)
        {
            TelaInicial = telaInicial;
            ServiceLocator = serviceLocator;
            ServicoNota = servicoNota;
            ServicoCategoria = servicoCategoria;
            ServicoTarefa = servicoTarefa;
            ServicoContato = servicoContato;
            Logged = usuarioLogado;

        }
        public override void Inserir()
        {
            UCDashBoard board = new UCDashBoard(Logged, ServiceLocator, ObterTarefas(), ObterNotas(), ObterCategorias(), ObterContatosFavoritos());
            TelaInicial.panelContent.Controls.Clear();
            TelaInicial.panelContent.Controls.Add(board);

        }
        private List<Nota> ObterNotas()
        {
            var resultado = ServicoNota.SelecionarTodos(Logged);
            if (resultado.IsSuccess)
                return resultado.Value;
            else
                return new List<Nota>();
        }
        private List<Categoria> ObterCategorias()
        {
            var resultado = ServicoCategoria.SelecionarTodos(Logged);
            if (resultado.IsSuccess)
                return resultado.Value;
            else return new List<Categoria>();
        }
        private List<Tarefa> ObterTarefas()
        {
             var resultado = ServicoTarefa.SelecionarTodos(Logged);
            if (resultado.IsSuccess)
                return resultado.Value;
            else
                return new List<Tarefa>();
        }
        private List<Contato> ObterContatosFavoritos()
        {
            var resultado = ServicoContato.SelecionarTodos(Logged);
            List<Contato> contatosFavoritos = new List<Contato>();
            if (resultado.IsSuccess)
            {
                foreach(Contato contato in resultado.Value)
                {
                    if (contato.Favorito)
                    {
                        contatosFavoritos.Add(contato);
                    }
                }
            }
            return contatosFavoritos;
        }

    }
}
