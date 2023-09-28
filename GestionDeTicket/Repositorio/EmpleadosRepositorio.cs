using GestionDeTicket.Entidades;

namespace GestionDeTicket.Repositorio;


public class EmpleadosRepositorio : IEmpleadosRepositorio
{
    private TicketAppContext _ticketAppContext;
    
    public EmpleadosRepositorio(TicketAppContext ticketAppContext)
    {
        _ticketAppContext = ticketAppContext;
    }

    public List<Empleado> ListarEmpleados()
    {
        return _ticketAppContext.Empleados.ToList();
    }
    public bool AgregarEmpleados(Empleado empleado)
    {
        empleado.IdEmpleados=empleado.GetHashCode();
        _ticketAppContext.Add(empleado);
        _ticketAppContext.SaveChanges();
        
        return true;
    }
    public bool EliminarEmpleados(Empleado empleado)
    {
        return true;
    }

     public Empleado Obtener(string Correoelectronico)
     {
       return  _ticketAppContext.Empleados.Where(C => C.CorreoElectronico == Correoelectronico).First();
     }

     public bool ActualizarEmpleados(Empleado empleado)
     {
        // Buscar empleado en la base de datos
        Empleado empleadoDB = _ticketAppContext.Empleados.Where( c => c.CorreoElectronico == empleado.CorreoElectronico ).First();

        empleadoDB.Apellido = empleado.Apellido;
        empleadoDB.Nombre = empleado.Nombre;

        _ticketAppContext.Update(empleadoDB);
        _ticketAppContext.SaveChanges();

        return true;
     }


}

