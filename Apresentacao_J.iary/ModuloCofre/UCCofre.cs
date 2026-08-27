using Dominio_J.iary.ModuloCofre;
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

namespace Apresentacao_J.iary.ModuloCofre
{
    public partial class UCCofre : UserControl
    {
        private Usuario Logged;
        private Result<bool> CofreCriado;

        private Cofre cofre = new Cofre();
        public UCCofre(Usuario usuario)
        {
            Logged = usuario;
            CofreCriado = Verificar(Logged);
            InitializeComponent();
        }
        public Func<Cofre, Result<Cofre>> GravarDados{get; set;}
        public Func<Usuario, Result<bool>> Verificar { get; set; }
        public Func<Cofre, Result<Cofre>> Desbloquear { get; set; }
        public Cofre Cofre
        {
            get => cofre; set => cofre = value;
            
        }

    }
}
