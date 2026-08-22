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
        private UCTelaInicial telaPrincipal;
        public UCSubMenuPerfil(UCTelaInicial tela)
        {
            InitializeComponent();
            telaPrincipal = tela;
        }

    }
}
