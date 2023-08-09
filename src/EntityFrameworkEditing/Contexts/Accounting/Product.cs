using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkEditing.Contexts.Accounting;

public class Product
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}