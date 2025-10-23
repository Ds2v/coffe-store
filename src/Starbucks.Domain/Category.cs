namespace Starbucks.Domain;

// No hereda de BaseEntity por que se va crear una clave primaria tipo INT,
public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    // Colección de Coffes necesaria en la persistencia (DbContext)
    public ICollection<Coffe> Coffes { get; set; } = []; 
}
