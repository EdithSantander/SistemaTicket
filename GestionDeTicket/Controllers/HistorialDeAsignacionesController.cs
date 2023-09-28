
using GestionDeTicket.Repositorio;
using GestionDeTicket.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using GestionDeTicket.Repositorio.interfaces;


namespace GestionDeTicket.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HistorialDeAsignacionesController : ControllerBase
{


    private readonly ILogger<HistorialDeAsignacionesController> _logger;
    private readonly  IHistorialDeAsignaciones _historalDeAsignacionesRepositorio;
    private readonly TicketAppContext _context;

    public HistorialDeAsignacionesController (IHistorialDeAsignaciones historialDeAsignacionesRepositorio, ILogger<HistorialDeAsignacionesController> logger, TicketAppContext context)
    {
        _historalDeAsignacionesRepositorio = historialDeAsignacionesRepositorio;
        _logger = logger;
        _context = context;
    }

    [HttpGet()]
    public IActionResult ObtenrHistorialDeAsignaciones()
    {
        List<HistorialDeAsignacionesEntidades> historial = _historalDeAsignacionesRepositorio.ListarHistorial();

        return Ok(historial);
       
    }
      [HttpPost()]
    public IActionResult Agregar(HistorialDeAsignacionesEntidades historialDeAsig)
    {
        
          _historalDeAsignacionesRepositorio.AgregarHistorial(historialDeAsig);
          return Ok();
       
    }
}


  