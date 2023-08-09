using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkEditing.Contexts.Accounting;

public class InvoiceLineComment
{
    [Key] public int Id { get; set; }
    public string Value { get; set; }
}