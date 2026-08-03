using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao_J.iary.ModuloInserir
{
    public class ControladorInserir : ControladorBase
    {
        private UCInserir UCInserir;
        private UCTelaInicial UCTelaInicial;
        private IServiceLocator ServiceLocator;
        public ControladorInserir(UCTelaInicial uc, IServiceLocator serviceLocator, UCInserir ucInserir)
        {
            
            ServiceLocator = serviceLocator;
            UCTelaInicial = uc;
            UCInserir = ucInserir;

        }
        public override void Inserir()
        {

            UCInserir.Dock = DockStyle.Fill;
            UCTelaInicial.panelContent.Controls.Clear();
            UCTelaInicial.panelContent.Controls.Add(UCInserir);
        }


    }
}
