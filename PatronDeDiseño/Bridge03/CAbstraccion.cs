using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge03
{
    // Esta clase conecta al cliente con la abstraccion a utilizar
    public class CAbstraccion
    {
        // Referencia a la implementacion
        IBridge implementacion;
        Dictionary<string, double> productos;

        // Metodo 1, es mas usual
        // Constructor, recibimos la implementacion concreta
        public CAbstraccion(IBridge Imp, Dictionary<string, double> Prod)
        {
            implementacion = Imp;
            productos = Prod;
        }

        // Metodo 2, cuidado no deseamos hacer una fabrica
        public CAbstraccion(int Tipo, Dictionary<string, double> Prod)
        {
            switch (Tipo)
            {
                case 1:
                    implementacion = new CImplementacion1();
                    break;
                case 2:
                    implementacion = new CImplementacion2();
                    break;
                case 3:
                    implementacion = new CImplementacion3();
                    break;
            }

            productos = Prod;
        }

        // Estos metodo representan la interfaz que conoce el cliente
        public void MostrarTotales()
        {
            implementacion.MostrarTotales(productos);
        }

        public void ListarProductos()
        {
            implementacion.ListarProductos(productos);
        }
    }
}
