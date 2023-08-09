using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkEditing.Contexts.Lazy;

public class LazyInvoiceLineComment
{
    [Key] public int Id { get; set; }
    public string Value { get; set; }
}