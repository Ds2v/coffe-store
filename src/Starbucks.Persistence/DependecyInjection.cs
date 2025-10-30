using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Starbucks.Persistence;

// En esta clase se crea un componente de tipo una extension 
public static class DependecyInjection
{
    // Se extiende la funcionalidad 
    public static IServiceCollection AddPersistence(
        // Recibe como parametro la extension de "IServiceCollection"
        this IServiceCollection services,
        // Este permite accede a los valores en el "appsettings.json"
        IConfiguration configuration
    )
    {
        // Agregamos la cadena de conexión
        services.AddDbContext<StarbucksDbContext>(opt =>
        {
            // Se accede a la seccion "ConnectionStrings" del appsettings.json
            opt.UseSqlite(configuration.GetConnectionString("SQliteDataBase"));
        });

        return services;
    }

}
