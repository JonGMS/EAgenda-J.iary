using Dominio_J.iary.ModuloCategoria;
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

namespace Apresentacao_J.iary.ModuloCategoria
{
    public partial class UCCategoria : UserControl
    {
        private Categoria categoria = new Categoria();
        private Usuario Logged;
        public UCCategoria(Usuario usuarioLogado)
        {
          
            Logged = usuarioLogado;
            InitializeComponent();
        }
        public Categoria Categoria
        {
            get => categoria; set => categoria = value;
        }
        public Func<Categoria, Usuario, Result<Categoria>> GravarDados { get; set; }

        private void buttonAdicionarCategoria_Click(object sender, EventArgs e)
        {
            ObterDados();
            var resultado = GravarDados(Categoria, Logged);
            if (resultado.IsFailed)
            {
                foreach (var erro in resultado.Errors)
                {

                    if (erro.Message.Contains("TITULO"))
                    {
                        labelErroNome.Text = erro.Message;
                    }
                    else if (erro.Message.Contains("COR"))
                    {
                        labelErroCor.Text = erro.Message;
                    }
                    else
                    {
                        MessageBox.Show(erro.Message);
                    }

                }
            }
            else 
            {
                this.ParentForm.Hide();
            }
        }

        private void ObterDados()
        {
            Categoria.Nome = textBoxNome.Text;
            if(comboBoxCor != null)
            {
                Categoria.Cor = comboBoxCor.SelectedItem.ToString();
            }
            
            Categoria.Usuario = Logged;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
        }
    }
}
