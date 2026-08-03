using Dominio_J.iary.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.Compartilhado
{
    public interface IRepositorioBase<T> where T : EntidadeBase<T>
    {
        void Inserir(T registro);

        void Editar(T registro);

        void Excluir(T registro);

        T SelecionarPorId(Guid id);

        List<T> SelecionarTodos();
    }
}
