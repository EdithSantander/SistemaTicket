using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDeTicket.Entidades;

public class Empleado
{
    [Key]
    [Column("idempleados")]
    public int IdEmpleados{get; set;}

    [Column("apellido")]
    public string Apellido{get; set;}
    [Column("nombre")]
    public string Nombre{get; set;}
    [Column("correoelectronico")]
    public string CorreoElectronico{get; set;}
}
