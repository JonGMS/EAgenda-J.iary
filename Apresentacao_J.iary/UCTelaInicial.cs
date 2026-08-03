using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloInserir;
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
        public UCTelaInicial(IServiceLocator service)
        {
            serviceLocator = service;
            InitializeComponent();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            controlador = serviceLocator.Get<ControladorInserir>();

            controlador.Inserir();
        }

        private void labelTool_Click(object sender, EventArgs e)
        {

        }


    }
}
