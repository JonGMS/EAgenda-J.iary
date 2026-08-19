using Aplicacao_J.iary.ModuloCategoria;
using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.ModuloUsuario;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao_J.iary.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase
    {
        private Usuario Logged;
        private ServicoCategoria ServicoCategoria;
        public ControladorCategoria(ServicoCategoria servicoCategoria, Usuario usuarioLogado)
        {
            Logged = usuarioLogado;
            ServicoCategoria = servicoCategoria;
        }
        public Form categoria = new Form()
        {
            FormBorderStyle = FormBorderStyle.None,
            MaximizeBox = false,
            MinimizeBox = true,
            StartPosition = FormStartPosition.CenterScreen,
            Size = new Size(542, 430)
        };
        public override void Inserir()
        {
            UCCategoria ucCategoria = new UCCategoria(Logged);

            ucCategoria.GravarDados = ServicoCategoria.Inserir;

            categoria.Controls.Add(ucCategoria);

            categoria.ShowDialog();
        }
    }
}
