namespace Apresentacao_J.iary
{
    partial class UCTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTelaInicial));
            panelMenu = new Panel();
            labelUsuarioLogado = new Label();
            pictureBoxUsuarioIcon = new PictureBox();
            labelTool = new Label();
            pictureBoxLogo = new PictureBox();
            panelComboPerfil = new Panel();
            pictureBoxCombo = new PictureBox();
            panelContent = new Panel();
            buttonInserir = new Button();
            buttonContato = new Button();
            buttonCofre = new Button();
            buttonDiario = new Button();
            panelFooter = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuarioIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelComboPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCombo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.BorderStyle = BorderStyle.Fixed3D;
            panelMenu.Controls.Add(labelUsuarioLogado);
            panelMenu.Controls.Add(pictureBoxUsuarioIcon);
            panelMenu.Controls.Add(labelTool);
            panelMenu.Controls.Add(pictureBoxLogo);
            panelMenu.Controls.Add(panelComboPerfil);
            panelMenu.Location = new Point(-1, -1);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1922, 115);
            panelMenu.TabIndex = 0;
            // 
            // labelUsuarioLogado
            // 
            labelUsuarioLogado.AutoSize = true;
            labelUsuarioLogado.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelUsuarioLogado.Location = new Point(1799, 46);
            labelUsuarioLogado.Name = "labelUsuarioLogado";
            labelUsuarioLogado.Size = new Size(0, 21);
            labelUsuarioLogado.TabIndex = 3;
            labelUsuarioLogado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxUsuarioIcon
            // 
            pictureBoxUsuarioIcon.Image = (Image)resources.GetObject("pictureBoxUsuarioIcon.Image");
            pictureBoxUsuarioIcon.Location = new Point(1835, 23);
            pictureBoxUsuarioIcon.Name = "pictureBoxUsuarioIcon";
            pictureBoxUsuarioIcon.Size = new Size(50, 50);
            pictureBoxUsuarioIcon.TabIndex = 2;
            pictureBoxUsuarioIcon.TabStop = false;
            pictureBoxUsuarioIcon.Click += pictureBox1_Click;
            // 
            // labelTool
            // 
            labelTool.AutoSize = true;
            labelTool.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTool.Location = new Point(941, 32);
            labelTool.Name = "labelTool";
            labelTool.Size = new Size(236, 31);
            labelTool.TabIndex = 1;
            labelTool.Text = "Apresentação - Diário";
            labelTool.Click += labelTool_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(-2, -1);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(324, 114);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // panelComboPerfil
            // 
            panelComboPerfil.BackColor = Color.Transparent;
            panelComboPerfil.Controls.Add(pictureBoxCombo);
            panelComboPerfil.Location = new Point(1805, 23);
            panelComboPerfil.Name = "panelComboPerfil";
            panelComboPerfil.Size = new Size(83, 50);
            panelComboPerfil.TabIndex = 5;
            panelComboPerfil.Click += panelComboPerfil_Click;
            // 
            // pictureBoxCombo
            // 
            pictureBoxCombo.Image = (Image)resources.GetObject("pictureBoxCombo.Image");
            pictureBoxCombo.Location = new Point(7, 25);
            pictureBoxCombo.Name = "pictureBoxCombo";
            pictureBoxCombo.Size = new Size(18, 15);
            pictureBoxCombo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCombo.TabIndex = 4;
            pictureBoxCombo.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.BorderStyle = BorderStyle.FixedSingle;
            panelContent.Location = new Point(323, 109);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1597, 919);
            panelContent.TabIndex = 0;
            panelContent.MouseHover += panelContent_MouseHover;
            // 
            // buttonInserir
            // 
            buttonInserir.BackgroundImageLayout = ImageLayout.None;
            buttonInserir.FlatAppearance.BorderColor = Color.White;
            buttonInserir.FlatAppearance.BorderSize = 3;
            buttonInserir.FlatAppearance.MouseDownBackColor = Color.White;
            buttonInserir.FlatAppearance.MouseOverBackColor = Color.White;
            buttonInserir.FlatStyle = FlatStyle.Flat;
            buttonInserir.Font = new Font("Copperplate Gothic Light", 12F);
            buttonInserir.Location = new Point(3, 170);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(320, 76);
            buttonInserir.TabIndex = 1;
            buttonInserir.Text = "Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.UseWaitCursor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonContato
            // 
            buttonContato.BackgroundImageLayout = ImageLayout.None;
            buttonContato.FlatAppearance.BorderColor = Color.White;
            buttonContato.FlatAppearance.BorderSize = 3;
            buttonContato.FlatAppearance.MouseDownBackColor = Color.White;
            buttonContato.FlatAppearance.MouseOverBackColor = Color.White;
            buttonContato.FlatStyle = FlatStyle.Flat;
            buttonContato.Font = new Font("Copperplate Gothic Light", 12F);
            buttonContato.Location = new Point(0, 416);
            buttonContato.Name = "buttonContato";
            buttonContato.Size = new Size(320, 76);
            buttonContato.TabIndex = 2;
            buttonContato.Text = "Contato";
            buttonContato.UseVisualStyleBackColor = true;
            // 
            // buttonCofre
            // 
            buttonCofre.BackgroundImageLayout = ImageLayout.None;
            buttonCofre.FlatAppearance.BorderColor = Color.White;
            buttonCofre.FlatAppearance.BorderSize = 3;
            buttonCofre.FlatAppearance.MouseDownBackColor = Color.White;
            buttonCofre.FlatAppearance.MouseOverBackColor = Color.White;
            buttonCofre.FlatStyle = FlatStyle.Flat;
            buttonCofre.Font = new Font("Copperplate Gothic Light", 12F);
            buttonCofre.Location = new Point(0, 334);
            buttonCofre.Name = "buttonCofre";
            buttonCofre.Size = new Size(320, 76);
            buttonCofre.TabIndex = 3;
            buttonCofre.Text = "Cofre";
            buttonCofre.UseVisualStyleBackColor = true;
            // 
            // buttonDiario
            // 
            buttonDiario.BackgroundImageLayout = ImageLayout.None;
            buttonDiario.FlatAppearance.BorderColor = Color.White;
            buttonDiario.FlatAppearance.BorderSize = 3;
            buttonDiario.FlatAppearance.MouseDownBackColor = Color.White;
            buttonDiario.FlatAppearance.MouseOverBackColor = Color.White;
            buttonDiario.FlatStyle = FlatStyle.Flat;
            buttonDiario.Font = new Font("Copperplate Gothic Light", 12F);
            buttonDiario.Location = new Point(0, 252);
            buttonDiario.Name = "buttonDiario";
            buttonDiario.Size = new Size(320, 76);
            buttonDiario.TabIndex = 4;
            buttonDiario.Text = "Diário";
            buttonDiario.UseVisualStyleBackColor = true;
            // 
            // panelFooter
            // 
            panelFooter.Location = new Point(323, 1026);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1597, 54);
            panelFooter.TabIndex = 5;
            // 
            // UCTelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            Controls.Add(panelFooter);
            Controls.Add(buttonDiario);
            Controls.Add(buttonCofre);
            Controls.Add(buttonContato);
            Controls.Add(buttonInserir);
            Controls.Add(panelMenu);
            Controls.Add(panelContent);
            Name = "UCTelaInicial";
            Size = new Size(1924, 1083);
            MouseDown += UCTelaInicial_MouseDown;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuarioIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelComboPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCombo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxLogo;
        private Button buttonContato;
        private Button buttonCofre;
        private Button buttonDiario;
        private Panel panelFooter;
        private Label labelTool;
        private PictureBox pictureBoxUsuarioIcon;
        public Button buttonInserir;
        public Panel panelContent;
        public Panel panelMenu;
        private Label labelUsuarioLogado;
        private PictureBox pictureBoxCombo;
        private Panel panelComboPerfil;
    }
}
