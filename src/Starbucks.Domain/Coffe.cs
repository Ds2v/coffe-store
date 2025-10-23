namespace Starbucks.Domain;

public class Coffe : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? Imagen { get; set; }
    public int CategoryId { get; set; }
    
    // Existencia de definiciones necesarias en la persistencia (DbContext)
    public Category? Category { get; set; }

    // Colección de Ingredients necesaria en la persistencia (DbContext)
    public ICollection<Ingredient> Ingredients { get; set; } = [];
    public ICollection<CoffeIngredient> CoffeIngredients { get; set; } = [];
}
