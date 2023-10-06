using System.Collections;
using System.Collections.Generic;
using GestionDeTicket.Entidades;
using GestionDeTicket.Repositorio;

namespace GestionDeTicket.Servicios;

public class EmpleadosServicios
{
     private readonly IEmpleadosRepositorio _empleadosRepositorio;
  
    public EmpleadosServicios (IEmpleadosRepositorio empleadosRepositorio)
    {
        _empleadosRepositorio = empleadosRepositorio;
    
    }
    public bool AgregarEmpleados(Empleado empleado)
    {
        Empleado empleadoVerificacion = GetObtener(empleado.CorreoElectronico);
        if(empleadoVerificacion ==null)
        {
            return _empleadosRepositorio.AgregarEmpleados( empleado);
        }
        
        return false;
    }
     public bool ActualizarEmpleados(Empleado empleado)
    {
        Empleado empleadoVerificacion = GetObtener(empleado.CorreoElectronico);
        if(empleadoVerificacion != null)
        {
            return _empleadosRepositorio.ActualizarEmpleados(empleado);
        }
        return false;
    }
     public bool EliminarEmpleado(string correoElectronico)
    {
        return _empleadosRepositorio.EliminarEmpleado(correoElectronico);

    }
     public List<Empleado> ListarEmpleados( )
    {
        return _empleadosRepositorio.ListarEmpleados();

    }
    public Empleado GetObtener(string correoElectronico)
    {
        try
        {
            return _empleadosRepositorio.Obtener(correoElectronico);
        }
        catch (Exception ex)
        {
            return null;
        }
    }
   
    
}
