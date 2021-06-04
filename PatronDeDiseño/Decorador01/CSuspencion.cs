using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    class CSuspencion : IComponente
    {
        private readonly IComponente pComponente;

        public CSuspencion(IComponente pComponente)
        {
            this.pComponente = pComponente;
        }

        public override string ToString()
        {
            return $"Suspension de alto desempeño\r\n{pComponente.ToString()}";
        }

        public double Costo() => pComponente.Costo() + 63850;

        public string Funciona() => $"{pComponente.Funciona()}, Elevando suspension";
        
    }
}
