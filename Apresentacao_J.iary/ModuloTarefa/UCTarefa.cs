using Aplicacao_J.iary.ModuloCofre;
using Apresentacao_J.iary.Compartilhado;
using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloCofre;
using Dominio_J.iary.ModuloCofre;
using Dominio_J.iary.ModuloNota;
using Dominio_J.iary.ModuloRotina;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Apresentacao_J.iary.ModuloTarefa
{
    public partial class UCTarefa : UserControl
    {
        private ControladorBase controlador;
        private IServiceLocator ServiceLocator;
        private List<ValoresCheckBox> CheckBoxes = new List<ValoresCheckBox>();
        private List<Rotina> rotinas = new List<Rotina>();
        private Usuario Logged;
        private Tarefa tarefa;
        private string _MensagemErro;
        private bool Verificar;
        private bool Desbloqueado;

        public UCTarefa(Usuario usuarioLogged, IServiceLocator serviceLocator)
        {
            Logged = usuarioLogged;
            tarefa = new Tarefa(Logged);
            ServiceLocator = serviceLocator;
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get => tarefa; set => tarefa = value;
        }
        public Func<Tarefa, List<Rotina>, Result<Tarefa>> GravarDados { get; set; }


        private void ObterDados()
        {
            //tarefa.Id = 
            tarefa.Titulo = textBoxTitulo.Text;
            tarefa.Descricao = textBoxDescricao.Text;
            tarefa.Prioridade = comboBoxPrioridade.SelectedItem.ToString()[0];
            tarefa.Status = comboBoxStatus.SelectedItem.ToString()[0];
            if (radioButtonRotina.Checked)
                rotinas = ObterDadosRotina();
            else
                tarefa.Rotina = new List<Rotina>();

            if (radioButtonData.Checked) 
                tarefa.DataMarcada = dateTimePickerData.Value;
            else
                tarefa.DataMarcada = null; ;

            ObterDadosGrid();
            tarefa.CheckBoxes = CheckBoxes;
            if(controlador == null)
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
                        tarefa.Armazenamento = comboBoxArmazenamento.SelectedItem.ToString()[0];
                    }

                    else
                        Desbloqueado = false;
                }   
            }
            else 
                tarefa.Armazenamento = comboBoxArmazenamento.SelectedItem.ToString()[0];


            //MessageBox.Show($"Prioridade: {tarefa.Prioridade}. \nStatus: {tarefa.Status}\n Armazenamento: {tarefa.Armazenamento}");
        }

        private List<Rotina> ObterDadosRotina()
        {
            List<Rotina> rotinas = new List<Rotina>();
            List<string> dias = new List<string>();
            dias = checkBoxDomingo.Checked ? dias.Append("DOM").ToList() : dias;
            dias = checkBoxSegunda.Checked ? dias.Append("SEG").ToList() : dias;
            dias = checkBoxTerca.Checked ? dias.Append("TER").ToList() : dias;
            dias = checkBoxQuarta.Checked ? dias.Append("QUA").ToList() : dias;
            dias = checkBoxQuinta.Checked ? dias.Append("QUI").ToList() : dias;
            dias = checkBoxSexta.Checked ? dias.Append("SEX").ToList() : dias;
            dias = checkBoxSabado.Checked ? dias.Append("SAB").ToList() : dias;

            foreach (var dia in dias)
            {
                Rotina rotina = new Rotina(Logged, tarefa, new List<string> { dia });
                rotinas.Add(rotina);
            }

            return rotinas;
        }

        private void ObterDadosGrid()
        {
            CheckBoxes.Clear();
            foreach (DataGridViewRow row in dataGridViewCheck.Rows)
            {
                if (row.IsNewRow) continue;

                string texto = row.Cells["colCheck"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(texto))
                    continue;

                var valor = new ValoresCheckBox
                {
                    CheckBoxe = texto,
                    IdUsuario = Logged.Id,
                    Tarefa = tarefa

                };

                CheckBoxes.Add(valor);
            }
        }

        private void buttonAddCheck_Click(object sender, EventArgs e)
        {
            ValoresCheckBox checkBox = new ValoresCheckBox();
            checkBox.CheckBoxe = textBoxCheck.Text;
            CheckBoxes.Add(checkBox);

            if (CheckBoxes.Count == 1)
                PersonalizarGridCheck();


            int rowIndex = dataGridViewCheck.Rows.Add();
            dataGridViewCheck.Rows[rowIndex].Cells[0].Value = textBoxCheck.Text;

            textBoxCheck.Clear();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            ObterDados();
            if (!Desbloqueado && comboBoxArmazenamento.SelectedItem.ToString() == "Cofre")
            {
                labelErroArmazenamento.Text = "O cofre pessoal ainda está bloqueado";
                return;
            }
            var resultado = GravarDados(tarefa, rotinas);
            if (resultado.IsFailed)
            {
                CheckBoxes.Clear();
                foreach (var erro in resultado.Errors)
                {

                    if (erro.Message.Contains("TITULO"))
                    {
                        labelErroTitulo.Text = erro.Message;
                    }
                    else if (erro.Message.Contains("DESCRIÇÃO"))
                    {
                        labelErroDescricao.Text = erro.Message;
                    }
                    else
                    {
                        MessageBox.Show(erro.Message);
                    }

                }
            }
            else
            {
                textBoxTitulo.Clear();
                textBoxDescricao.Clear();
                CheckBoxes.Clear();
            }

        }

        private void textBoxCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValoresCheckBox checkBox = new ValoresCheckBox();
                checkBox.CheckBoxe = textBoxCheck.Text;
                CheckBoxes.Add(checkBox);

                if (CheckBoxes.Count == 1)
                    PersonalizarGridCheck();


                int rowIndex = dataGridViewCheck.Rows.Add();
                dataGridViewCheck.Rows[rowIndex].Cells[0].Value = textBoxCheck.Text;
                textBoxCheck.Clear();

                e.SuppressKeyPress = true;
            }
        }
        private bool ValidarTabelas()
        {
            return CheckBoxes.Count == 0; ;
        }
        private void PersonalizarGridCheck()
        {

            dataGridViewCheck.Columns.Add("colCheck", "Valores");
            dataGridViewCheck.Columns[0].Width = 576;
            dataGridViewCheck.Columns[0].Resizable = DataGridViewTriState.False;

        }

        private void UCTarefa_Load(object sender, EventArgs e)
        {
            comboBoxArmazenamento.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;
            comboBoxPrioridade.SelectedIndex = 0;
        }

        private void radioButtonRotina_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonData.Checked = false;
            panelRotina.Visible = true;
        }

        private void radioButtonData_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonRotina.Checked = false;
            panelRotina.Visible = false;
        }
    }
}
