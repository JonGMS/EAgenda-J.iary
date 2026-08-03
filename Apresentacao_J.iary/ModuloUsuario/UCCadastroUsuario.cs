using Aplicacao_J.iary.ModuloUsuario;
using Apresentacao_J.iary.ModuloLogin;
using Dominio_J.iary.ModuloUsuario;
using FluentResults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao_J.iary.ModuloUsuario
{
    public partial class UCCadastroUsuario : UserControl
    {
        private ServicoUsuario su;
        
        private Usuario usuario;
        public UCCadastroUsuario(ServicoUsuario servicoUsuario)
        {
            this.su = servicoUsuario;
            InitializeComponent();
        }
        public Usuario Usuario 
        {
            get => usuario; 
            set => usuario = value;
        }
        public Func<Usuario, Result<Usuario>> GravarRegistro { get; set; }

        private void linkLabelCadastrar_Click(object sender, EventArgs e)
        {
            var controladorUsuario = new ControladorUsuario(su);

            this.ParentForm.Close();

            //controladorUsuario.Login();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ControladorUsuario controladorUsuario = new ControladorUsuario(su);

            ObterDadosTela();

            controladorUsuario.CodigoValidacao(usuario, su);

            var resultadoValidacao = GravarRegistro(usuario);
            if (resultadoValidacao.IsFailed)
            {
                MessageBox.Show("O Usuario não foi registrado");
            }



            if (resultadoValidacao.IsFailed)
            {
                string erro = resultadoValidacao.Errors[0].Message;

                if (erro.StartsWith("Falha no sistema"))
                {
                    MessageBox.Show(erro,
                    "Inserção de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //.Instancia.AtualizarRodape(erro);

                    //DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("O Usuario foi registrado");
                this.ParentForm.Close();
            }
        }
        private void ObterDadosTela()
        {
            Usuario.Username = textBoxUsername.Text;
            Usuario.Password = textBoxPassword.Text;
            Usuario.Email = textBoxEmail.Text;
        }
    }
}
