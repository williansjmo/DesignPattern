using System;

namespace Decorador01
{
    class Program
    {
        static void Main(string[] args)
        {
            Muestra("");
            // Creamos el componente central con tipo IComponente
            // para permitir la decoracion
            IComponente miAuto = new CAuto("2018","4 puertas", 200000);
            Muestra(miAuto);

            // Si necesitamos usar un metodo propio de CAuto
            // necesitamos hacer uso de un type cast
            ((CAuto)miAuto).Puertas(true);
            Muestra("-------------------------------------------------------------------");

            //// Decoramos el auto con un sistema de sonido
            miAuto = new CSistemaSonido(miAuto);

            // Comprobamos la adicion de las caractristicas
            Muestra(miAuto.Costo());
            Muestra(miAuto.Funciona());
            Muestra(miAuto);
            Muestra("-------------------------------------------------------------------");

            miAuto = new CNitrogeno(miAuto);
            Muestra(miAuto.Costo());
            Muestra(miAuto.Funciona());
            Muestra(miAuto);
            ((CNitrogeno)miAuto).USaN();
            Muestra("-------------------------------------------------------------------");

            miAuto = new CSuspencion(miAuto);
            Muestra(miAuto.Costo());
            Muestra(miAuto.Funciona());
            Muestra(miAuto);
            Muestra("-------------------------------------------------------------------");

        }

        static void Muestra(object texto) => Console.WriteLine(texto);
    }
}
