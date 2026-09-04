using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloPerfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao_J.iary.ModuloUsuario.ModuloPerfil
{
    public class ControladorSubMenuPerfil : ControladorBase
    {
        private UCTelaInicial TelaInicial;
        private IServiceLocator ServiceLocator;
        private UCSubMenuPerfil SubMenuPerfil;
        public ControladorSubMenuPerfil(IServiceLocator serviceLocator, UCTelaInicial telaInicial, UCSubMenuPerfil subMenuPerfil)
        {
            ServiceLocator = serviceLocator;
            TelaInicial = telaInicial;
            SubMenuPerfil = subMenuPerfil;
        }
        public override void Inserir()
        {
            if (SubMenuPerfil != null)
            {
                TelaInicial.ucPerfil = SubMenuPerfil;
                TelaInicial.ucPerfil.Location = new Point(1620, 80);

                if (!TelaInicial.Controls.Contains(TelaInicial.ucPerfil))
                {
                    TelaInicial.Controls.Add(TelaInicial.ucPerfil);
                }
                else
                {
                    TelaInicial.Controls.Remove(TelaInicial.ucPerfil);
                }

                TelaInicial.ucPerfil.Show();
                TelaInicial.ucPerfil.BringToFront();
            }
        }
    }
}
