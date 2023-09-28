namespace GestionDeTicket.Entidades;

public class TicketRespuesta
{
    public int IdTicketRespuesta { get; set; }
    public int NroTicketReclamo { get; set; }
    public  Empleado Empleados { get; set; }
    public DateTime FechaRespuesta { get; set; }
    public DateTime HoraRespuesta { get; set; }
    public string ObservacionDeRespuesta { get; set; }
}
