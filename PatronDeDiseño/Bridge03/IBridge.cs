﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge03
{
    // Esta es la interface que las implementaciones deben de mostrar
    public interface IBridge
    {
        void MostrarTotales(Dictionary<string, double> parameto);
        void ListarProductos(Dictionary<string, double> parameto);
    }
}
