using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Dominio_J.iary.ModuloCofre;
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

namespace Apresentacao_J.iary.ModuloCofre
{
    public partial class UCCofre : UserControl
    {
        private Usuario Logged;
        public bool CofreCriado;
        private IServiceLocator ServiceLocator;
        private Cofre cofre = new Cofre();
        public UCCofre(Usuario usuario, IServiceLocator serviceLocator)
        {
            Logged = usuario;
            ServiceLocator = serviceLocator;
            InitializeComponent();
        }
        public Func<Cofre, Result<Cofre>> GravarDados { get; set; }
        public Func<Usuario, bool> Verificar { get; set; }
        public Func<Cofre, Result<Cofre>> Desbloquear { get; set; }
        public Cofre Cofre
        {
            get => cofre; set => cofre = value;

        }

        private void buttonDesbloquear_Click(object sender, EventArgs e)
        {
            ObterDados();

            if (CofreCriado)
            {
                var resultado = Desbloquear(cofre);
                ApresentarResultado(resultado);
                
            }
            else
            {
                var resultado = GravarDados(cofre);
                ApresentarResultado(resultado);

            }
        }

        private void ApresentarResultado(Result<Cofre> resultado)
        {
            if (resultado.IsSuccess && CofreCriado)
            {
                MessageBox.Show("Cofre desbloqueado com sucesso! Para bloqueá-lo novamente durante esta sessão, acesse seu perfil.");
                ServiceLocator.ArmazenarCofre(cofre);
                this.ParentForm.Hide();
            }
            else if (resultado.IsSuccess && !CofreCriado)
            {
                MessageBox.Show("Seu cofre foi criado com sucesso!");
                this.ParentForm.Hide();

            }
            else if (resultado.IsFailed && CofreCriado)
            {
                labelMensagemErro.Text = "Senha incorreta! Tente novamente.";
            }
            else if (resultado.IsFailed && !CofreCriado)
            {
                labelMensagemErro.Text = resultado.Errors[0].Message;
            }
        }

        private void ObterDados()
        {
            cofre.Senha = textBoxPassWord.Text;
            cofre.UsuarioId = Logged.Id;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
        }
    }
}
