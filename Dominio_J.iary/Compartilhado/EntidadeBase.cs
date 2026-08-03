using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        public Guid Id { get; set; }

        public EntidadeBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
