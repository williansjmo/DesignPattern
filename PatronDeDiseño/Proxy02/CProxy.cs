using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy02
{
    /// <summary>
    /// Haremos uso de anidamiento adentro de la clase
    /// Esto hace que cualquier clase colocada como privada y anidada
    /// solo sea conocida por CProxy
    /// </summary>
    public class CProxy
    {
        public interface ISujeto
        {
            void Peticion(int pOpcion);
        }

        public class ProxySencillo : ISujeto
        {
            private CCocina cocina;

            public void Peticion(int pOpcion)
            {
                if (cocina == null)
                {
                    Console.WriteLine("Activando el sujeto");
                    cocina = new CCocina();
                }

                switch (pOpcion)
                {
                    case 1:
                        cocina.RecetaSecreta();
                        break;
                    case 2:
                        cocina.Cocinar(5);
                        break;
                }
            }
        }

        public class ProxySeguro : ISujeto
        {
            private CCocina cocina;

            public void Peticion(int pOpcion)
            {
                string password;

                Console.WriteLine($"Dame el {nameof(password)}");
                password = Console.ReadLine();

                if (password == "abc123")
                {
                    if (cocina == null)
                    {
                        Console.WriteLine("Activando el sujeto");
                        cocina = new CCocina();
                    }

                    switch (pOpcion)
                    {
                        case 1:
                            cocina.RecetaSecreta();
                            break;
                        case 2:
                            cocina.Cocinar(5);
                            break;
                    }
                }
                else
                    Console.WriteLine("Acceso denegado");
            }
        }

        // Esta es la clase que estamos protegiendo con el proxy
        private class CCocina
        {
            public void RecetaSecreta()
            {
                Console.WriteLine("Pan");
                Console.WriteLine("Aceite de oliva");
                Console.WriteLine("Especias");
                Console.WriteLine("Jamon");
                Console.WriteLine("Queso");
            }

            public void Cocinar(int n)
            {
                Console.WriteLine($"Cocinando {n} recetas");
            }
        }
    }
}
