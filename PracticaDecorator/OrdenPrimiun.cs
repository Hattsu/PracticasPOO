public class OrdenPrimium : Decorador
{
    public OrdenPrimium(OrdenBase orden) : base(orden){ }

    public override double CalcularTotalPrecioOrden()
    {
        Console.WriteLine("Calculo del precio total en la clase{nameof(OrdenPrimium)}");
        var preordenprecio = base.CalcularTotalPrecioOrden();
        Console.WriteLine("Adicion de un descuento adicional al precio anticipado");
        return preordenprecio*0.9;

    }
}