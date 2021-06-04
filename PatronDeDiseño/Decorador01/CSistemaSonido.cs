using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    class CSistemaSonido : IComponente
    {
        private readonly IComponente pComponente;

        public CSistemaSonido(IComponente pComponente)
        {
            this.pComponente = pComponente;
        }

        public override string ToString() => $"Radio 350XZ\r\n{pComponente.ToString()}";

        public double Costo() => pComponente.Costo() + 3500;

        public string Funciona() => $"{pComponente.Funciona()}, Encendido el radio";
    }
}
