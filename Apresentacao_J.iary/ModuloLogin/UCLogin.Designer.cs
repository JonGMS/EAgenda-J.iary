namespace Apresentacao_J.iary.ModuloLogin
{
    partial class UCLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLogin));
            paneltitulo = new Panel();
            buttonFechar = new Button();
            pictureBoxLogo = new PictureBox();
            label1 = new Label();
            textBoxUsername = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            textBoxPassWord = new TextBox();
            labelPassword = new Label();
            buttonLogin = new Button();
            linkLabelCadastrar = new LinkLabel();
            labelMensagemErro = new Label();
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
            paneltitulo.Location = new Point(-1, -1);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 12F);
            label1.Location = new Point(102, 171);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.CharacterCasing = CharacterCasing.Upper;
            textBoxUsername.Font = new Font("Segoe UI", 15F);
            textBoxUsername.Location = new Point(121, 217);
            textBoxUsername.MaxLength = 12;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(307, 34);
            textBoxUsername.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(102, 257);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 1);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(102, 384);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 1);
            panel3.TabIndex = 6;
            // 
            // textBoxPassWord
            // 
            textBoxPassWord.BorderStyle = BorderStyle.None;
            textBoxPassWord.Font = new Font("Segoe UI", 15F);
            textBoxPassWord.Location = new Point(121, 344);
            textBoxPassWord.Name = "textBoxPassWord";
            textBoxPassWord.PasswordChar = '•';
            textBoxPassWord.Size = new Size(307, 34);
            textBoxPassWord.TabIndex = 5;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Copperplate Gothic Light", 12F);
            labelPassword.Location = new Point(102, 298);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(126, 21);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Black;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.Font = new Font("Copperplate Gothic Light", 12F);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(157, 455);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(228, 56);
            buttonLogin.TabIndex = 14;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // linkLabelCadastrar
            // 
            linkLabelCadastrar.ActiveLinkColor = Color.Black;
            linkLabelCadastrar.AutoSize = true;
            linkLabelCadastrar.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabelCadastrar.Location = new Point(218, 514);
            linkLabelCadastrar.Name = "linkLabelCadastrar";
            linkLabelCadastrar.Size = new Size(92, 20);
            linkLabelCadastrar.TabIndex = 15;
            linkLabelCadastrar.TabStop = true;
            linkLabelCadastrar.Text = "Cadastrar-se";
            linkLabelCadastrar.Click += linkLabelCadastrar_Click;
            // 
            // labelMensagemErro
            // 
            labelMensagemErro.AutoSize = true;
            labelMensagemErro.ForeColor = Color.Red;
            labelMensagemErro.Location = new Point(178, 420);
            labelMensagemErro.Name = "labelMensagemErro";
            labelMensagemErro.Size = new Size(0, 20);
            labelMensagemErro.TabIndex = 16;
            labelMensagemErro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelMensagemErro);
            Controls.Add(linkLabelCadastrar);
            Controls.Add(buttonLogin);
            Controls.Add(panel3);
            Controls.Add(textBoxPassWord);
            Controls.Add(labelPassword);
            Controls.Add(panel2);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(paneltitulo);
            Name = "UCLogin";
            Size = new Size(540, 652);
            Load += UCLogin_Load;
            paneltitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel paneltitulo;
        private PictureBox pictureBoxLogo;
        private Label label1;
        private Button buttonFechar;
        public TextBox textBoxUsername;
        private Panel panel2;
        private Panel panel3;
        public TextBox textBoxPassWord;
        private Label labelPassword;
        private Button buttonLogin;
        private LinkLabel linkLabelCadastrar;
        public Label labelMensagemErro;
    }
}
