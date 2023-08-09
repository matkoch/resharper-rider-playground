using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkEditing.Contexts.Lazy;

public class LazyInvoiceLine
{
    [Key] public int Id { get; set; }
    public virtual LazyProduct Product { get; set; }
    public decimal Amount { get; set; }
    public virtual List<LazyInvoiceLineComment> Comments { get; set; }
}