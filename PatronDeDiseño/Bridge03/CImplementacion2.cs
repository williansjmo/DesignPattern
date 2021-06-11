using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge03
{
    public class CImplementacion2 : IBridge
    {
        public void ListarProductos(Dictionary<string, double> parameto)
        {
            foreach (KeyValuePair<string, double> p in parameto)
            {
                switch (p.Key[0].ToString())
                {
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "M":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }

                Console.WriteLine($"{p.Key} - {p.Value}");
            }
        }

        public void MostrarTotales(Dictionary<string, double> parameto)
        {
            double total = 0;
            double totalm = 0;
            double totalc = 0;
            double totald = 0;
            int cantidad = 0;

            foreach (KeyValuePair<string, double> p in parameto)
            {
                total += p.Value;
                switch (p.Key[0].ToString())
                {
                    case "C":
                        totalc += p.Value;
                        break;
                    case "M":
                        totalm += p.Value;
                        break;
                    case "D":
                        totald += p.Value;
                        break;
                }
                cantidad++;
            }

            Console.WriteLine($"El total de comida es: {totalc}");
            Console.WriteLine($"El total de medicamentos es: {totalm}");
            Console.WriteLine($"El total de deportes es: {totald}");
            Console.WriteLine($"El total de {cantidad} productos es {total}");
        }
    }
}
