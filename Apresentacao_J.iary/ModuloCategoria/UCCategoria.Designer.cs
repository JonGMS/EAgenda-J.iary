namespace Apresentacao_J.iary.ModuloCategoria
{
    partial class UCCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCategoria));
            paneltitulo = new Panel();
            buttonFechar = new Button();
            pictureBoxLogo = new PictureBox();
            labelTitulo = new Label();
            labelTipo = new Label();
            textBoxNome = new TextBox();
            labelCor = new Label();
            comboBoxCor = new ComboBox();
            panel1 = new Panel();
            buttonAdicionarCategoria = new Button();
            labelErroCor = new Label();
            labelErroNome = new Label();
            paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // paneltitulo
            // 
            paneltitulo.BackColor = Color.White;
            paneltitulo.BorderStyle = BorderStyle.FixedSingle;
            paneltitulo.Controls.Add(buttonFechar);
            paneltitulo.Controls.Add(pictureBoxLogo);
            paneltitulo.Location = new Point(0, 0);
            paneltitulo.Name = "paneltitulo";
            paneltitulo.Size = new Size(543, 82);
            paneltitulo.TabIndex = 1;
            // 
            // buttonFechar
            // 
            buttonFechar.Image = (Image)resources.GetObject("buttonFechar.Image");
            buttonFechar.Location = new Point(472, 15);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(50, 50);
            buttonFechar.TabIndex = 2;
            buttonFechar.UseVisualStyleBackColor = true;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(157, -1);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(228, 82);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Copperplate Gothic Light", 12F);
            labelTitulo.Location = new Point(129, 110);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(288, 21);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Adicionar nova categoria";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Copperplate Gothic Light", 12F);
            labelTipo.Location = new Point(56, 167);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(75, 21);
            labelTipo.TabIndex = 3;
            labelTipo.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Copperplate Gothic Light", 12F);
            textBoxNome.Location = new Point(56, 191);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(279, 29);
            textBoxNome.TabIndex = 4;
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Font = new Font("Copperplate Gothic Light", 12F);
            labelCor.Location = new Point(56, 260);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(61, 21);
            labelCor.TabIndex = 5;
            labelCor.Text = "Cor:";
            // 
            // comboBoxCor
            // 
            comboBoxCor.Font = new Font("Copperplate Gothic Light", 12F);
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Items.AddRange(new object[] { "CINZA", "VERMELHO", "AMARELO", "VERDE", "AZUL", "LARANJA", "ROXO", "MARROM" });
            comboBoxCor.Location = new Point(56, 284);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(279, 29);
            comboBoxCor.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(363, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(131, 146);
            panel1.TabIndex = 8;
            // 
            // buttonAdicionarCategoria
            // 
            buttonAdicionarCategoria.BackColor = Color.DimGray;
            buttonAdicionarCategoria.FlatAppearance.BorderSize = 0;
            buttonAdicionarCategoria.Font = new Font("Copperplate Gothic Light", 12F);
            buttonAdicionarCategoria.ForeColor = Color.White;
            buttonAdicionarCategoria.Location = new Point(195, 353);
            buttonAdicionarCategoria.Name = "buttonAdicionarCategoria";
            buttonAdicionarCategoria.Size = new Size(154, 36);
            buttonAdicionarCategoria.TabIndex = 43;
            buttonAdicionarCategoria.Text = "Finalizar";
            buttonAdicionarCategoria.UseVisualStyleBackColor = false;
            buttonAdicionarCategoria.Click += buttonAdicionarCategoria_Click;
            // 
            // labelErroCor
            // 
            labelErroCor.AutoSize = true;
            labelErroCor.ForeColor = Color.Red;
            labelErroCor.Location = new Point(113, 261);
            labelErroCor.Name = "labelErroCor";
            labelErroCor.Size = new Size(0, 20);
            labelErroCor.TabIndex = 44;
            // 
            // labelErroNome
            // 
            labelErroNome.AutoSize = true;
            labelErroNome.ForeColor = Color.Red;
            labelErroNome.Location = new Point(129, 168);
            labelErroNome.Name = "labelErroNome";
            labelErroNome.Size = new Size(0, 20);
            labelErroNome.TabIndex = 45;
            // 
            // UCCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(labelErroNome);
            Controls.Add(labelErroCor);
            Controls.Add(buttonAdicionarCategoria);
            Controls.Add(panel1);
            Controls.Add(comboBoxCor);
            Controls.Add(labelCor);
            Controls.Add(textBoxNome);
            Controls.Add(labelTipo);
            Controls.Add(labelTitulo);
            Controls.Add(paneltitulo);
            Name = "UCCategoria";
            Size = new Size(541, 433);
            paneltitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel paneltitulo;
        private Button buttonFechar;
        private PictureBox pictureBoxLogo;
        private Label labelTitulo;
        private Label labelTipo;
        private TextBox textBoxNome;
        private Label labelCor;
        private ComboBox comboBoxCor;
        private Panel panel1;
        private Button buttonAdicionarCategoria;
        private Label labelErroCor;
        private Label labelErroNome;
    }
}
