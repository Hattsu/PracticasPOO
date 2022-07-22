public class PreOrden : OrdenBase
{
    public override double CalcularTotalPrecioOrden()
    {
        Console.WriteLine("Cálculo del predio total de un pedido anticipado");
        return productos.Sum(x => x.precio)*0.9;
    }
}