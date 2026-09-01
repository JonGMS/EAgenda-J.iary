namespace Apresentacao_J.iary.ModuloContato
{
    partial class UCContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCContato));
            labelErroTitulo = new Label();
            comboBoxCategoria = new ComboBox();
            labelCategoria = new Label();
            labelTelefone = new Label();
            textBoxNome = new TextBox();
            labelTitulo = new Label();
            maskedTextBoxTelefone = new MaskedTextBox();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            dateTimePickerDataNascimento = new DateTimePicker();
            labelDataNascimento = new Label();
            maskedTextBoxTelefoneEmpresa = new MaskedTextBox();
            labelTelefoneEmpresa = new Label();
            textBoxEmpresa = new TextBox();
            labelEmpresa = new Label();
            dataGridView1 = new DataGridView();
            buttonFinalizar = new Button();
            labelErroArmazenamento = new Label();
            comboBoxArmazenamento = new ComboBox();
            labelArmazenamento = new Label();
            label1 = new Label();
            textBoxPesquisa = new TextBox();
            label2 = new Label();
            buttonAdicionarCategoria = new Button();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            labelMensagemErroCategoria = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelErroTitulo
            // 
            labelErroTitulo.AutoSize = true;
            labelErroTitulo.ForeColor = Color.Red;
            labelErroTitulo.Location = new Point(189, 141);
            labelErroTitulo.Name = "labelErroTitulo";
            labelErroTitulo.Size = new Size(0, 20);
            labelErroTitulo.TabIndex = 27;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.FlatStyle = FlatStyle.System;
            comboBoxCategoria.Font = new Font("Segoe UI", 12F);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(367, 283);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(176, 36);
            comboBoxCategoria.TabIndex = 26;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Copperplate Gothic Light", 12F);
            labelCategoria.Location = new Point(368, 257);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(127, 21);
            labelCategoria.TabIndex = 25;
            labelCategoria.Text = "Categoria:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Copperplate Gothic Light", 12F);
            labelTelefone.Location = new Point(110, 257);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(117, 21);
            labelTelefone.TabIndex = 23;
            labelTelefone.Text = "Telefone:";
            // 
            // textBoxNome
            // 
            textBoxNome.CharacterCasing = CharacterCasing.Upper;
            textBoxNome.Font = new Font("Segoe UI", 12F);
            textBoxNome.Location = new Point(112, 165);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(486, 34);
            textBoxNome.TabIndex = 22;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Copperplate Gothic Light", 12F);
            labelTitulo.Location = new Point(112, 141);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(75, 21);
            labelTitulo.TabIndex = 21;
            labelTitulo.Text = "Nome:";
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Font = new Font("Segoe UI", 12F);
            maskedTextBoxTelefone.Location = new Point(112, 283);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(226, 34);
            maskedTextBoxTelefone.TabIndex = 28;
            // 
            // textBoxEmail
            // 
            textBoxEmail.CharacterCasing = CharacterCasing.Upper;
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(112, 398);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(486, 34);
            textBoxEmail.TabIndex = 30;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Copperplate Gothic Light", 12F);
            labelEmail.Location = new Point(112, 374);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(73, 21);
            labelEmail.TabIndex = 29;
            labelEmail.Text = "Email:";
            // 
            // dateTimePickerDataNascimento
            // 
            dateTimePickerDataNascimento.Font = new Font("Copperplate Gothic Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerDataNascimento.Location = new Point(112, 500);
            dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            dateTimePickerDataNascimento.Size = new Size(486, 26);
            dateTimePickerDataNascimento.TabIndex = 31;
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Font = new Font("Copperplate Gothic Light", 12F);
            labelDataNascimento.Location = new Point(110, 476);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(235, 21);
            labelDataNascimento.TabIndex = 32;
            labelDataNascimento.Text = "Data de Nascimento: ";
            // 
            // maskedTextBoxTelefoneEmpresa
            // 
            maskedTextBoxTelefoneEmpresa.Font = new Font("Segoe UI", 12F);
            maskedTextBoxTelefoneEmpresa.Location = new Point(368, 609);
            maskedTextBoxTelefoneEmpresa.Mask = "(00) 00000-0000";
            maskedTextBoxTelefoneEmpresa.Name = "maskedTextBoxTelefoneEmpresa";
            maskedTextBoxTelefoneEmpresa.Size = new Size(230, 34);
            maskedTextBoxTelefoneEmpresa.TabIndex = 34;
            // 
            // labelTelefoneEmpresa
            // 
            labelTelefoneEmpresa.AutoSize = true;
            labelTelefoneEmpresa.Font = new Font("Copperplate Gothic Light", 12F);
            labelTelefoneEmpresa.Location = new Point(367, 585);
            labelTelefoneEmpresa.Name = "labelTelefoneEmpresa";
            labelTelefoneEmpresa.Size = new Size(117, 21);
            labelTelefoneEmpresa.TabIndex = 33;
            labelTelefoneEmpresa.Text = "Telefone:";
            // 
            // textBoxEmpresa
            // 
            textBoxEmpresa.CharacterCasing = CharacterCasing.Upper;
            textBoxEmpresa.Font = new Font("Segoe UI", 12F);
            textBoxEmpresa.Location = new Point(110, 609);
            textBoxEmpresa.Name = "textBoxEmpresa";
            textBoxEmpresa.Size = new Size(228, 34);
            textBoxEmpresa.TabIndex = 36;
            // 
            // labelEmpresa
            // 
            labelEmpresa.AutoSize = true;
            labelEmpresa.Font = new Font("Copperplate Gothic Light", 12F);
            labelEmpresa.Location = new Point(110, 585);
            labelEmpresa.Name = "labelEmpresa";
            labelEmpresa.Size = new Size(106, 21);
            labelEmpresa.TabIndex = 35;
            labelEmpresa.Text = "Empresa:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(760, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(711, 517);
            dataGridView1.TabIndex = 37;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.BackColor = Color.DimGray;
            buttonFinalizar.FlatAppearance.BorderSize = 0;
            buttonFinalizar.Font = new Font("Copperplate Gothic Light", 12F);
            buttonFinalizar.ForeColor = Color.White;
            buttonFinalizar.Location = new Point(367, 714);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(231, 36);
            buttonFinalizar.TabIndex = 38;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = false;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // labelErroArmazenamento
            // 
            labelErroArmazenamento.AutoSize = true;
            labelErroArmazenamento.BackColor = Color.Transparent;
            labelErroArmazenamento.ForeColor = Color.Red;
            labelErroArmazenamento.Location = new Point(289, 691);
            labelErroArmazenamento.Name = "labelErroArmazenamento";
            labelErroArmazenamento.Size = new Size(0, 20);
            labelErroArmazenamento.TabIndex = 41;
            // 
            // comboBoxArmazenamento
            // 
            comboBoxArmazenamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArmazenamento.FlatStyle = FlatStyle.System;
            comboBoxArmazenamento.Font = new Font("Segoe UI", 12F);
            comboBoxArmazenamento.FormattingEnabled = true;
            comboBoxArmazenamento.Items.AddRange(new object[] { "Padrão", "Cofre" });
            comboBoxArmazenamento.Location = new Point(112, 714);
            comboBoxArmazenamento.Name = "comboBoxArmazenamento";
            comboBoxArmazenamento.Size = new Size(226, 36);
            comboBoxArmazenamento.TabIndex = 40;
            // 
            // labelArmazenamento
            // 
            labelArmazenamento.AutoSize = true;
            labelArmazenamento.Font = new Font("Copperplate Gothic Light", 12F);
            labelArmazenamento.Location = new Point(110, 690);
            labelArmazenamento.Name = "labelArmazenamento";
            labelArmazenamento.Size = new Size(187, 21);
            labelArmazenamento.TabIndex = 39;
            labelArmazenamento.Text = "Armazenamento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(837, 141);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 44;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.CharacterCasing = CharacterCasing.Upper;
            textBoxPesquisa.Font = new Font("Segoe UI", 12F);
            textBoxPesquisa.Location = new Point(760, 165);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(553, 34);
            textBoxPesquisa.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 12F);
            label2.Location = new Point(760, 141);
            label2.Name = "label2";
            label2.Size = new Size(224, 21);
            label2.TabIndex = 42;
            label2.Text = "Pesquisar Contato:";
            // 
            // buttonAdicionarCategoria
            // 
            buttonAdicionarCategoria.BackColor = Color.DimGray;
            buttonAdicionarCategoria.FlatAppearance.BorderSize = 0;
            buttonAdicionarCategoria.Font = new Font("Copperplate Gothic Light", 12F);
            buttonAdicionarCategoria.ForeColor = Color.White;
            buttonAdicionarCategoria.Location = new Point(549, 284);
            buttonAdicionarCategoria.Name = "buttonAdicionarCategoria";
            buttonAdicionarCategoria.Size = new Size(49, 36);
            buttonAdicionarCategoria.TabIndex = 45;
            buttonAdicionarCategoria.Text = "+";
            buttonAdicionarCategoria.UseVisualStyleBackColor = false;
            buttonAdicionarCategoria.Click += buttonAdicionarCategoria_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.Transparent;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Font = new Font("Copperplate Gothic Light", 12F);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Image = (Image)resources.GetObject("buttonEditar.Image");
            buttonEditar.Location = new Point(1333, 149);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(60, 60);
            buttonEditar.TabIndex = 46;
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Transparent;
            buttonExcluir.FlatAppearance.BorderSize = 0;
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Font = new Font("Copperplate Gothic Light", 12F);
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Image = (Image)resources.GetObject("buttonExcluir.Image");
            buttonExcluir.Location = new Point(1405, 149);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(60, 60);
            buttonExcluir.TabIndex = 47;
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // labelMensagemErroCategoria
            // 
            labelMensagemErroCategoria.AutoSize = true;
            labelMensagemErroCategoria.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMensagemErroCategoria.ForeColor = Color.Red;
            labelMensagemErroCategoria.Location = new Point(487, 259);
            labelMensagemErroCategoria.Name = "labelMensagemErroCategoria";
            labelMensagemErroCategoria.Size = new Size(0, 17);
            labelMensagemErroCategoria.TabIndex = 48;
            // 
            // UCContato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelMensagemErroCategoria);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonAdicionarCategoria);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisa);
            Controls.Add(label2);
            Controls.Add(labelErroArmazenamento);
            Controls.Add(comboBoxArmazenamento);
            Controls.Add(labelArmazenamento);
            Controls.Add(buttonFinalizar);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxEmpresa);
            Controls.Add(labelEmpresa);
            Controls.Add(maskedTextBoxTelefoneEmpresa);
            Controls.Add(labelTelefoneEmpresa);
            Controls.Add(labelDataNascimento);
            Controls.Add(dateTimePickerDataNascimento);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(labelErroTitulo);
            Controls.Add(comboBoxCategoria);
            Controls.Add(labelCategoria);
            Controls.Add(labelTelefone);
            Controls.Add(textBoxNome);
            Controls.Add(labelTitulo);
            Name = "UCContato";
            Size = new Size(1597, 919);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelErroTitulo;
        public ComboBox comboBoxCategoria;
        private Label labelCategoria;
        private Label labelTelefone;
        public TextBox textBoxNome;
        private Label labelTitulo;
        private MaskedTextBox maskedTextBoxTelefone;
        public TextBox textBoxEmail;
        private Label labelEmail;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label labelDataNascimento;
        private MaskedTextBox maskedTextBoxTelefoneEmpresa;
        private Label labelTelefoneEmpresa;
        public TextBox textBoxEmpresa;
        private Label labelEmpresa;
        private DataGridView dataGridView1;
        private Button buttonFinalizar;
        private Label labelErroArmazenamento;
        public ComboBox comboBoxArmazenamento;
        private Label labelArmazenamento;
        private Label label1;
        public TextBox textBoxPesquisa;
        private Label label2;
        private Button buttonAdicionarCategoria;
        private Button buttonEditar;
        private Button buttonExcluir;
        private Label labelMensagemErroCategoria;
    }
}
