namespace Starbucks.Domain;

public class CoffeIngredient
{
    public Guid CoffeId { get; set; }
    public Guid IngredientId { get; set; }

    // Existencia de definiciones necesarias en la persistencia (DbContext)
    public Ingredient? Ingredient { get; set; }
    public Coffe? Coffe { get; set; }

    
    
}
