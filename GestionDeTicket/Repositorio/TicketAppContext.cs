using GestionDeTicket.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
namespace GestionDeTicket.Repositorio;

public class TicketAppContext : DbContext

{
    //propiedades del context para conexion de base de datos
    public TicketAppContext(DbContextOptions<TicketAppContext> options) : base(options)
    {

    }
    public DbSet<Empleado> Empleados { get; set; }
    //public DbSet<HistorialDeAsignacionesEntidades> HistorialDeAsignacionesEntidades { get; set; }
    //public DbSet<TicketRespuesta> TicketRespuestas { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>().ToTable("empleados");
        //modelBuilder.Entity<HistorialDeAsignacionesEntidades>().ToTable("historialdeasignaciones");
       // modelBuilder.Entity<TicketRespuesta>().ToTable("ticketrespuesta");
    }
}


