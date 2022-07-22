public abstract class OrdenBase
{
    protected List<Producto> productos = new List<Producto>
    {
        new Producto{nombre = "Telefono",precio = 300},
        new Producto{nombre = "Tablet",precio = 800},
        new Producto{nombre = "PC Gamer",precio = 1800}
    };
    public abstract double CalcularTotalPrecioOrden();
}