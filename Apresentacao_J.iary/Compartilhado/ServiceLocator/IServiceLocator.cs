using Dominio_J.iary.ModuloCofre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao_J.iary.Compartilhado.ServiceLocator
{
    public interface IServiceLocator
    {
        T Get<T>() where T : ControladorBase;
        void ExecutarInsercao(string nomeControlador);
        void ArmazenarCofre(Cofre cofre);
        bool ConferirCofre();
    }
}
