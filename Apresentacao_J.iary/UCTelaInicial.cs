using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloInserir;
using Apresentacao_J.iary.ModuloPerfil;
using Apresentacao_J.iary.ModuloUsuario;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao_J.iary
{
    public partial class UCTelaInicial : UserControl
    {

        private ControladorBase controlador;
        private IServiceLocator serviceLocator;
        public Usuario logado;
        public UCTelaInicial(IServiceLocator service, Usuario usuarioLogado)
        {
            serviceLocator = service;
            InitializeComponent();
            logado = usuarioLogado;
            PersoalizarUsuario();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            controlador = serviceLocator.Get<ControladorInserir>();

            controlador.Inserir();
        }

        private void labelTool_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void PersoalizarUsuario()
        {
            int direita = labelUsuarioLogado.Right;
            labelUsuarioLogado.Text = logado.Username;
            labelUsuarioLogado.Left = direita - labelUsuarioLogado.Width;
        }

        private void panelComboPerfil_Click(object sender, EventArgs e)
        {
            controlador = serviceLocator.Get<ControladorUsuario>();

            controlador.Inserir();
        }
    }
}
