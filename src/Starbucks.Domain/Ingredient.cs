namespace Starbucks.Domain;

public class Ingredient : BaseEntity
{
    public required string Name { get; set; }

    // Colección de Coffes necesaria en la persistencia (DbContext)
    public ICollection<Coffe> Coffes { get; set; } = [];
    
    // Colección de CoffeIngredient necesaria en la persistencia (DbContext)
    public ICollection<CoffeIngredient> CoffeIngredients { get; set; } = [];
}
