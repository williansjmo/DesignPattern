using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    class CAuto : IComponente
    {
        private readonly string pModelo;
        private readonly string pCarct;
        private readonly double pCosto;

        public CAuto(string pModelo,string pCarct, double pCosto)
        {
            this.pModelo = pModelo;
            this.pCarct = pCarct;
            this.pCosto = pCosto;
        }

        public void Puertas(bool pEstado)
        {
            if (pEstado)
                Console.WriteLine("Puertas Cerradas");
            else
                Console.WriteLine("Puertas Cerradas");
        }

        public override string ToString() => $"Modelo {pModelo}, {pCarct}";


        #region Estos son los metodos implementados de IComponente

        public double Costo() => this.pCosto;

        public string Funciona() => "Encendi el motor";
        
        #endregion
    }
}
