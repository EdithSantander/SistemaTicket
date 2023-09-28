using  GestionDeTicket.Entidades;

namespace GestionDeTicket.Repositorio;

public interface IEmpleadosRepositorio

{
   
     bool AgregarEmpleados(Empleado empleados);
     bool EliminarEmpleados(Empleado empleados);
     bool ActualizarEmpleados(Empleado empleados);
     List<Empleado>ListarEmpleados();
     Empleado Obtener(string correoelectronico);
    
     

}

