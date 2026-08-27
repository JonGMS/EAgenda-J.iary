namespace Apresentacao_J.iary.ModuloCofre
{
    partial class UCCofre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCofre));
            labelMensagemErro = new Label();
            buttonDesbloquear = new Button();
            panel3 = new Panel();
            textBoxPassWord = new TextBox();
            labelPassword = new Label();
            paneltitulo = new Panel();
            buttonFechar = new Button();
            pictureBoxLogo = new PictureBox();
            labelTitulo = new Label();
            paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelMensagemErro
            // 
            labelMensagemErro.AutoSize = true;
            labelMensagemErro.ForeColor = Color.Red;
            labelMensagemErro.Location = new Point(179, 287);
            labelMensagemErro.Name = "labelMensagemErro";
            labelMensagemErro.Size = new Size(0, 20);
            labelMensagemErro.TabIndex = 26;
            labelMensagemErro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonDesbloquear
            // 
            buttonDesbloquear.BackColor = Color.Black;
            buttonDesbloquear.FlatAppearance.BorderSize = 0;
            buttonDesbloquear.Font = new Font("Copperplate Gothic Light", 12F);
            buttonDesbloquear.ForeColor = Color.White;
            buttonDesbloquear.Location = new Point(158, 322);
            buttonDesbloquear.Name = "buttonDesbloquear";
            buttonDesbloquear.Size = new Size(228, 56);
            buttonDesbloquear.TabIndex = 24;
            buttonDesbloquear.Text = "DESBLOQUEAR";
            buttonDesbloquear.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(103, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 1);
            panel3.TabIndex = 23;
            // 
            // textBoxPassWord
            // 
            textBoxPassWord.BorderStyle = BorderStyle.None;
            textBoxPassWord.Font = new Font("Segoe UI", 15F);
            textBoxPassWord.Location = new Point(122, 211);
            textBoxPassWord.Name = "textBoxPassWord";
            textBoxPassWord.PasswordChar = '•';
            textBoxPassWord.Size = new Size(307, 34);
            textBoxPassWord.TabIndex = 22;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Copperplate Gothic Light", 12F);
            labelPassword.Location = new Point(103, 165);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(126, 21);
            labelPassword.TabIndex = 21;
            labelPassword.Text = "Password:";
            // 
            // paneltitulo
            // 
            paneltitulo.BackColor = Color.White;
            paneltitulo.BorderStyle = BorderStyle.FixedSingle;
            paneltitulo.Controls.Add(buttonFechar);
            paneltitulo.Controls.Add(pictureBoxLogo);
            paneltitulo.Location = new Point(0, 1);
            paneltitulo.Name = "paneltitulo";
            paneltitulo.Size = new Size(543, 82);
            paneltitulo.TabIndex = 17;
            // 
            // buttonFechar
            // 
            buttonFechar.Image = (Image)resources.GetObject("buttonFechar.Image");
            buttonFechar.Location = new Point(472, 15);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(50, 50);
            buttonFechar.TabIndex = 2;
            buttonFechar.UseVisualStyleBackColor = true;
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
            labelTitulo.Font = new Font("Copperplate Gothic Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(208, 101);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(132, 32);
            labelTitulo.TabIndex = 27;
            labelTitulo.Text = "COFRE";
            // 
            // UCCofre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelTitulo);
            Controls.Add(labelMensagemErro);
            Controls.Add(buttonDesbloquear);
            Controls.Add(panel3);
            Controls.Add(textBoxPassWord);
            Controls.Add(labelPassword);
            Controls.Add(paneltitulo);
            Name = "UCCofre";
            Size = new Size(540, 450);
            paneltitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelMensagemErro;
        private LinkLabel linkLabelCadastrar;
        private Button buttonDesbloquear;
        private Panel panel3;
        public TextBox textBoxPassWord;
        private Label labelPassword;
        private Panel paneltitulo;
        private Button buttonFechar;
        private PictureBox pictureBoxLogo;
        private Label labelTitulo;
    }
}
