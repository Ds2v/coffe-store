using System.Diagnostics.CodeAnalysis;


namespace Starbucks.Domain;

// No hereda de BaseEntity por que se va crear una clave primaria tipo INT,
public class Category
{
    // Constructor con anotacion para que acepte valores de tipo "required"
    [SetsRequiredMembers]
    private Category(int id, string name) => (Id, Name) = (id, name);

    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    // Colección de Coffes necesaria en la persistencia (DbContext)
    public ICollection<Coffe> Coffes { get; set; } = []; 

    // Metodo que se llama desde la persistencia y que recibe 1 parametro
    public static Category Create(int id)
    {
        // De esta forma devuelve el texto que representa al elemento del Enum
        var categoryEnumName = (CategoryEnum)id;
        string categoryEnumNameString = categoryEnumName.ToString();
        // Se crea la instancia
        return new Category(id, categoryEnumNameString);

    }
}
