using System;

namespace Proxy02
{
    class Program
    {
        static void Main(string[] args)
        {
            CProxy.ISujeto miProxy = new CProxy.ProxySencillo();

            //No podemos acceder a la clase
            //CProxy.CCocina miCocina = new CProxy.CCocina();

            miProxy.Peticion(1);
            Console.WriteLine("--------------------------");
            miProxy.Peticion(2);
            Console.WriteLine("--------------------------");

            CProxy.ISujeto miProxyS = new CProxy.ProxySeguro();

            miProxy.Peticion(1);
            Console.WriteLine("--------------------------");
            miProxy.Peticion(2);
        }
    }
}
