namespace Apresentacao_J.iary.ModuloUsuario
{
    partial class UCCodigoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCodigoUsuario));
            paneltitulo = new Panel();
            buttonFechar = new Button();
            pictureBoxLogo = new PictureBox();
            textBoxUnitario = new TextBox();
            textBoxDecimal = new TextBox();
            textBoxCentena = new TextBox();
            textBoxMilesimo = new TextBox();
            textBoxDecimalMilesimo = new TextBox();
            textBoxMilesimoCentezimo = new TextBox();
            labelApresentacao = new Label();
            label2 = new Label();
            buttonConfirmar = new Button();
            labelReenvio = new Label();
            labelCronometro = new Label();
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
            paneltitulo.Location = new Point(-1, 0);
            paneltitulo.Name = "paneltitulo";
            paneltitulo.Size = new Size(543, 82);
            paneltitulo.TabIndex = 0;
            // 
            // buttonFechar
            // 
            buttonFechar.Image = (Image)resources.GetObject("buttonFechar.Image");
            buttonFechar.Location = new Point(472, 15);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(50, 50);
            buttonFechar.TabIndex = 7;
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
            // textBoxUnitario
            // 
            textBoxUnitario.Font = new Font("Agency FB", 25.8000011F);
            textBoxUnitario.Location = new Point(111, 221);
            textBoxUnitario.MaxLength = 1;
            textBoxUnitario.Name = "textBoxUnitario";
            textBoxUnitario.Size = new Size(37, 58);
            textBoxUnitario.TabIndex = 1;
            textBoxUnitario.TextAlign = HorizontalAlignment.Center;
            textBoxUnitario.TextChanged += textBoxUnitario_TextChanged;
            // 
            // textBoxDecimal
            // 
            textBoxDecimal.Font = new Font("Agency FB", 25.8000011F);
            textBoxDecimal.Location = new Point(167, 221);
            textBoxDecimal.MaxLength = 1;
            textBoxDecimal.Name = "textBoxDecimal";
            textBoxDecimal.Size = new Size(37, 58);
            textBoxDecimal.TabIndex = 2;
            textBoxDecimal.TextAlign = HorizontalAlignment.Center;
            textBoxDecimal.TextChanged += textBoxDecimal_TextChanged;
            // 
            // textBoxCentena
            // 
            textBoxCentena.Font = new Font("Agency FB", 25.8000011F);
            textBoxCentena.Location = new Point(224, 221);
            textBoxCentena.MaxLength = 1;
            textBoxCentena.Name = "textBoxCentena";
            textBoxCentena.Size = new Size(37, 58);
            textBoxCentena.TabIndex = 3;
            textBoxCentena.TextAlign = HorizontalAlignment.Center;
            textBoxCentena.TextChanged += textBoxCentena_TextChanged;
            // 
            // textBoxMilesimo
            // 
            textBoxMilesimo.Font = new Font("Agency FB", 25.8000011F);
            textBoxMilesimo.Location = new Point(281, 221);
            textBoxMilesimo.MaxLength = 1;
            textBoxMilesimo.Name = "textBoxMilesimo";
            textBoxMilesimo.Size = new Size(37, 58);
            textBoxMilesimo.TabIndex = 4;
            textBoxMilesimo.TextAlign = HorizontalAlignment.Center;
            textBoxMilesimo.TabStopChanged += textBoxMilesimo_TabStopChanged;
            textBoxMilesimo.TextChanged += textBoxMilesimo_TextChanged;
            // 
            // textBoxDecimalMilesimo
            // 
            textBoxDecimalMilesimo.Font = new Font("Agency FB", 25.8000011F);
            textBoxDecimalMilesimo.Location = new Point(338, 221);
            textBoxDecimalMilesimo.MaxLength = 1;
            textBoxDecimalMilesimo.Name = "textBoxDecimalMilesimo";
            textBoxDecimalMilesimo.Size = new Size(37, 58);
            textBoxDecimalMilesimo.TabIndex = 5;
            textBoxDecimalMilesimo.TextAlign = HorizontalAlignment.Center;
            textBoxDecimalMilesimo.TextChanged += textBoxDecimalMilesimo_TextChanged;
            // 
            // textBoxMilesimoCentezimo
            // 
            textBoxMilesimoCentezimo.Font = new Font("Agency FB", 25.8000011F);
            textBoxMilesimoCentezimo.Location = new Point(393, 221);
            textBoxMilesimoCentezimo.MaxLength = 1;
            textBoxMilesimoCentezimo.Name = "textBoxMilesimoCentezimo";
            textBoxMilesimoCentezimo.Size = new Size(37, 58);
            textBoxMilesimoCentezimo.TabIndex = 6;
            textBoxMilesimoCentezimo.TextAlign = HorizontalAlignment.Center;
            textBoxMilesimoCentezimo.TextChanged += textBoxMilesimoCentezimo_TextChanged;
            // 
            // labelApresentacao
            // 
            labelApresentacao.AutoSize = true;
            labelApresentacao.Location = new Point(60, 144);
            labelApresentacao.Name = "labelApresentacao";
            labelApresentacao.Size = new Size(433, 40);
            labelApresentacao.TabIndex = 7;
            labelApresentacao.Text = "Enviamos um código de verificação o e-mail: email@gmail.com\r\nDigite o código abaixo para confirmar seu cadastro.";
            labelApresentacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 124);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 8;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.BackColor = Color.Black;
            buttonConfirmar.ForeColor = Color.White;
            buttonConfirmar.Location = new Point(157, 335);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(228, 54);
            buttonConfirmar.TabIndex = 9;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // labelReenvio
            // 
            labelReenvio.AutoSize = true;
            labelReenvio.Location = new Point(192, 401);
            labelReenvio.Name = "labelReenvio";
            labelReenvio.Size = new Size(165, 20);
            labelReenvio.TabIndex = 11;
            labelReenvio.Text = "Não recebeu o código?";
            // 
            // labelCronometro
            // 
            labelCronometro.AutoSize = true;
            labelCronometro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCronometro.ForeColor = Color.FromArgb(198, 161, 79);
            labelCronometro.Location = new Point(192, 439);
            labelCronometro.Name = "labelCronometro";
            labelCronometro.Size = new Size(104, 20);
            labelCronometro.TabIndex = 12;
            labelCronometro.Text = "Reenviar em: ";
            // 
            // UCCodigoUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(labelCronometro);
            Controls.Add(labelReenvio);
            Controls.Add(buttonConfirmar);
            Controls.Add(label2);
            Controls.Add(labelApresentacao);
            Controls.Add(textBoxMilesimoCentezimo);
            Controls.Add(textBoxDecimalMilesimo);
            Controls.Add(textBoxMilesimo);
            Controls.Add(textBoxCentena);
            Controls.Add(textBoxDecimal);
            Controls.Add(textBoxUnitario);
            Controls.Add(paneltitulo);
            Name = "UCCodigoUsuario";
            Size = new Size(540, 652);
            Load += UCCodigoUsuario_Load;
            paneltitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel paneltitulo;
        private Button buttonFechar;
        private PictureBox pictureBoxLogo;
        public Label labelApresentacao;
        private Label label2;
        private Label labelReenvio;
        public Button buttonConfirmar;
        public Label labelCronometro;
        public TextBox textBoxUnitario;
        public TextBox textBoxDecimal;
        public TextBox textBoxCentena;
        public TextBox textBoxMilesimo;
        public TextBox textBoxDecimalMilesimo;
        public TextBox textBoxMilesimoCentezimo;
    }
}
