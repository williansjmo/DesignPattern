using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite04
{
    public interface IComponente<T>
    {
        T Nombre { get; set; }
        void Adicionar(IComponente<T> componente);
        IComponente<T> Borrar(T Elemento);
        IComponente<T> Buscar(T Elemento);
        string Mostrar(int Profundidad);
    }
}
