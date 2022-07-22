using System;
namespace PracticasDecorator
{
    class Program
    {
        public static void Main(String[] args)
        {
            var regularOrden = new OrdenRegular();
            Console.WriteLine(regularOrden.CalcularTotalPrecioOrden());
            Console.WriteLine();

            var preorden = new PreOrden();
            Console.WriteLine(preorden.CalcularTotalPrecioOrden());
            Console.WriteLine();

            var ordenPrimium = new OrdenPrimium(preorden);
            Console.WriteLine(ordenPrimium.CalcularTotalPrecioOrden());
            Console.WriteLine();

        }
    }
}