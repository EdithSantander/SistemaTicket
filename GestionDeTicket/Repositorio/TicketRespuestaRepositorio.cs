using GestionDeTicket.Entidades;
using GestionDeTicket.Repositorio.interfaces;

namespace GestionDeTicket.Repositorio;

public class TicketRespuestaRepositorio : ITicketRespuesta
{
    private static List<TicketRespuesta> tickets= new List<TicketRespuesta>();
    public List<TicketRespuesta> ListarTicketRespuesta()
    {
        return tickets;
    }
    public bool AgregarTicketRespuesta(TicketRespuesta ticketRespuesta)
    {
        tickets.Add(ticketRespuesta);
           
        return true;
    }
    public bool EliminarTicketRespuesta (int IdTicketRespuesta)
    {
        return true;
    }
    public bool ActualizarTicketRespuesta(TicketRespuesta ticketRespuesta)
    {
        return true;
    }

    
}
