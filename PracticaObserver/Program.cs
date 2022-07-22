using System;


var  observer1 = new EspecialistaRH ("Marco");
var  observer2 = new EspecialistaRH ("Maria");

var proveedor = new AplicacionNotificacion();

observer1.Subcribir(proveedor);
observer2.Subcribir(proveedor);
proveedor.AddAplicaciones(new(1, "Contador"));
proveedor.AddAplicaciones(new(2, "Cantante"));

observer1.ListaAplicacion();
observer2.ListaAplicacion();

observer2.Unsubcripcion();

Console.Writeline();
Console.Writeline($"{observer2.nombre} se ha eliminado su subscripción");
Console.Writeline();

proveedor.AddAplicaciones(new(3, "Sistemas"));

observer1.ListaAplicacion();
observer2.ListaAplicacion();

Console.Writeline();

proveedor.CerrarAplicacion();