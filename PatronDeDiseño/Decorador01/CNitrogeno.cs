using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    class CNitrogeno : IComponente
    {
        // Variabble de referencia hacia quien decoramos
        private readonly IComponente pComponente;

        // Pasamos al objecto que va a ser decorado
        public CNitrogeno(IComponente pComponente)
        {
            this.pComponente = pComponente;
        }

        public override string ToString() => $"Sistema de Nitrogeno\r\n{pComponente.ToString()}";
        public double Costo() => pComponente.Costo() + 45000;
        public string Funciona() => $"{pComponente.Funciona()}, Nitrogeno listo";

        public void USaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
    }
}
