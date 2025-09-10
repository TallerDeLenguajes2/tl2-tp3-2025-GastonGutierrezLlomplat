using System;
using System.Collections.Generic;
using espacioCadeteria;
using espacioCadetes;
using espacioClientes;
using espacioPedidos;


Cadeteria Comotti = new Cadeteria("Comotti", 4201376);

Console.Write("Seleccione fuente de datos (1=CSV, 2=JSON): ");
string opcion = Console.ReadLine();

IAccesoADatos acceso;
if (opcion == "1") // CSV
{
    acceso = new AccesoADatosCSV("cadetes.csv", "clientes.csv");
}
else // JSON
{
    acceso = new AccesoADatosJSON("cadetes.json", "clientes.json");
}


Comotti.ListadoCadetes.AddRange(acceso.CargarCadetes());
Comotti.ListadoClientes.AddRange(acceso.CargarClientes());


List<string> informe = Comotti.InformeFinal(); // devuelve la lista de strings

foreach (var linea in informe)
{
    Console.WriteLine(linea);
}
