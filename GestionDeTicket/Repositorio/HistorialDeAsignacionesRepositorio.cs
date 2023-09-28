using GestionDeTicket.Entidades;
using GestionDeTicket.Repositorio.interfaces;

namespace GestionDeTicket.Repositorio;

public class HistorialDeAsignacionesRepositorio : IHistorialDeAsignaciones

{
    private static List<HistorialDeAsignacionesEntidades> historialDeAsig= new List<HistorialDeAsignacionesEntidades>();


    public List<HistorialDeAsignacionesEntidades> ListarHistorial()
    {  
      return historialDeAsig;
    }   
public bool AgregarHistorial(HistorialDeAsignacionesEntidades historialDeAsignacionesEntidades)
{
    historialDeAsig.Add(historialDeAsignacionesEntidades);
    return true;
}
public bool EliminarHistorial(HistorialDeAsignacionesEntidades historialDeAsignacionesEntidades)
{
    return true;
}
public bool ActualizarHistorial(HistorialDeAsignacionesEntidades historialDeAsignacionesEntidades)
{
    return true;
}

    public bool ListarHistorial(HistorialDeAsignacionesEntidades historialDeAsignacionesEntidades)
    {
        throw new NotImplementedException();
    }
}
