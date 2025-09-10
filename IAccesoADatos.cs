using System.Collections.Generic;
using espacioCadetes;
using espacioClientes;

public interface IAccesoADatos
{
    List<Cadete> CargarCadetes();
    List<Cliente> CargarClientes();
}
