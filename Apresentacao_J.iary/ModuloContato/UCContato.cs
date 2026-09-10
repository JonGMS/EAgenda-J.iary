using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloCategoria;
using Apresentacao_J.iary.ModuloCofre;
using Dominio_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloContatos;
using Dominio_J.iary.ModuloTarefa;
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
        private bool Desbloqueado;
        private ControladorBase controlador;
        private IServiceLocator ServiceLocator;
        private Contato contato = new Contato();
        private Usuario Logged;
        public UCContato(IServiceLocator serviceLocator, Usuario usuarioLogado, List<Categoria> categorias, List<Contato> contatos)
        {
            ServiceLocator = serviceLocator;
            Logged = usuarioLogado;
            InitializeComponent();
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;
            PreencherComboBoxCategoria(categorias);
            DataTable dt = PreencherCabecalho();
            PreencherContatos(contatos, dt);
        }

        private void PreencherContatos(List<Contato> contatos, DataTable dt)
        {
            foreach (Contato contato in contatos)
            {
                if (contato.Favorito)
                {
                    dt.Rows.Add(contato.Nome, contato.Telefone, "♥");

                    dataGridViewContatos.DataSource = dt;

                    dataGridViewContatos.Columns["♥"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    for (int i = 0; i < contatos.Count; i++)
                    {
                        if (contatos[i].Favorito)
                        {
                            dataGridViewContatos.Rows[i].Cells["♥"].Style.ForeColor = Color.Pink;
                        }
                    }
                }
                else
                {
                    dt.Rows.Add(contato.Nome, contato.Telefone, " ");
                }

            }
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
            if (!Desbloqueado && comboBoxArmazenamento.SelectedItem.ToString() == "Cofre")
            {
                labelErroArmazenamento.Text = "O cofre pessoal ainda está bloqueado";
                return;
            }
            var resultado = GravarDados(contato);
            if (resultado.IsFailed)
            {
                foreach (Error erro in resultado.Errors)
                {
                    MessageBox.Show(erro.Message);
                }

            }
            else
            {
                textBoxNome.Clear();
                textBoxEmail.Clear();
                textBoxEmpresa.Clear();
                maskedTextBoxTelefone.Clear();
                maskedTextBoxTelefoneEmpresa.Clear();
            }
        }

        private void ObterDados()
        {
            contato.Nome = textBoxNome.Text;
            contato.Email = textBoxEmail.Text;
            contato.DataNascimento = dateTimePickerDataNascimento.Value;
            if (dateTimePickerDataNascimento.Value == DateTime.Now)
            {
                contato.DataNascimento = null;
            }
            contato.Telefone = maskedTextBoxTelefone.Text;
            contato.Categoria = comboBoxCategoria.SelectedItem.ToString();
            contato.Empresa = textBoxEmpresa.Text;
            contato.TelefoneEmpresa = maskedTextBoxTelefoneEmpresa.Text;
            contato.Armazenamento = comboBoxArmazenamento.SelectedItem.ToString()[0];
            if (controlador == null)
            {
                controlador = ServiceLocator.Get<ControladorCofre>();
            }
            if (comboBoxArmazenamento.SelectedItem == "Cofre")
            {
                if (!ServiceLocator.ConferirCofre())
                {
                    controlador.Inserir();
                    if (ServiceLocator.ConferirCofre())
                    {
                        Desbloqueado = true;
                        contato.Armazenamento = comboBoxArmazenamento.SelectedItem.ToString()[0];
                    }

                    else
                        Desbloqueado = false;
                }
            }
            else
                contato.Armazenamento = comboBoxArmazenamento.SelectedItem.ToString()[0];
            contato.Favorito = Favorito;
            contato.UsuarioID = Logged.Id;
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
            if (Favorito == false)
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

        private DataTable PreencherCabecalho()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NOME");
            dt.Columns.Add("TELEFONE");
            dt.Columns.Add("♥");

            dataGridViewContatos.DataSource = dt;

            dataGridViewContatos.Columns["NOME"].Width = 300;

            dataGridViewContatos.Columns["TELEFONE"].Width = 300;

            dataGridViewContatos.Columns["♥"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewContatos.Columns["♥"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewContatos.Columns["♥"].Width = 40;

            dataGridViewContatos.Width = 711;

            dataGridViewContatos.BorderStyle = BorderStyle.None;

            dataGridViewContatos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;

            dataGridViewContatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            return dt;
        }

        private void UCContato_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewContatos_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
