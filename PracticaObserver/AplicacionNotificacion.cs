public class AplicacionNotificacion
{
    private readonly List<IObserver<Aplicacion>> observers;
    public List<Aplicacion> aplicacions {get; set;}
    
    public AplicacionNotificacion()
    {
        observers = new();
        aplicacions = new();
    }

    public IDisposable Subcribir(IObserver<Aplicacion> observers)
    {
        if( !observers.Contains(observers))
        {
            observers.Add(observers);

            foreach (var item in aplicacions)
            {
            observers.OnNext(item);
            }
        }
        return new unsubcripion (observers, observer);
    }

    public void AddAplicaciones (Aplicacion.app)
    {
        aplicacions.Add(app);
        foreach (var observer in observer)
        {
            observer
        }
    }

    public void CerrarAplicacion()
    {
        foreach (var observer in observers)
        {
            observer.OnCompleted();
        }
        observers.Clear();
    }
}