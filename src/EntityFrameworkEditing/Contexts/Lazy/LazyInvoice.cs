using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkEditing.Contexts.Lazy;

public class LazyInvoice
{
    [Key] public int Id { get; set; }
    public virtual List<LazyInvoiceLine> InvoiceLines { get; set; }
}