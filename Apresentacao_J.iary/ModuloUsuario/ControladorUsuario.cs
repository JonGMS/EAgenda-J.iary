using Aplicacao_J.iary.ModuloUsuario;
using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.ModuloLogin;
using Dominio_J.iary.ModuloLogin;
using Dominio_J.iary.ModuloUsuario;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao_J.iary.ModuloUsuario
{
    public class ControladorUsuario : ControladorBase
    {
        private Login logged;
        private readonly ServicoUsuario servicoUsuario;

        public ControladorUsuario(ServicoUsuario su)
        {
            this.servicoUsuario = su;
        }

        public Form login = new Form()
        {
            FormBorderStyle = FormBorderStyle.None,
            MaximizeBox = false,
            MinimizeBox = true,
            StartPosition = FormStartPosition.CenterScreen,
            Size = new Size(540, 652)
        };

        public override void Inserir()
        {
            UCCadastroUsuario cadastroUsuario = new UCCadastroUsuario(servicoUsuario);

            cadastroUsuario.Dock = DockStyle.Fill;

            cadastroUsuario.Usuario = new Usuario();

            cadastroUsuario.GravarRegistro = servicoUsuario.Inserir;

            login.Controls.Add(cadastroUsuario);

            login.ShowDialog();


        }
        public Login Login()
        {
            UCLogin uCLogin = new UCLogin(servicoUsuario);

            uCLogin.Dock = DockStyle.Fill;

            login.Controls.Add(uCLogin);

            uCLogin.Login = servicoUsuario.Login;

            while (true)
            {
                login.ShowDialog();
                if (uCLogin._LoginValido)
                {
                    logged = uCLogin.logged;
                    

                    return logged;
                }
                else
                {
                    uCLogin._MensagemErro = "Usuario ou senha incorreto.";
                    continue;
                }
            }
        }

        public void CodigoValidacao(Usuario usuario, ServicoUsuario servicoUsuario)
        {
            UCCodigoUsuario ucCodigo = new UCCodigoUsuario();

            ucCodigo.Dock = DockStyle.Fill;

            login.Controls.Add(ucCodigo);

            ucCodigo.Codigo = servicoUsuario.GerarCodigo;

            ucCodigo._textoAlert = $"Enviamos um código de verificação para o \r\ne-mail:{usuario.Email} \r\nDigite o código abaixo para confirmar seu cadastro.";

            login.ShowDialog();

        }
    }
}
