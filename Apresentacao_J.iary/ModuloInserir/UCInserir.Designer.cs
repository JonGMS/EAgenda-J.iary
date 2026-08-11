namespace Apresentacao_J.iary.ModuloInserir
{
    partial class UCInserir
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
            buttonInserirTarefa = new Button();
            buttonNota = new Button();
            panelFormulario = new Panel();
            SuspendLayout();
            // 
            // buttonInserirTarefa
            // 
            buttonInserirTarefa.BackColor = Color.White;
            buttonInserirTarefa.FlatAppearance.BorderColor = Color.FromArgb(185, 185, 185);
            buttonInserirTarefa.FlatStyle = FlatStyle.Flat;
            buttonInserirTarefa.Font = new Font("Copperplate Gothic Light", 12F);
            buttonInserirTarefa.Location = new Point(-1, -1);
            buttonInserirTarefa.Name = "buttonInserirTarefa";
            buttonInserirTarefa.Size = new Size(801, 80);
            buttonInserirTarefa.TabIndex = 0;
            buttonInserirTarefa.Text = "Tarefa";
            buttonInserirTarefa.UseVisualStyleBackColor = false;
            buttonInserirTarefa.Click += buttonInserirTarefa_Click;
            // 
            // buttonNota
            // 
            buttonNota.BackColor = Color.White;
            buttonNota.FlatAppearance.BorderColor = Color.FromArgb(185, 185, 185);
            buttonNota.FlatStyle = FlatStyle.Flat;
            buttonNota.Font = new Font("Copperplate Gothic Light", 12F);
            buttonNota.Location = new Point(800, -1);
            buttonNota.Name = "buttonNota";
            buttonNota.Size = new Size(800, 80);
            buttonNota.TabIndex = 1;
            buttonNota.Text = "Nota";
            buttonNota.UseVisualStyleBackColor = false;
            buttonNota.Click += buttonNota_Click;
            // 
            // panelFormulario
            // 
            panelFormulario.Location = new Point(0, 80);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(1600, 835);
            panelFormulario.TabIndex = 2;
            // 
            // UCInserir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelFormulario);
            Controls.Add(buttonNota);
            Controls.Add(buttonInserirTarefa);
            Name = "UCInserir";
            Size = new Size(1600, 915);
            ResumeLayout(false);
        }

        #endregion

        public Button buttonInserirTarefa;
        public Button buttonNota;
        public Panel panelFormulario;
    }
}
