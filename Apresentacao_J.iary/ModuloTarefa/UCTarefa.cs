using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
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

namespace Apresentacao_J.iary.ModuloTarefa
{
    public partial class UCTarefa : UserControl
    {
        private List<ValoresCheckBox> CheckBoxes = new List<ValoresCheckBox>();
        private Usuario Logged;
        private Tarefa tarefa;
        public UCTarefa(Usuario usuarioLogged)
        {
            Logged = usuarioLogged;
            tarefa = new Tarefa(Logged);

            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get => tarefa; set => tarefa = value;
        }
        public Func<Tarefa, Result<Tarefa>> GravarDados { get; set; }


        private void ObterDados()
        {
            //tarefa.Id = 
            tarefa.Titulo = textBoxTitulo.Text;
            tarefa.Descricao = textBoxDescricao.Text;
            tarefa.Prioridade = comboBoxPrioridade.SelectedItem.ToString()[0];
            tarefa.Status = comboBoxStatus.SelectedItem.ToString()[0];
            tarefa.CheckBoxes = CheckBoxes;
            tarefa.Aramazenamento = comboBoxArmazenamento.SelectedItem.ToString()[0];
        }

        private void buttonAddCheck_Click(object sender, EventArgs e)
        {
            ValoresCheckBox checkBox = new ValoresCheckBox();
            checkBox.CheckBoxe = textBoxCheck.Text;
            CheckBoxes.Add(checkBox);

            checkedListBox.Items.Add(textBoxCheck.Text);
            textBoxCheck.Clear();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            ObterDados();
            GravarDados(tarefa);
        }

        private void textBoxCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValoresCheckBox checkBox = new ValoresCheckBox();
                checkBox.CheckBoxe = textBoxCheck.Text;
                CheckBoxes.Add(checkBox);

                checkedListBox.Items.Add(textBoxCheck.Text);
                textBoxCheck.Clear();

                e.SuppressKeyPress = true;
            }
        }
    }
}
