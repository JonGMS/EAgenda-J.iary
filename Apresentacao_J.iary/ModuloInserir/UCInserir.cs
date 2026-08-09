using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao_J.iary.ModuloInserir
{
    public partial class UCInserir : UserControl
    {
        private IServiceLocator ServiceLocator;
        private ControladorBase controlador;
        public UCInserir(IServiceLocator serviceLocator)
        {
            ServiceLocator = serviceLocator;

            InitializeComponent();
        }

        private void buttonInserirTarefa_Click(object sender, EventArgs e)
        {
            try
            {
                //controlador = ServiceLocator.Get<ControladorTarefa>();
                //controlador.Inserir();
                ServiceLocator.ExecutarInsercao("ControladorTarefa");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private ControladorBase ObterControlador(ControladorBase controladorbase)
        {
            return this.controlador = controladorbase;
        }

        private void buttonNota_Click(object sender, EventArgs e)
        {
            ServiceLocator.ExecutarInsercao("ControladorNota");
        }
    }
}
