namespace Apresentacao_J.iary.ModuloPerfil
{
    partial class UCSubMenuPerfil
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
            buttonPerfil = new Button();
            buttonLogout = new Button();
            panelDivisoria = new Panel();
            SuspendLayout();
            // 
            // buttonPerfil
            // 
            buttonPerfil.FlatAppearance.BorderSize = 0;
            buttonPerfil.FlatStyle = FlatStyle.Flat;
            buttonPerfil.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPerfil.Image = Properties.Resources.buttonPerfil;
            buttonPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPerfil.Location = new Point(0, 0);
            buttonPerfil.Name = "buttonPerfil";
            buttonPerfil.Size = new Size(241, 43);
            buttonPerfil.TabIndex = 0;
            buttonPerfil.Text = "ABRIR PERFIL";
            buttonPerfil.TextAlign = ContentAlignment.MiddleRight;
            buttonPerfil.UseVisualStyleBackColor = true;
            buttonPerfil.Click += buttonPerfil_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogout.Image = Properties.Resources.buttonLogout;
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(0, 53);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(239, 40);
            buttonLogout.TabIndex = 1;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.TextAlign = ContentAlignment.MiddleRight;
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // panelDivisoria
            // 
            panelDivisoria.BackColor = SystemColors.ScrollBar;
            panelDivisoria.Location = new Point(3, 49);
            panelDivisoria.Name = "panelDivisoria";
            panelDivisoria.Size = new Size(230, 4);
            panelDivisoria.TabIndex = 2;
            // 
            // UCSubMenuPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panelDivisoria);
            Controls.Add(buttonLogout);
            Controls.Add(buttonPerfil);
            Name = "UCSubMenuPerfil";
            Size = new Size(244, 98);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPerfil;
        private Button buttonLogout;
        private Panel panelDivisoria;
    }
}
