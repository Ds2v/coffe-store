using Microsoft.EntityFrameworkCore;

namespace Starbucks.Domain;

public class StarbucksDbContext : DbContext
{
    // Se crean los modelos
    public required DbSet<Category> Categories { get; set; }
    public required DbSet<Coffe> Coffes { get; set; }
    public required DbSet<Ingredient> Ingredients { get; set; }

}
