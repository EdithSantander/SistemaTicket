using GestionDeTicket.Entidades;

namespace GestionDeTicket.Repositorio.interfaces;

public interface ITicketRespuesta
{

     bool AgregarTicketRespuesta(TicketRespuesta ticketRespuesta);
     bool EliminarTicketRespuesta(int IdTicketRespuesta);
     List<TicketRespuesta>ListarTicketRespuesta();
}
