using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloContatos;
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

namespace Apresentacao_J.iary.ModuloContato
{
    public partial class UCContato : UserControl
    {
        private ControladorBase controlador;
        private IServiceLocator ServiceLocator;
        private Contato contato = new Contato();
        public UCContato(IServiceLocator serviceLocator, Usuario usuarioLogado, List<Categoria> categorias)
        {
            ServiceLocator = serviceLocator;

            InitializeComponent();
            PreencherComboBoxCategoria(categorias);
        }
        public Contato Contato
        {
            get => contato; set => contato = value;
        }
        public Func<Contato, Result<Contato>> GravarDados { get; set; }
        private void buttonAdicionarCategoria_Click(object sender, EventArgs e)
        {
            controlador = ServiceLocator.Get<ControladorCategoria>();
            controlador.Inserir();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            ObterDados();
            var resultado = GravarDados(contato);
        }

        private void ObterDados()
        {
            contato.Nome = textBoxNome.Text;
            contato.Email = textBoxEmail.Text;
            contato.DataNascimento = dateTimePickerDataNascimento.Value;
            contato.Telefone = maskedTextBoxTelefone.Text;
            contato.Categoria = comboBoxCategoria.SelectedItem.ToString();
            contato.Empresa = textBoxEmpresa.Text;
            contato.TelefoneEmpresa = maskedTextBoxTelefoneEmpresa.Text;
            contato.Armazenamento = comboBoxArmazenamento.SelectedItem.ToString()[0];
            contato.Favorito = Favorito;
        }
        private void PreencherComboBoxCategoria(List<Categoria> categorias)
        {
            if (categorias.Count == 0)
            {
                labelMensagemErroCategoria.Text = "Nenhuma categoria cadastrada.";
            }
            //comboBoxCategoria.DataSource = null;
            comboBoxCategoria.DisplayMember = nameof(Categoria.Nome);
            comboBoxCategoria.ValueMember = nameof(Categoria.Id);
            comboBoxCategoria.DataSource = categorias;

            comboBoxCategoria.SelectedIndex = 0;
            comboBoxArmazenamento.SelectedIndex = 0;
        }
        private bool Favorito = false;
        private void buttonFavorito_Click(object sender, EventArgs e)
        {
            if(Favorito == false)
            {
                buttonFavorito.ForeColor = Color.HotPink;
                Favorito = true;
            }
            else
            {
                buttonFavorito.ForeColor = Color.Black;
                Favorito = false;
            }
        }
    }
}
