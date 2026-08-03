using Aplicacao_J.iary.ModuloUsuario;
using Apresentacao_J.iary.ModuloUsuario;
using Dominio_J.iary.ModuloLogin;
using Dominio_J.iary.ModuloUsuario;
using FluentResults;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao_J.iary.ModuloLogin
{
    public partial class UCLogin : UserControl
    {
        private Usuario usuario = new Usuario();
        public Login logged;
        public bool _LoginValido;
        public string _MensagemErro;
        private readonly ServicoUsuario su;
        public UCLogin(ServicoUsuario servicoUsuario)
        {
            this.su = servicoUsuario;
            InitializeComponent();
        }
        public Usuario Usuario
        {
            get => usuario; set => usuario = value;
        }
        public Func<Usuario, Result<Login>> Login { get; set; }
        private void linkLabelCadastrar_Click(object sender, EventArgs e)
        {
            var controladorUsuario = new ControladorUsuario(su);

            this.ParentForm.DialogResult = DialogResult.OK;
            this.ParentForm.Close();

            controladorUsuario.Inserir();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ObterDadosTela();

            var resultado = Login(usuario);

            if (resultado.IsSuccess)
            {

                _LoginValido = true;
                this.ParentForm.DialogResult = DialogResult.OK;
                this.logged = resultado.Value;
                this.ParentForm.Close();
            }
            else
            {
                _LoginValido = false;
                _MensagemErro = "Usuário ou senha inválidos.";
                labelMensagemErro.Text = _MensagemErro;
            }

        }

        private void UCLogin_Load(object sender, EventArgs e)
        {
            if(_MensagemErro != null)
            {
                labelMensagemErro.Text = _MensagemErro;
            }
        }
        private void ObterDadosTela()
        {
            usuario.Username = textBoxUsername.Text;
            usuario.Password = textBoxPassWord.Text;
        }
    }
}
