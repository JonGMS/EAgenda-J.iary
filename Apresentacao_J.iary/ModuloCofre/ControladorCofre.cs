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


        public override void Inserir()
        {
            UCCofre ucCofre = new UCCofre(Logged);
            ucCofre.Dock = DockStyle.Fill;
            ucCofre.GravarDados = servicoCofre.Inserir;
            ucCofre.Verificar = servicoCofre.VerificarCofre;
            ucCofre.Desbloquear = servicoCofre.DesbloquearCofre;
        }
    }
}
