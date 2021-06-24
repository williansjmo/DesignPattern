using System;

namespace Composite04
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente<string> arbol = new Compuesto<string>("root");
            IComponente<string> trabajo = arbol;

            string opcion = "";
            string dato = "";

            while (opcion != "6")
            {
                Console.WriteLine($"Estoy en {trabajo.Nombre}");
                Console.WriteLine("1 - Adicionar, 2 - Adicionar Componente, 3 - Borrar, 4 - Buscar, 5- Mostrar, 6 - Salir");
                opcion = Console.ReadLine();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Dame el nombre del compuesto: ");
                        dato = Console.ReadLine();
                        IComponente<string> c = new Compuesto<string>(dato);
                        trabajo.Adicionar(c);
                        trabajo = c;
                        break;

                    case "2":
                        Console.WriteLine("Dame el nombre del componente: ");
                        dato = Console.ReadLine();
                        trabajo.Adicionar(new Componente<string>(dato));
                        break;

                    case "3":
                        Console.WriteLine("Dame el elemento a borrar: ");
                        dato = Console.ReadLine();
                        trabajo = trabajo.Borrar(dato);
                        break;

                    case "4":
                        Console.WriteLine("Dame el elemento a encontrar: ");
                        dato = Console.ReadLine();
                        trabajo = arbol.Buscar(dato);
                        break;
                    case "5":
                        Console.WriteLine(arbol.Mostrar(0));
                        break;
                    
                }
            }
        }
    }
}
