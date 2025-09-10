using System;
using System.Collections.Generic;
using System.IO;
using espacioCadetes;
using espacioClientes;

public class AccesoADatosCSV : IAccesoADatos
{
    private string rutaCadetes;
    private string rutaClientes;

    public AccesoADatosCSV(string rutaCadetes, string rutaClientes)
    {
        this.rutaCadetes = rutaCadetes;
        this.rutaClientes = rutaClientes;
    }

    public List<Cadete> CargarCadetes()
    {
        var listado = new List<Cadete>();
        var lineas = File.ReadAllLines(rutaCadetes);

        for (int i = 1; i < lineas.Length; i++)
        {
            var datos = lineas[i].Split(',');
            int id = int.Parse(datos[0]);
            listado.Add(new Cadete(id, datos[1], datos[2], datos[3]));
        }

        return listado;
    }

    public List<Cliente> CargarClientes()
    {
        var listado = new List<Cliente>();
        var lineas = File.ReadAllLines(rutaClientes);

        for (int i = 1; i < lineas.Length; i++)
        {
            var datos = lineas[i].Split(',');
            int id = int.Parse(datos[0]);
            listado.Add(new Cliente(id, datos[1], datos[2], datos[3]));
        }

        return listado;
    }
}
