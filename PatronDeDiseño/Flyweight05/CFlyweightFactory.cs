using System.Collections.Generic;

namespace Flyweight05
{
    class CFlyweightFactory 
    {
        private List<IFlyweight> flyweights = new List<IFlyweight>();
        private int conteo = 0;

        public int Conteo { get => conteo; set => conteo = value; }

        public int Adiciona(string Nombre)
        {
            bool existe = false;
            foreach (IFlyweight f in flyweights)
            {
                if (f.ObtenerNombre() == Nombre)
                    existe = true;
            }

            if (existe)
            {
                System.Console.WriteLine("El objeto ya existe, no se ha adicionado");
                return -1;
            }
            else
            {
                CReceta miReceta = new CReceta();
                miReceta.ColocaNombre(Nombre);
                flyweights.Add(miReceta);
                conteo = flyweights.Count;
                return conteo - 1;
            }
        }

        public IFlyweight this[int index]
        {
            get => flyweights[index];
        }
    }
}
