using GestionDeTicket.Repositorio;
using GestionDeTicket.Entidades;
using Microsoft.AspNetCore.Mvc;
using GestionDeTicket.Servicios;

namespace GestionDeTicket.Controllers;
[ApiController]
[Route("api/[controller]")]
public class EmpleadosController : ControllerBase
{


    private readonly ILogger<EmpleadosController> _logger;
    private readonly EmpleadosServicios _empleadosServicios;


    public EmpleadosController(EmpleadosServicios empleadosServicios)
    {
        _empleadosServicios = empleadosServicios;

    }

    [HttpGet()]
    public IActionResult ObtenerEmpleados()
    {
        List<Empleado> resultado = _empleadosServicios.ListarEmpleados();
        return Ok(resultado);
    }

    [HttpGet("{correo}")]
    public IActionResult ObtenerEmpleados(string correo)
    {
        Empleado resultado = _empleadosServicios.GetObtener(correo);
        return Ok(resultado);
    }
    
    [HttpPost()]
    public IActionResult AgregarEmpleados(Empleado empleados)
    {
        bool resultado =_empleadosServicios.AgregarEmpleados(empleados);
        return Ok(resultado);

    }
    [HttpPut()]
    public IActionResult ModificarEmpleados(Empleado empleados)
    {
        _empleadosServicios.ActualizarEmpleados(empleados);


        return Ok();

    }
     [HttpDelete("{correoElectronico}")]
    public IActionResult EliminarEmpleado(string correoElectronico)
    {
        _empleadosServicios.EliminarEmpleado(correoElectronico);


        return Ok();

    }
}




