var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

// Este builder documenta los endpoints,No se va a utilizar por que vamos a utilizar el Starbucks.Api.http
//builder.Services.AddOpenApi();

var app = builder.Build();


/*
*
    Estas lineas de codigo pueden ser eliminadas ya que no estamos 
    utilizando AddOpenApi


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

*/


// Solo se esta usando el protocolo Http
//app.UseHttpsRedirection();


// Para crear modelo de seguridad
//app.UseAuthorization();

app.MapControllers();

app.Run();
