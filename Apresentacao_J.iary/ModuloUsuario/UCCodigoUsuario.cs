using Dominio_J.iary.ModuloUsuario;
using FluentResults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Apresentacao_J.iary.ModuloUsuario
{
    public partial class UCCodigoUsuario : UserControl
    {
        public string _textoAlert;
        private Usuario usuario;
        private Result<string> _codigoGerado;
        public UCCodigoUsuario()
        {
            InitializeComponent();
        }

        public Func<Usuario, Result<Usuario>> VerificarUsuario { get; set; }

        public Func<Usuario, Result<string>> Codigo { get; set; }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {

            string codigoVerificacao = ReunirCodigo();

            if (_codigoGerado.IsSuccess && codigoVerificacao == _codigoGerado.Value)
            {
                this.ParentForm.DialogResult = DialogResult.OK;
                this.ParentForm.Close();
            }
        }

        private string ReunirCodigo()
        {
            return textBoxUnitario.Text + textBoxDecimal.Text + textBoxCentena.Text + textBoxMilesimo.Text + textBoxDecimalMilesimo.Text + textBoxMilesimoCentezimo.Text;
        }

        private void UCCodigoUsuario_Load(object sender, EventArgs e)
        {
            labelApresentacao.Text = _textoAlert;
            var codigo = Codigo(usuario);
            _codigoGerado = codigo;
            MessageBox.Show(codigo.Value);
        }

        private void textBoxUnitario_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUnitario.Text.Length == 1)
                textBoxDecimal.Focus();
        }

        private void textBoxDecimal_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDecimal.Text.Length == 1)
                textBoxCentena.Focus();
        }

        private void textBoxCentena_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCentena.Text.Length == 1)
                textBoxMilesimo.Focus();
        }
        private void textBoxMilesimo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMilesimo.Text.Length == 1)
                textBoxDecimalMilesimo.Focus();
            textBoxDecimalMilesimo.Focus();
        }


        private void textBoxDecimalMilesimo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDecimalMilesimo.Text.Length == 1)
                textBoxMilesimoCentezimo.Focus();
        }
        private void textBoxMilesimoCentezimo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMilesimoCentezimo.Text.Length == 1)
                buttonConfirmar.Focus();
        }
        private void textBoxMilesimo_TabStopChanged(object sender, EventArgs e)
        {

        }

    }
}
