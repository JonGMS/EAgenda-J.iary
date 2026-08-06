namespace Apresentacao_J.iary.ModuloTarefa
{
    partial class UCTarefa
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
            labelTitulo = new Label();
            textBoxTitulo = new TextBox();
            labelPrioridade = new Label();
            comboBoxPrioridade = new ComboBox();
            labelStatus = new Label();
            textBoxDescricao = new TextBox();
            labelDescricao = new Label();
            labelCheck = new Label();
            textBoxCheck = new TextBox();
            buttonAddCheck = new Button();
            comboBoxArmazenamento = new ComboBox();
            labelArmazenamento = new Label();
            buttonFinalizar = new Button();
            labelCheckBox = new Label();
            comboBoxStatus = new ComboBox();
            dataGridViewCheck = new DataGridView();
            labelErroTitulo = new Label();
            labelErroDescricao = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCheck).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Copperplate Gothic Light", 12F);
            labelTitulo.Location = new Point(133, 82);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(84, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Titulo:";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.BorderStyle = BorderStyle.FixedSingle;
            textBoxTitulo.CharacterCasing = CharacterCasing.Upper;
            textBoxTitulo.Font = new Font("Segoe UI", 12F);
            textBoxTitulo.Location = new Point(133, 106);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(431, 34);
            textBoxTitulo.TabIndex = 1;
            // 
            // labelPrioridade
            // 
            labelPrioridade.AutoSize = true;
            labelPrioridade.Font = new Font("Copperplate Gothic Light", 12F);
            labelPrioridade.Location = new Point(131, 206);
            labelPrioridade.Name = "labelPrioridade";
            labelPrioridade.Size = new Size(133, 21);
            labelPrioridade.TabIndex = 2;
            labelPrioridade.Text = "Prioridade:";
            // 
            // comboBoxPrioridade
            // 
            comboBoxPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrioridade.FlatStyle = FlatStyle.System;
            comboBoxPrioridade.Font = new Font("Segoe UI", 12F);
            comboBoxPrioridade.FormattingEnabled = true;
            comboBoxPrioridade.Items.AddRange(new object[] { "Baixa", "Media", "Alta", "Urgente" });
            comboBoxPrioridade.Location = new Point(133, 230);
            comboBoxPrioridade.Name = "comboBoxPrioridade";
            comboBoxPrioridade.Size = new Size(199, 36);
            comboBoxPrioridade.TabIndex = 3;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Copperplate Gothic Light", 12F);
            labelStatus.Location = new Point(373, 206);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(84, 21);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "Status";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescricao.CharacterCasing = CharacterCasing.Upper;
            textBoxDescricao.Font = new Font("Segoe UI", 12F);
            textBoxDescricao.Location = new Point(133, 328);
            textBoxDescricao.Multiline = true;
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(431, 84);
            textBoxDescricao.TabIndex = 6;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Copperplate Gothic Light", 12F);
            labelDescricao.Location = new Point(131, 304);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(129, 21);
            labelDescricao.TabIndex = 7;
            labelDescricao.Text = "Descrição:";
            // 
            // labelCheck
            // 
            labelCheck.AutoSize = true;
            labelCheck.Font = new Font("Copperplate Gothic Light", 12F);
            labelCheck.Location = new Point(133, 468);
            labelCheck.Name = "labelCheck";
            labelCheck.Size = new Size(127, 21);
            labelCheck.TabIndex = 8;
            labelCheck.Text = "CheckBox:";
            // 
            // textBoxCheck
            // 
            textBoxCheck.BorderStyle = BorderStyle.FixedSingle;
            textBoxCheck.CharacterCasing = CharacterCasing.Upper;
            textBoxCheck.Font = new Font("Segoe UI", 12F);
            textBoxCheck.Location = new Point(133, 492);
            textBoxCheck.Name = "textBoxCheck";
            textBoxCheck.Size = new Size(376, 34);
            textBoxCheck.TabIndex = 9;
            textBoxCheck.KeyDown += textBoxCheck_KeyDown;
            // 
            // buttonAddCheck
            // 
            buttonAddCheck.FlatAppearance.BorderSize = 3;
            buttonAddCheck.FlatStyle = FlatStyle.Popup;
            buttonAddCheck.Location = new Point(515, 492);
            buttonAddCheck.Name = "buttonAddCheck";
            buttonAddCheck.Size = new Size(49, 34);
            buttonAddCheck.TabIndex = 10;
            buttonAddCheck.UseVisualStyleBackColor = true;
            buttonAddCheck.Click += buttonAddCheck_Click;
            // 
            // comboBoxArmazenamento
            // 
            comboBoxArmazenamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArmazenamento.FlatStyle = FlatStyle.System;
            comboBoxArmazenamento.Font = new Font("Segoe UI", 12F);
            comboBoxArmazenamento.FormattingEnabled = true;
            comboBoxArmazenamento.Items.AddRange(new object[] { "Padrão", "Cofre" });
            comboBoxArmazenamento.Location = new Point(133, 592);
            comboBoxArmazenamento.Name = "comboBoxArmazenamento";
            comboBoxArmazenamento.Size = new Size(199, 36);
            comboBoxArmazenamento.TabIndex = 12;
            // 
            // labelArmazenamento
            // 
            labelArmazenamento.AutoSize = true;
            labelArmazenamento.Font = new Font("Copperplate Gothic Light", 12F);
            labelArmazenamento.Location = new Point(131, 568);
            labelArmazenamento.Name = "labelArmazenamento";
            labelArmazenamento.Size = new Size(187, 21);
            labelArmazenamento.TabIndex = 11;
            labelArmazenamento.Text = "Armazenamento:";
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.BackColor = Color.DimGray;
            buttonFinalizar.FlatAppearance.BorderSize = 0;
            buttonFinalizar.Font = new Font("Copperplate Gothic Light", 12F);
            buttonFinalizar.ForeColor = Color.White;
            buttonFinalizar.Location = new Point(373, 592);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(191, 36);
            buttonFinalizar.TabIndex = 13;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = false;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // labelCheckBox
            // 
            labelCheckBox.AutoSize = true;
            labelCheckBox.Font = new Font("Copperplate Gothic Light", 12F);
            labelCheckBox.Location = new Point(783, 81);
            labelCheckBox.Name = "labelCheckBox";
            labelCheckBox.Size = new Size(121, 21);
            labelCheckBox.TabIndex = 16;
            labelCheckBox.Text = "CheckBox";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FlatStyle = FlatStyle.System;
            comboBoxStatus.Font = new Font("Segoe UI", 12F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Ausente" });
            comboBoxStatus.Location = new Point(373, 230);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(191, 36);
            comboBoxStatus.TabIndex = 17;
            // 
            // dataGridViewCheck
            // 
            dataGridViewCheck.BackgroundColor = Color.White;
            dataGridViewCheck.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCheck.Location = new Point(783, 106);
            dataGridViewCheck.MultiSelect = false;
            dataGridViewCheck.Name = "dataGridViewCheck";
            dataGridViewCheck.RowHeadersWidth = 51;
            dataGridViewCheck.Size = new Size(629, 532);
            dataGridViewCheck.TabIndex = 19;
            // 
            // labelErroTitulo
            // 
            labelErroTitulo.AutoSize = true;
            labelErroTitulo.ForeColor = Color.Red;
            labelErroTitulo.Location = new Point(210, 82);
            labelErroTitulo.Name = "labelErroTitulo";
            labelErroTitulo.Size = new Size(0, 20);
            labelErroTitulo.TabIndex = 20;
            // 
            // labelErroDescricao
            // 
            labelErroDescricao.AutoSize = true;
            labelErroDescricao.ForeColor = Color.Red;
            labelErroDescricao.Location = new Point(256, 305);
            labelErroDescricao.Name = "labelErroDescricao";
            labelErroDescricao.Size = new Size(0, 20);
            labelErroDescricao.TabIndex = 21;
            // 
            // UCTarefa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelErroDescricao);
            Controls.Add(labelErroTitulo);
            Controls.Add(dataGridViewCheck);
            Controls.Add(comboBoxStatus);
            Controls.Add(labelCheckBox);
            Controls.Add(buttonFinalizar);
            Controls.Add(comboBoxArmazenamento);
            Controls.Add(labelArmazenamento);
            Controls.Add(buttonAddCheck);
            Controls.Add(textBoxCheck);
            Controls.Add(labelCheck);
            Controls.Add(labelDescricao);
            Controls.Add(textBoxDescricao);
            Controls.Add(labelStatus);
            Controls.Add(comboBoxPrioridade);
            Controls.Add(labelPrioridade);
            Controls.Add(textBoxTitulo);
            Controls.Add(labelTitulo);
            Name = "UCTarefa";
            Size = new Size(1600, 835);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        public TextBox textBoxTitulo;
        private Label labelPrioridade;
        public ComboBox comboBoxPrioridade;
        private Label labelStatus;
        public TextBox textBoxDescricao;
        private Label labelDescricao;
        private Label labelCheck;
        public TextBox textBoxCheck;
        private Button buttonAddCheck;
        public ComboBox comboBoxArmazenamento;
        private Label labelArmazenamento;
        private Button buttonFinalizar;
        private Label labelCheckBox;
        public ComboBox comboBoxStatus;
        private ListBox listBox1;
        public DataGridView dataGridViewCheck;
        private Label labelErroTitulo;
        private Label labelErroDescricao;
    }
}
