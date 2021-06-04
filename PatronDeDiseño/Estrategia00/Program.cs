using System;

namespace Estrategia00
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = string.Empty;
            double x = 0;
            double y = 0;
            double r = 0;
            string opcion = string.Empty;

            //Nuestra variable que referencia al algoritmo
            //Instanciamos con un default para permitir compilacion correcta
            IOperacion miOperacion = new CSuma();

            while(opcion != "5")
            {
                Muestra("1 - Suma, 2 - Resta, 3 - Multi, 4 - Div, 5 - Salir");
                opcion = Console.ReadLine();

                if (opcion.Equals("5"))
                    break;

                Muestra("Dame el valor de a");
                dato = Console.ReadLine();
                x = Convert.ToDouble(dato);

                Muestra("Dame el valor de b");
                dato = Console.ReadLine();
                y = Convert.ToDouble(dato);

                //Aqui seleccinamos el algoritmo de acuerdo a la necesidad

                switch (opcion)
                {
                    case "1":
                        miOperacion = new CSuma();
                        break;
                    case "2":
                        miOperacion = new CResta();
                        break;
                    case "3":
                        miOperacion = new CMulti();
                        break;
                    case "4":
                        miOperacion = new CDiv();
                        break;
                }

                r = miOperacion.operacion(x,y);
                Muestra($"El resultado es: {r}");
            }

        }

        static void Muestra(string texto) => Console.WriteLine(texto);
    }
}
