public class EspecialistaRH : IObserver<Aplicacion>
{
    private IDisposable cancelacion;
    public string nombre {get; set;}
    public List<Aplicacion> aplicacions {get; set;}

    public EspecialistaRH(string nombre)
    {
        this.nombre = nombre;
        aplicacions = new ();
    } 

    public virtual void Subcribir (AplicacionNotificacion proveedor)
    {
        cancelacion = proveedor.Subcribir(this);
    }

    public virtual Unsubcripcion()
    {
        cancelacion.Dispose();
        aplicacions.Clear();
    }

    public void OnCompleted()
    {
        Console.Writeline($"Hola, {nombre}! no estamos aceptando ninguna aplicación más")
    }

    public void OnError(Exception error)
    {

    }

    public void OnNext (Aplicacion value)
    {
        aplicacions.Add(value);
    }

    public void ListaAplicacion()
    {
        if(aplicacions.Any())
        {
            foreach(var app in aplicacions)
            {
                Console.Writeline($"Hola, {nombre}! {app.NombreAplicacion} acaba de solicitar el trabajo no. {app.IdJob}");
            }
        }else{
            Console.Writeline($"Hola, {nombre}! Aún no hay aplicaciones");
        }    
    }
}