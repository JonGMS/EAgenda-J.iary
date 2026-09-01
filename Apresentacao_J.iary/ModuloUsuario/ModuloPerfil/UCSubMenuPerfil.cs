using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloUsuario.ModuloPerfil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao_J.iary.ModuloPerfil
{
    public partial class UCSubMenuPerfil : UserControl
    {
        private ControladorBase controlador;

        private IServiceLocator serviceLocator;
        public UCSubMenuPerfil(IServiceLocator serviceLocator)
        {
            this.serviceLocator = serviceLocator; 
            InitializeComponent();
        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            controlador = serviceLocator.Get<ControladorPerfil>();

            controlador.Inserir();
        }
    }
}
