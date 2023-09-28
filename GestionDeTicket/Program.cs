using GestionDeTicket.Repositorio;
using Microsoft.EntityFrameworkCore;
using GestionDeTicket.Repositorio.interfaces;
using Microsoft.Extensions.Options;
using GestionDeTicket.Servicios;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
builder.Services.AddDbContext<TicketAppContext>(Options=> Options.UseNpgsql(builder.Configuration.GetConnectionString("dbGestionDeTicket")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//cors== seguridad
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
//se registran tres tipos de repositorios como servicios, lo cual se instanciará cada solicitud
builder.Services.AddScoped<ITicketRespuesta, TicketRespuestaRepositorio>();
builder.Services.AddScoped<IEmpleadosRepositorio, EmpleadosRepositorio>();
builder.Services.AddScoped<IHistorialDeAsignaciones, HistorialDeAsignacionesRepositorio>();
builder.Services.AddScoped<EmpleadosServicios>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app cors
app.UseHttpsRedirection();

app.UseCors("corsapp");

app.UseAuthorization();

app.MapControllers();

app.Run();
