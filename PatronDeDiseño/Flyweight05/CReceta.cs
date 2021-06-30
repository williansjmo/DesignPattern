namespace Flyweight05
{
    class CReceta : IFlyweight
    {
        private string nombre;
        private double costo;
        private double venta;

        public void CalculaCosto()
        {
            foreach (char letra in nombre)
            {
                costo += (int)letra;
            }
            venta = costo * 1.30;
        }

        public void ColocaNombre(string Nombre)
        {
            nombre = Nombre;
        }

        public void Mostrar()
        {
            System.Console.WriteLine($"{nombre} cuesta {venta}");
        }

        public string ObtenerNombre() => nombre;
        
    }
}
