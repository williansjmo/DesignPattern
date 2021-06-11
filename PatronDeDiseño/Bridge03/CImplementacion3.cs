using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge03
{
    public class CImplementacion3 : IBridge
    {
        public void ListarProductos(Dictionary<string, double> parameto)
        {
            foreach (KeyValuePair<string, double> p in parameto)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (p.Key[0] == 'C')
                    Console.WriteLine($"{p.Key} - {p.Value}");
            }
            foreach (KeyValuePair<string, double> p in parameto)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (p.Key[0] == 'M')
                    Console.WriteLine($"{p.Key} - {p.Value}");
            }
            foreach (KeyValuePair<string, double> p in parameto)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (p.Key[0] == 'D')
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

            Console.WriteLine($"El total de comida es: {totalc}, {totalc / total * 100} del total");
            Console.WriteLine($"El total de medicamentos es: {totalm}, {totalm / total * 100} del total");
            Console.WriteLine($"El total de deportes es: {totald}, {totald / total * 100} del total");
            Console.WriteLine($"El total de {cantidad} productos es {total}");
        }
    }
}
