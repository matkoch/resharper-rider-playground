using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkEditing.Contexts.Lazy;

public class LazyProduct
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}