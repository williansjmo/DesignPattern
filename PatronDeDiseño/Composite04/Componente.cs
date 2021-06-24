using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite04
{
    public class Componente<T> : IComponente<T>
    {
        public T Nombre { get; set ; }

        public Componente(T Parametro)
        {
            Nombre = Parametro;
        }

        public void Adicionar(IComponente<T> componente)
        {
            Console.WriteLine("Solo se adiciona a los compuestos, no a los componentes");
        }

        public IComponente<T> Borrar(T Elemento)
        {
            Console.WriteLine("No se puede eliminar directamente");
            return this;
        }

        public IComponente<T> Buscar(T Elemento)
        {
            if (Elemento.Equals(Nombre))
                return this;
            else
                return null;
            
        }

        public string Mostrar(int Profundidad)
        {
            return new String('-', Profundidad) + Nombre + "\n\r";
        }
    }
}
