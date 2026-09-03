using Apresentacao_J.iary.Compartilhado.ServiceLocator;
using Apresentacao_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloCategoria;
using Dominio_J.iary.ModuloNota;
using Dominio_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao_J.iary.ModuloDashboard
{
    public partial class UCDashBoard : UserControl
    {
        private IServiceLocator ServiceLocator;
        public UCDashBoard(Usuario usuarioLogado, IServiceLocator serviceLocator, List<Tarefa> listaTarefas, List<Nota> listaNotas, List<Categoria> listaCategorias)
        {
            InitializeComponent();
            ServiceLocator = serviceLocator;
            PersonalizarGridsColumns();
            PreencherGridTarefas(listaTarefas);
            PreencherGridNotas(listaNotas, listaCategorias);
        }



        private void PreencherGridTarefas(List<Tarefa> tarefas)
        {
            if (tarefas.Count() == 0)
            {
                
                return;
            }

            foreach (var tarefa in tarefas)
            {
                if (tarefa.Armazenamento == 'C')
                {
                    if (ServiceLocator.ConferirCofre())
                    {
                        dataGridViewTarefa.Rows.Add(tarefa.Titulo, tarefa.Status);
                    }
                    continue;
                }
                
                int rowIndex = dataGridViewTarefa.Rows.Add(tarefa.Titulo, tarefa.Status);
                if(tarefa.Status == 'A')
                {
                    dataGridViewTarefa.Rows[rowIndex].Cells[1].Style.BackColor = Color.LightGreen;
                    dataGridViewTarefa.Rows[rowIndex].Cells[1].Style.ForeColor = Color.White;
                }
                    
            }
        }

        private void PreencherGridNotas(List<Nota> notas, List<Categoria> categorias)
        {
            if (notas.Count() == 0)
            {

                return;
            }

            foreach (var nota in notas)
            {
                if (nota.Armazenamento == 'C')
                {
                    if (ServiceLocator.ConferirCofre())
                    {
                        dataGridViewNotas.Rows.Add(nota.Titulo, nota.Categoria);
                    }
                    continue;
                }

                foreach (var categoria in categorias)
                {

                    if(categoria.Id == nota.CategoriaID)
                    {   
                        int rowIndex = dataGridViewNotas.Rows.Add(nota.Titulo, categoria.Nome);
                        dataGridViewNotas.Rows[rowIndex].Cells[1].Style.ForeColor = Color.White;
                        if (categoria.Cor == "CINZA")
                        {
                            dataGridViewNotas.Rows[rowIndex].Cells[1].Style.BackColor = Color.LightGray;

                        }
                        else if (categoria.Cor == "VERMELHO")
                        {
                            dataGridViewNotas.Rows[rowIndex].Cells[1].Style.BackColor = Color.IndianRed;
                        }
                        else if (categoria.Cor == "AMARELO")
                        {
                            dataGridViewNotas.Rows[rowIndex].Cells[1].Style.BackColor = Color.LightYellow;

                        }
                        else if (categoria.Cor == "VERDE")
                        {
                            dataGridViewNotas.Rows[rowIndex].Cells[1].Style.BackColor = Color.LimeGreen;
                        }
                        else if (categoria.Cor == "AZUL")
                        {
                            dataGridViewNotas.Rows[rowIndex].Cells[1].Style.BackColor = Color.LightBlue;
                        }
                        else if (categoria.Cor == "LARANJA")
                        {
                            dataGridViewNotas.Rows[rowIndex].Cells[1].Style.BackColor = Color.Orange;

                        }
                        else if (categoria.Cor == "ROXO")
                        {
                            dataGridViewNotas.Rows[rowIndex].Cells[1].Style.BackColor = Color.RebeccaPurple;
                        }
                        else if (categoria.Cor == "MARROM")
                        {
                            dataGridViewNotas.Rows[rowIndex].Cells[1].Style.BackColor = Color.SandyBrown;
                        }
                    }
                }
            }
        }
        private void PersonalizarGridsColumns()
        {
            //TAREFAS
            dataGridViewTarefa.Columns.Clear();

            var colTitulo = new DataGridViewTextBoxColumn();
            colTitulo.Name = "Titulo";
            colTitulo.HeaderText = "Título";
            colTitulo.Width = 502;

            var colStatus = new DataGridViewTextBoxColumn();
            colStatus.Name = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Width = 60;
            colStatus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewTarefa.Columns.Add(colTitulo);
            dataGridViewTarefa.Columns.Add(colStatus);


            // NOTAS
            dataGridViewNotas.Columns.Clear();

            var colTituloNota = new DataGridViewTextBoxColumn();
            colTituloNota.Name = "Titulo";
            colTituloNota.HeaderText = "Título";
            colTituloNota.Width = 232;

            var colStatusNota = new DataGridViewTextBoxColumn();
            colStatusNota.Name = "Categoria";
            colStatusNota.HeaderText = "Categoria";
            colStatusNota.Width = 100;
            colStatusNota.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewNotas.Columns.Add(colTituloNota);
            dataGridViewNotas.Columns.Add(colStatusNota);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
