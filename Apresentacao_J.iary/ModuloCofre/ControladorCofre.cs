using Aplicacao_J.iary.ModuloCofre;
using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Dominio_J.iary.ModuloCofre;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao_J.iary.ModuloCofre
{
    public class ControladorCofre : ControladorBase
    {
        private IServiceLocator ServiceLocator;
        private ServicoCofre servicoCofre;
        private Usuario Logged;
        public ControladorCofre(IServiceLocator serviceLocator, Usuario logado, ServicoCofre servicoCofre)
        {
            ServiceLocator = serviceLocator;
            Logged = logado;
            this.servicoCofre = servicoCofre;
        }
        public Form cofre = new Form()
        {
            FormBorderStyle = FormBorderStyle.None,
            MaximizeBox = false,
            MinimizeBox = true,
            StartPosition = FormStartPosition.CenterScreen,
            Size = new Size(542, 448)
        };

        public override void Inserir()
        {
            UCCofre ucCofre = new UCCofre(Logged, ServiceLocator);

            ucCofre.Dock = DockStyle.Fill;
            ucCofre.GravarDados = servicoCofre.Inserir;
            if (servicoCofre.VerificarCofre(Logged))
            {
                ucCofre.labelTitulo.Text = "Cofre";
                ucCofre.buttonDesbloquear.Text = "Desbloquear";
            }
            else if (!servicoCofre.VerificarCofre(Logged))
            {
                ucCofre.labelTitulo.Text = "Crie um cofre";
                ucCofre.buttonDesbloquear.Text = "Criar";
            }
            ucCofre.Desbloquear = servicoCofre.DesbloquearCofre;
            cofre.Controls.Add(ucCofre);
            cofre.ShowDialog();
        }
    }
}
