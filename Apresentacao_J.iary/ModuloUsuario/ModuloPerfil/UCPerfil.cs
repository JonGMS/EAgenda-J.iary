using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao_J.iary.ModuloUsuario.ModuloPerfil
{
    public partial class UCPerfil : UserControl
    {
        public UCPerfil()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            labelUsername = new Label();
            labelDataCadastro = new Label();
            labelEmail = new Label();
            buttonCofre = new Button();
            labelCofre = new Label();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Copperplate Gothic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(71, 57);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(132, 53);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "JON";
            labelUsername.TextAlign = ContentAlignment.MiddleLeft;
            labelUsername.Click += labelUsername_Click;
            // 
            // labelDataCadastro
            // 
            labelDataCadastro.AutoSize = true;
            labelDataCadastro.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDataCadastro.ForeColor = SystemColors.ControlDark;
            labelDataCadastro.Location = new Point(71, 110);
            labelDataCadastro.Name = "labelDataCadastro";
            labelDataCadastro.Size = new Size(150, 21);
            labelDataCadastro.TabIndex = 1;
            labelDataCadastro.Text = "05/08/2024";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(71, 131);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(239, 28);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "joaoggabriell@gmail.com";
            // 
            // buttonCofre
            // 
            buttonCofre.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            buttonCofre.FlatAppearance.BorderSize = 2;
            buttonCofre.FlatStyle = FlatStyle.Flat;
            buttonCofre.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCofre.ForeColor = Color.FromArgb(192, 0, 0);
            buttonCofre.Location = new Point(1244, 99);
            buttonCofre.Name = "buttonCofre";
            buttonCofre.Size = new Size(290, 49);
            buttonCofre.TabIndex = 3;
            buttonCofre.Text = "BLOQUEADO";
            buttonCofre.TextAlign = ContentAlignment.MiddleLeft;
            buttonCofre.UseVisualStyleBackColor = true;
            // 
            // labelCofre
            // 
            labelCofre.AutoSize = true;
            labelCofre.Font = new Font("Copperplate Gothic Light", 9F);
            labelCofre.Location = new Point(1466, 80);
            labelCofre.Name = "labelCofre";
            labelCofre.Size = new Size(68, 16);
            labelCofre.TabIndex = 4;
            labelCofre.Text = "COFRE";
            // 
            // UCPerfil
            // 
            BackColor = Color.White;
            Controls.Add(labelCofre);
            Controls.Add(buttonCofre);
            Controls.Add(labelEmail);
            Controls.Add(labelDataCadastro);
            Controls.Add(labelUsername);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "UCPerfil";
            Size = new Size(1597, 919);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelUsername;

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private Label labelDataCadastro;
        private Label labelEmail;
        private Button buttonCofre;
        private Label labelCofre;
    }
}
