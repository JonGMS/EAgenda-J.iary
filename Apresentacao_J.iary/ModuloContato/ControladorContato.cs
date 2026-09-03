using Aplicacao_J.iary.ModuloCategoria;
using Aplicacao_J.iary.ModuloContato;
using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Dominio_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao_J.iary.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private UCTelaInicial TelaInicial;
        private IServiceLocator ServiceLocator;
        private Usuario Logged;
        private ServicoCategoria ServicoCategoria;
        private ServicoContato ServicoContato;
        public ControladorContato(UCTelaInicial telaInicial, IServiceLocator service, Usuario usuarioLogado, ServicoCategoria servicoCategoria, ServicoContato servicoContato)
        {
            Logged = usuarioLogado;
            TelaInicial = telaInicial;
            ServiceLocator = service;
            ServicoCategoria = servicoCategoria;
            ServicoContato = servicoContato;
        }
        public override void Inserir()
        {
            UCContato ucContato = new UCContato(ServiceLocator, Logged, ObterCategorias());
            ucContato.GravarDados = ServicoContato.Inserir;
            TelaInicial.panelContent.Controls.Clear();
            TelaInicial.panelContent.Controls.Add(ucContato);
        }

        public List<Categoria> ObterCategorias()
        {
            var resultadoListagem =
                ServicoCategoria.SelecionarTodos(Logged);

            if (resultadoListagem.IsSuccess)
                return resultadoListagem.Value;

            return new List<Categoria>();
        }
    }
}
