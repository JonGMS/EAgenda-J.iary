using Dominio_J.iary.Compartilhado;
using Dominio_J.iary.ModuloTarefa;
using Dominio_J.iary.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloCategoria
{
    public interface IRepositorioCategoria: IRepositorioBase<Categoria>
    {
        Categoria SelecionarCategoriaPorNome(string nome, Usuario logado);
    }
}
