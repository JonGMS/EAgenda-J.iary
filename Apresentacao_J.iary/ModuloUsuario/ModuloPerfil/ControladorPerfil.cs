using Apresentacao_J.iary.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao_J.iary.ModuloUsuario.ModuloPerfil
{
    internal class ControladorPerfil : ControladorBase
    {
        UCTelaInicial telaInicial;
        public ControladorPerfil(UCTelaInicial telaInicial)
        {
            this.telaInicial = telaInicial;
        }
        public override void Inserir()
        {

            UCPerfil perfil = new UCPerfil();

            perfil.Dock = DockStyle.Fill;

            telaInicial.panelContent.Controls.Clear();

            telaInicial.panelContent.Controls.Add(perfil);
        }
    }
}
