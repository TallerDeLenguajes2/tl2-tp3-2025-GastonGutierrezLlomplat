using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using espacioCadetes;
using espacioClientes;

public class AccesoADatosJSON : IAccesoADatos
{
    private string rutaCadetes;
    private string rutaClientes;

    public AccesoADatosJSON(string rutaCadetes, string rutaClientes)
    {
        this.rutaCadetes = rutaCadetes;
        this.rutaClientes = rutaClientes;
    }

    public List<Cadete> CargarCadetes()
    {
        string json = File.ReadAllText(rutaCadetes);
        return JsonSerializer.Deserialize<List<Cadete>>(json);
    }

    public List<Cliente> CargarClientes()
    {
        string json = File.ReadAllText(rutaClientes);
        return JsonSerializer.Deserialize<List<Cliente>>(json);
    }
}
