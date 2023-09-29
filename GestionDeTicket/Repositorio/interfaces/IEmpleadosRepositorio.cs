using  GestionDeTicket.Entidades;

namespace GestionDeTicket.Repositorio;

public interface IEmpleadosRepositorio

{
   
     bool AgregarEmpleados(Empleado empleados);
     bool EliminarEmpleado(string correoElectronico);
     bool ActualizarEmpleados(Empleado empleados);
     List<Empleado>ListarEmpleados();
     Empleado Obtener(string correoelectronico);
    
     

}

