using Dominio_J.iary.ModuloNota;
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
        private Usuario Logged;
        public UCNotas(Usuario usuarioLogado)
        {
            Logged = usuarioLogado;
            InitializeComponent();
        }
        public Func<Nota, Result<Nota>> GravarDados { get; set; }

        private void buttonArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Selecione um arquivo";
            dialog.Filter = "Todos os arquivos (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string arquivo in dialog.FileNames)
                {
                    Image miniatura = null;

                    string extensao = Path.GetExtension(arquivo).ToLower();

                    if (extensao == ".png" ||
                        extensao == ".jpg" ||
                        extensao == ".jpeg" ||
                        extensao == ".bmp")
                    {
                        miniatura = Image.FromFile(arquivo);
                    }
                    dataGridViewAnexos.Rows.Add(
                miniatura,
                Path.GetFileName(arquivo)
            );
                }
            }
        }

        private void UCNotas_Load(object sender, EventArgs e)
        {
            PersonalizarGrid();
            //PersonalizarCheck();

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

        private void checkedListBoxDiariamente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
