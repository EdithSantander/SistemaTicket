using GestionDeTicket.Entidades;

namespace GestionDeTicket.Repositorio.interfaces;

public interface IHistorialDeAsignaciones
{

     bool AgregarHistorial(HistorialDeAsignacionesEntidades historialDeAsignacionesEntidades);
     bool EliminarHistorial(HistorialDeAsignacionesEntidades historialDeAsignacionesEntidades);
     List<HistorialDeAsignacionesEntidades> ListarHistorial();
}
