namespace Apresentacao_J.iary.ModuloNota
{
    partial class UCNotas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            labelErroTitulo = new Label();
            textBoxTitulo = new TextBox();
            labelTitulo = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            labelDescricao = new Label();
            openFileDialogNotas = new OpenFileDialog();
            label2 = new Label();
            labelAnexo = new Label();
            buttonArquivo = new Button();
            dataGridViewAnexos = new DataGridView();
            label3 = new Label();
            labelTarefa = new Label();
            comboBox1 = new ComboBox();
            comboBoxCategoria = new ComboBox();
            label4 = new Label();
            labelPersonalizar = new Label();
            buttonFinalizar = new Button();
            comboBoxArmazenamento = new ComboBox();
            labelArmazenamento = new Label();
            buttonAdicionarCategoria = new Button();
            labelMensagemErroCategoria = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnexos).BeginInit();
            SuspendLayout();
            // 
            // labelErroTitulo
            // 
            labelErroTitulo.AutoSize = true;
            labelErroTitulo.ForeColor = Color.Red;
            labelErroTitulo.Location = new Point(191, 105);
            labelErroTitulo.Name = "labelErroTitulo";
            labelErroTitulo.Size = new Size(0, 20);
            labelErroTitulo.TabIndex = 23;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.BorderStyle = BorderStyle.FixedSingle;
            textBoxTitulo.CharacterCasing = CharacterCasing.Upper;
            textBoxTitulo.Font = new Font("Segoe UI", 12F);
            textBoxTitulo.Location = new Point(133, 106);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(431, 34);
            textBoxTitulo.TabIndex = 22;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Copperplate Gothic Light", 12F);
            labelTitulo.Location = new Point(133, 82);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(84, 21);
            labelTitulo.TabIndex = 21;
            labelTitulo.Text = "Titulo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(191, 195);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(133, 196);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(431, 206);
            textBox1.TabIndex = 25;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Copperplate Gothic Light", 12F);
            labelDescricao.Location = new Point(133, 172);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(129, 21);
            labelDescricao.TabIndex = 24;
            labelDescricao.Text = "Descrição:";
            // 
            // openFileDialogNotas
            // 
            openFileDialogNotas.FileName = "openFileDialog1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(783, 116);
            label2.Name = "label2";
            label2.Size = new Size(219, 19);
            label2.TabIndex = 27;
            label2.Text = "Selecione os arquivos";
            // 
            // labelAnexo
            // 
            labelAnexo.AutoSize = true;
            labelAnexo.Font = new Font("Copperplate Gothic Light", 12F);
            labelAnexo.Location = new Point(783, 81);
            labelAnexo.Name = "labelAnexo";
            labelAnexo.Size = new Size(83, 21);
            labelAnexo.TabIndex = 28;
            labelAnexo.Text = "Anexo:";
            // 
            // buttonArquivo
            // 
            buttonArquivo.BackColor = Color.DimGray;
            buttonArquivo.FlatAppearance.BorderSize = 0;
            buttonArquivo.Font = new Font("Copperplate Gothic Light", 12F);
            buttonArquivo.ForeColor = Color.White;
            buttonArquivo.Location = new Point(1023, 106);
            buttonArquivo.Name = "buttonArquivo";
            buttonArquivo.Size = new Size(191, 36);
            buttonArquivo.TabIndex = 29;
            buttonArquivo.Text = "Arquivo";
            buttonArquivo.UseVisualStyleBackColor = false;
            buttonArquivo.Click += buttonArquivo_Click;
            // 
            // dataGridViewAnexos
            // 
            dataGridViewAnexos.AllowUserToAddRows = false;
            dataGridViewAnexos.AllowUserToOrderColumns = true;
            dataGridViewAnexos.BackgroundColor = Color.White;
            dataGridViewAnexos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnexos.Location = new Point(783, 148);
            dataGridViewAnexos.Name = "dataGridViewAnexos";
            dataGridViewAnexos.ReadOnly = true;
            dataGridViewAnexos.RowHeadersWidth = 51;
            dataGridViewAnexos.Size = new Size(629, 198);
            dataGridViewAnexos.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(191, 550);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 34;
            // 
            // labelTarefa
            // 
            labelTarefa.AutoSize = true;
            labelTarefa.Font = new Font("Copperplate Gothic Light", 12F);
            labelTarefa.Location = new Point(133, 527);
            labelTarefa.Name = "labelTarefa";
            labelTarefa.Size = new Size(90, 21);
            labelTarefa.TabIndex = 32;
            labelTarefa.Text = "Tarefa:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 550);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(431, 36);
            comboBox1.TabIndex = 35;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.Font = new Font("Segoe UI", 12F);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(133, 462);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(372, 36);
            comboBoxCategoria.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(191, 462);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 37;
            // 
            // labelPersonalizar
            // 
            labelPersonalizar.AutoSize = true;
            labelPersonalizar.Font = new Font("Copperplate Gothic Light", 12F);
            labelPersonalizar.Location = new Point(133, 439);
            labelPersonalizar.Name = "labelPersonalizar";
            labelPersonalizar.Size = new Size(127, 21);
            labelPersonalizar.TabIndex = 36;
            labelPersonalizar.Text = "Categoria:";
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.BackColor = Color.DimGray;
            buttonFinalizar.FlatAppearance.BorderSize = 0;
            buttonFinalizar.Font = new Font("Copperplate Gothic Light", 12F);
            buttonFinalizar.ForeColor = Color.White;
            buttonFinalizar.Location = new Point(1023, 402);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(191, 36);
            buttonFinalizar.TabIndex = 41;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = false;
            // 
            // comboBoxArmazenamento
            // 
            comboBoxArmazenamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArmazenamento.FlatStyle = FlatStyle.System;
            comboBoxArmazenamento.Font = new Font("Segoe UI", 12F);
            comboBoxArmazenamento.FormattingEnabled = true;
            comboBoxArmazenamento.Items.AddRange(new object[] { "Padrão", "Cofre" });
            comboBoxArmazenamento.Location = new Point(783, 402);
            comboBoxArmazenamento.Name = "comboBoxArmazenamento";
            comboBoxArmazenamento.Size = new Size(199, 36);
            comboBoxArmazenamento.TabIndex = 40;
            // 
            // labelArmazenamento
            // 
            labelArmazenamento.AutoSize = true;
            labelArmazenamento.Font = new Font("Copperplate Gothic Light", 12F);
            labelArmazenamento.Location = new Point(781, 378);
            labelArmazenamento.Name = "labelArmazenamento";
            labelArmazenamento.Size = new Size(187, 21);
            labelArmazenamento.TabIndex = 39;
            labelArmazenamento.Text = "Armazenamento:";
            // 
            // buttonAdicionarCategoria
            // 
            buttonAdicionarCategoria.BackColor = Color.DimGray;
            buttonAdicionarCategoria.FlatAppearance.BorderSize = 0;
            buttonAdicionarCategoria.Font = new Font("Copperplate Gothic Light", 12F);
            buttonAdicionarCategoria.ForeColor = Color.White;
            buttonAdicionarCategoria.Location = new Point(511, 462);
            buttonAdicionarCategoria.Name = "buttonAdicionarCategoria";
            buttonAdicionarCategoria.Size = new Size(53, 36);
            buttonAdicionarCategoria.TabIndex = 42;
            buttonAdicionarCategoria.Text = "+";
            buttonAdicionarCategoria.UseVisualStyleBackColor = false;
            buttonAdicionarCategoria.Click += buttonAdicionarCategoria_Click;
            // 
            // labelMensagemErroCategoria
            // 
            labelMensagemErroCategoria.AutoSize = true;
            labelMensagemErroCategoria.ForeColor = Color.Red;
            labelMensagemErroCategoria.Location = new Point(256, 439);
            labelMensagemErroCategoria.Name = "labelMensagemErroCategoria";
            labelMensagemErroCategoria.Size = new Size(0, 20);
            labelMensagemErroCategoria.TabIndex = 43;
            // 
            // UCNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelMensagemErroCategoria);
            Controls.Add(buttonAdicionarCategoria);
            Controls.Add(buttonFinalizar);
            Controls.Add(comboBoxArmazenamento);
            Controls.Add(labelArmazenamento);
            Controls.Add(comboBoxCategoria);
            Controls.Add(label4);
            Controls.Add(labelPersonalizar);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(labelTarefa);
            Controls.Add(dataGridViewAnexos);
            Controls.Add(buttonArquivo);
            Controls.Add(labelAnexo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(labelDescricao);
            Controls.Add(labelErroTitulo);
            Controls.Add(textBoxTitulo);
            Controls.Add(labelTitulo);
            Name = "UCNotas";
            Size = new Size(1600, 835);
            Load += UCNotas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnexos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelErroTitulo;
        public TextBox textBoxTitulo;
        private Label labelTitulo;
        private Label label1;
        public TextBox textBox1;
        private Label labelDescricao;
        private OpenFileDialog openFileDialogNotas;
        private Label label2;
        private Label labelAnexo;
        private Button buttonArquivo;
        public DataGridView dataGridViewAnexos;
        private Label label3;
        private Label labelTarefa;
        private ComboBox comboBox1;
        private ComboBox comboBoxCategoria;
        private Label label4;
        private Label labelPersonalizar;
        private Button buttonFinalizar;
        public ComboBox comboBoxArmazenamento;
        private Label labelArmazenamento;
        private Button buttonAdicionarCategoria;
        private Label labelMensagemErroCategoria;
    }
}
