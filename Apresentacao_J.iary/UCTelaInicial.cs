using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloCofre;
using Apresentacao_J.iary.ModuloContato;
using Apresentacao_J.iary.ModuloDashboard;
using Apresentacao_J.iary.ModuloInserir;
using Apresentacao_J.iary.ModuloPerfil;
using Apresentacao_J.iary.ModuloUsuario;
using Apresentacao_J.iary.ModuloUsuario.ModuloPerfil;
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
            pictureBoxUsuarioIcon.Enabled = false;
            pictureBoxCombo.Enabled = false;
            panelContent.Controls.Add(new UCDashBoard());
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

        public UCSubMenuPerfil ucPerfil;

        private void panelComboPerfil_Click(object sender, EventArgs e)
        {
            controlador = serviceLocator.Get<ControladorSubMenuPerfil>();
            controlador.Inserir();
        }

        private void UCTelaInicial_MouseDown(object sender, MouseEventArgs e)
        {
            if (ucPerfil != null && ucPerfil.Visible)
            {
                if (!ucPerfil.Bounds.Contains(e.Location))
                {
                    ucPerfil.Visible = false;
                    this.MouseDown -= UCTelaInicial_MouseDown;
                }
            }
        }

        private void panelContent_MouseHover(object sender, EventArgs e)
        {
            if (ucPerfil != null && ucPerfil.Visible)
            {
                if (ucPerfil.Visible == true)
                {
                    ucPerfil.Visible = false;
                    this.MouseDown -= UCTelaInicial_MouseDown;
                }
            }
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            UCDashBoard dashboard = new UCDashBoard();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(dashboard);
        }

        private void buttonCofre_Click(object sender, EventArgs e)
        {
            if (!serviceLocator.ConferirCofre())
            {
                controlador = serviceLocator.Get<ControladorCofre>();
                controlador.Inserir();
                if (!serviceLocator.ConferirCofre())
                    return;
            }
            panelContent.BackColor = Color.Red;


        }

        private void buttonContato_Click(object sender, EventArgs e)
        {
            controlador = serviceLocator.Get<ControladorContato>();
            controlador.Inserir();
        }
    }
}
