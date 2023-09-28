namespace GestionDeTicket.Entidades;

public class HistorialDeAsignacionesEntidades

{
    public int IdHistorialAsignaciones{get; set;}
    public  Empleado Empleados{get; set;}
    public  TicketRespuesta TicketRespuesta{get; set;}
    public DateTime FechaDeAsignacion{get; set;}
    public DateTime HoraDeAsignacion{get; set;}
    public string ObservacionDeAsignacion{get;set;}

}
