using Microsoft.EntityFrameworkCore;
using Starbucks.Domain;

namespace Starbucks.Persistence;

public class StarbucksDbContext : DbContext
{
    /*
    * Se crean los modelos que van a ser equivalentes 
    * a la tabla de la BD
    */
    public required DbSet<Category> Categories { get; set; }
    public required DbSet<Coffe> Coffes { get; set; }
    public required DbSet<Ingredient> Ingredients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Creacion relacion 1 a muchos entre el modelo Category-Coffe
        modelBuilder.Entity<Category>()
        .HasMany(c => c.Coffes)
        .WithOne(co => co.Category)
        .HasForeignKey(co => co.CategoryId)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

        // Modificacion de las propiedades de la entidad Coffe
        modelBuilder.Entity<Coffe>()
        .Property(co => co.Price)
        .HasPrecision(10, 2);

        // Creacion relacion muchos a muchos entre el modelo Coffe-Ingredient
        modelBuilder.Entity<Coffe>()
        .HasMany(ingd => ingd.Ingredients)
        .WithMany(ingd => ingd.Coffes)
        // Se referencia a la tabla asociativa y se configura
        .UsingEntity<CoffeIngredient>(
            i => i
            .HasOne(p => p.Ingredient)
            .WithMany(p => p.CoffeIngredients)
            .HasForeignKey(p => p.IngredientId),
            i => i
            .HasOne(p => p.Coffe)
            .WithMany(p => p.CoffeIngredients)
            .HasForeignKey(p => p.CoffeId),
        // Se configura el PrimaryKey Compuesto
            j =>
            {
                j.HasKey(k => new { k.CoffeId, k.IngredientId });
            }
        );   
    }
}
