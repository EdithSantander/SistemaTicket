using GestionDeTicket.Repositorio;
using GestionDeTicket.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using GestionDeTicket.Repositorio.interfaces;

namespace GestionDeTicket.Controllers;
[ApiController]
[Route("[controller]")]
public class TicketRespuestaController : ControllerBase
{

    private readonly ILogger<TicketRespuestaController> _logger;
    private readonly  ITicketRespuesta  _ticketRespuestaRepositorio;
    private readonly TicketAppContext _context;
    


    public TicketRespuestaController (ITicketRespuesta ticketRespuestaRepositorio, ILogger<TicketRespuestaController> logger,  TicketAppContext context)
    {
        _ticketRespuestaRepositorio = ticketRespuestaRepositorio;
        _logger = logger;
        _context = context;
    }

    [HttpGet()]
    public IActionResult ObtenerTicketRespuesta()
    {
       List<TicketRespuesta> Ticket =  _ticketRespuestaRepositorio.ListarTicketRespuesta();

        return  Ok(Ticket);
       
    }
      [HttpPost()]
    public IActionResult Agregar(TicketRespuesta ticketRespuesta)
    {
         if (ticketRespuesta.IdTicketRespuesta <= 0)
        {
            return BadRequest();
        }
          _ticketRespuestaRepositorio.AgregarTicketRespuesta(ticketRespuesta);
          return Ok() ;
       
    }
}
