namespace Apresentacao_J.iary.ModuloUsuario
{
    partial class UCCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCadastroUsuario));
            paneltitulo = new Panel();
            buttonFechar = new Button();
            pictureBoxLogo = new PictureBox();
            linkLabelCadastrar = new LinkLabel();
            buttonLogin = new Button();
            panel3 = new Panel();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            panel2 = new Panel();
            textBoxUsername = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            textBoxEmail = new TextBox();
            label2 = new Label();
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
            paneltitulo.TabIndex = 1;
            // 
            // buttonFechar
            // 
            buttonFechar.Image = (Image)resources.GetObject("buttonFechar.Image");
            buttonFechar.Location = new Point(472, 15);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(50, 50);
            buttonFechar.TabIndex = 6;
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
            // linkLabelCadastrar
            // 
            linkLabelCadastrar.ActiveLinkColor = Color.Black;
            linkLabelCadastrar.AutoSize = true;
            linkLabelCadastrar.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabelCadastrar.Location = new Point(212, 584);
            linkLabelCadastrar.Name = "linkLabelCadastrar";
            linkLabelCadastrar.Size = new Size(116, 20);
            linkLabelCadastrar.TabIndex = 5;
            linkLabelCadastrar.TabStop = true;
            linkLabelCadastrar.Text = "Já possui conta?";
            linkLabelCadastrar.Click += linkLabelCadastrar_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Black;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.Font = new Font("Copperplate Gothic Light", 12F);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(157, 525);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(228, 56);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Cadastrar";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(97, 358);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 1);
            panel3.TabIndex = 21;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 15F);
            textBoxPassword.Location = new Point(116, 318);
            textBoxPassword.MaxLength = 64;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.Size = new Size(307, 34);
            textBoxPassword.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Copperplate Gothic Light", 12F);
            labelPassword.Location = new Point(97, 272);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(126, 21);
            labelPassword.TabIndex = 19;
            labelPassword.Text = "Password:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(97, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 1);
            panel2.TabIndex = 18;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.CharacterCasing = CharacterCasing.Upper;
            textBoxUsername.Font = new Font("Segoe UI", 15F);
            textBoxUsername.Location = new Point(116, 191);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(307, 34);
            textBoxUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 12F);
            label1.Location = new Point(97, 145);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 16;
            label1.Text = "Username:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(97, 480);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 1);
            panel1.TabIndex = 26;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.CharacterCasing = CharacterCasing.Lower;
            textBoxEmail.Font = new Font("Segoe UI", 14F);
            textBoxEmail.Location = new Point(116, 442);
            textBoxEmail.MaxLength = 320;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(307, 32);
            textBoxEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 12F);
            label2.Location = new Point(97, 394);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 24;
            label2.Text = "Email:";
            // 
            // UCCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(linkLabelCadastrar);
            Controls.Add(buttonLogin);
            Controls.Add(panel3);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(panel2);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(paneltitulo);
            Name = "UCCadastroUsuario";
            Size = new Size(540, 652);
            paneltitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel paneltitulo;
        private Button buttonFechar;
        private PictureBox pictureBoxLogo;
        private LinkLabel linkLabelCadastrar;
        private Button buttonLogin;
        private Panel panel3;
        public TextBox textBoxPassword;
        private Label labelPassword;
        private Panel panel2;
        public TextBox textBoxUsername;
        private Label label1;
        private Panel panel1;
        public TextBox textBoxEmail;
        private Label label2;
    }
}
