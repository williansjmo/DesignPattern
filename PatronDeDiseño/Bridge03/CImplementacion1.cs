using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge03
{
    public class CImplementacion1 : IBridge
    {
        public void ListarProductos(Dictionary<string, double> parameto)
        {
            foreach (KeyValuePair<string, double> p in parameto)
            {
                Console.WriteLine(p.Key);
            }
        }

        public void MostrarTotales(Dictionary<string, double> parameto)
        {
            double total = 0;
            int cantidad = 0;

            foreach (KeyValuePair<string, double> p in parameto)
            {
                total += p.Value;
                cantidad++;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"El total de {cantidad} productos es {total}");
        }
    }
}
