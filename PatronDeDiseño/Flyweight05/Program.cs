using System;
using System.Collections.Generic;

namespace Flyweight05
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();
            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();
            List<int> Rapida = new List<int>();

            CFlyweightFactory cFlyweight = new CFlyweightFactory();
            i = cFlyweight.Adiciona("Hamburguesa");
            Americana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = cFlyweight.Adiciona("Wisconsi sheese");
            Americana.Add(i);
            Ensaladas.Add(i);

            i = cFlyweight.Adiciona("Minestrones");
            Italiana.Add(i);
            Sopas.Add(i);

            i = cFlyweight.Adiciona("Antipasto");
            Italiana.Add(i);
            Ensaladas.Add(i);

            i = cFlyweight.Adiciona("Tacos al pastor");
            Mexicana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = cFlyweight.Adiciona("Coditos");
            Mexicana.Add(i);
            Sopas.Add(i);

            i = cFlyweight.Adiciona("Nopales");
            Mexicana.Add(i);
            Ensaladas.Add(i);

            i = cFlyweight.Adiciona("Pizza");
            Italiana.Add(i);
            Rapida.Add(i);

            foreach (int n in Americana)
            {
                CReceta receta = (CReceta)cFlyweight[n];
                receta.CalculaCosto();
                receta.Mostrar();
            }
        }
    }
}
