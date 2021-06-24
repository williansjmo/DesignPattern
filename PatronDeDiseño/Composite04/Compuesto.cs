using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite04
{
    public class Compuesto<T> : IComponente<T>
    {
        // Lista donde guardamos los elementos que va guardar
        List<IComponente<T>> Elementos;

        // Identificador
        public T Nombre { get ; set ; }

        public Compuesto(T Parametro)
        {
            Nombre = Parametro;

            Elementos = new List<IComponente<T>>();
        }

        public void Adicionar(IComponente<T> componente)
        {
            Elementos.Add(componente);
        }

        public IComponente<T> Borrar(T Elemento)
        {
            // Buscamos el elemento a borrar
            IComponente<T> elemento = this.Buscar(Elemento);

            // Si la encontramos, la eliminamos de la lista
            if(elemento != null)
            {
                (this as Compuesto<T>).Elementos.Remove(elemento);
            }

            return this;
        }

        public IComponente<T> Buscar(T Elemento)
        {
            if (Nombre.Equals(Elemento))
                return this;

            IComponente<T> encontrado = null;

            // Recorremos la lista y buscamos en nuestro elementos
            foreach (IComponente<T> elemento in Elementos)
            {
                encontrado = elemento.Buscar(Elemento);
                if (encontrado != null)
                    break;
            }

            return encontrado;
        }

        public string Mostrar(int Profundidad)
        {
            // COntruimos la cadena con una cantidad de - igual a la profundidad
            StringBuilder infoElemento = new StringBuilder(new String('-', Profundidad));

            // Adicionamos la informacion del compuesto
            infoElemento.Append($"Compuesto: {Nombre} elementos: {Elementos.Count} \n\r");

            // Adicionamos los elementos
            foreach (IComponente<T> elemento in Elementos)
                infoElemento.Append(elemento.Mostrar(Profundidad + 1));

            return infoElemento.ToString();
        }
    }
}
