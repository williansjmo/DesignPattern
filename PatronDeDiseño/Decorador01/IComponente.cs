using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    // Usaremos esta interfase para la decoracion
    interface IComponente
    {
        double Costo();
        string Funciona();
    }
}
