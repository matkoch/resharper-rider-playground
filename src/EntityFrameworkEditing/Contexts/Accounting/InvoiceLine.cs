using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkEditing.Contexts.Accounting;

public class InvoiceLine
{
    [Key] public int Id { get; set; }
    public Product Product { get; set; }
    public decimal Amount { get; set; }
    public List<InvoiceLineComment> Comments { get; set; }
}