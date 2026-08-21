using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloNota;
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

namespace Apresentacao_J.iary.ModuloNota
{
    public partial class UCNotas : UserControl
    {
        private ControladorBase controlador;
        private IServiceLocator ServiceLocator;
        private Usuario Logged;
        private Nota nota = new Nota();
        public UCNotas(Usuario usuarioLogado, IServiceLocator serviceLocator, List<Categoria> listagemCategoria, List<Tarefa> listagemTarefa)
        {
            
            ServiceLocator = serviceLocator;
            Logged = usuarioLogado;
            InitializeComponent();
            PreencherComboBoxCategoria(listagemCategoria);
            PersonalizarGrid();
            PreencherComboBoxTarefa(listagemTarefa);
            PersonalizarComboBox();
        }
        public Nota Nota
        {
            get => nota; set => nota = value;
        }
        public Func<Nota, Usuario, Result<Nota>> GravarDados { get; set; }

        private List<Anexo> anexos = new List<Anexo>();
        private void buttonArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Selecione um arquivo";
            dialog.Filter = "Todos os arquivos (*.*)|*.*";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string arquivo in dialog.FileNames)
                {
                    try
                    {
                        Image miniatura = null;
                        string extensao = Path.GetExtension(arquivo).ToLower();

                        if (extensao == ".png" || extensao == ".jpg" || extensao == ".jpeg" || extensao == ".bmp")
                        {
                            miniatura = Image.FromFile(arquivo);
                        }
                        dataGridViewAnexos.Rows.Add(miniatura, Path.GetFileName(arquivo));

                        byte[] conteudoArquivo = File.ReadAllBytes(arquivo);

                        Anexo anexo = new Anexo
                        {
                            NomeArquivo = Path.GetFileName(arquivo),
                            Tipo = extensao,
                            Arquivo = conteudoArquivo
                        };
                        anexos.Add(anexo);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Não foi possível anexar o arquivo.\n{ex.Message}", "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void UCNotas_Load(object sender, EventArgs e)
        {



        }

        private void PersonalizarGrid()
        {

            //dataGridViewAnexos.Columns[0].Width = 80;

            dataGridViewAnexos.RowTemplate.Height = 100;

            DataGridViewImageColumn colMiniatura = new DataGridViewImageColumn();
            colMiniatura.Name = "Miniatura";
            colMiniatura.HeaderText = "Miniatura";
            colMiniatura.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colMiniatura.Width = 80;
            dataGridViewAnexos.Columns.Add(colMiniatura);

            dataGridViewAnexos.Columns.Add("colCheck", "Arquivo");
            dataGridViewAnexos.Columns[1].Width = 546;
            //dataGridViewAnexos.Columns[0].
            dataGridViewAnexos.Columns[0].Resizable = DataGridViewTriState.False;

            dataGridViewAnexos.GridColor = ColorTranslator.FromHtml("#E5E5E5");
            dataGridViewAnexos.RowHeadersVisible = false;
            dataGridViewAnexos.AllowUserToResizeColumns = false;
            dataGridViewAnexos.AllowUserToResizeRows = false;

        }
        public void ObterCategorias(List<Categoria> categorias)
        {
            comboBoxCategoria.DataSource = null;

            comboBoxCategoria.DisplayMember = nameof(Categoria.Nome);
            comboBoxCategoria.ValueMember = nameof(Categoria.Id);
            comboBoxCategoria.DataSource = categorias;
        }

        public Func<List<Categoria>> AtualizarCategorias { get; set; }
        private void buttonAdicionarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                controlador = ServiceLocator.Get<ControladorCategoria>();
                controlador.Inserir();

                comboBoxCategoria.DataSource = null;
                PreencherComboBoxCategoria(AtualizarCategorias());
                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Não foi possível abrir a tela de categoria. {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonAdicionarCategoria.Enabled = false;
            }

        }
        private void PreencherComboBoxCategoria(List<Categoria> categorias)
        {
            if(categorias.Count == 0)
            {
                labelMensagemErroCategoria.Text = "Nenhuma categoria cadastrada.";

            }
            comboBoxCategoria.DataSource = null;
            comboBoxCategoria.DisplayMember = nameof(Categoria.Nome);
            comboBoxCategoria.ValueMember = nameof(Categoria.Id);
            comboBoxCategoria.DataSource = categorias;

            comboBoxCategoria.SelectedIndex = -1;
        }

        private void PreencherComboBoxTarefa(List<Tarefa> tarefas)
        {
            if(tarefas.Count == 0)
            {
                labelMensagemErroTarefa.Text = "Nenhuma tarefa cadastrada. (campo opcional)";
                comboBoxTarefa.Enabled = false;
            }
            comboBoxTarefa.DataSource = null;
            comboBoxTarefa.DisplayMember = nameof(Tarefa.Titulo);
            comboBoxTarefa.ValueMember = nameof(Tarefa.Id);
            comboBoxTarefa.DataSource = tarefas;

            comboBoxTarefa.SelectedIndex = -1;
        }
        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                ObterDados();
                var resultadoGravacao = GravarDados(nota, Logged);

                if (resultadoGravacao.IsFailed)
                {
                    MessageBox.Show($"Não foi possível gravar os dados da nota.\n" +
                        $"{resultadoGravacao.Errors[0].Message}", "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    ApagarCampos();
                }
            }
            catch
            {
                MessageBox.Show("Nota não cadastrada");
            }
        }

        private void ApagarCampos()
        {
            textBoxTitulo.Clear();
            textBoxDescricao.Clear();
            dataGridViewAnexos.Rows.Clear();
            anexos.Clear();
        }

        private void ObterDados()
        {
            nota.Titulo = textBoxTitulo.Text;
            nota.Descricao = textBoxDescricao.Text;
            nota.Categoria = comboBoxCategoria.SelectedItem as Categoria;
            nota.Tarefa = comboBoxTarefa.SelectedItem as Tarefa;

            nota.UsuarioId = Logged.Id;

            nota.Arquivos = anexos;
            nota.Armazenamento = comboBoxArmazenamento.SelectedItem.ToString()[0];
        }

        private void PersonalizarComboBox()
        {
            comboBoxArmazenamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTarefa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArmazenamento.SelectedIndex = 0;
        }
    }
}
