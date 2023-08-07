using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkEditing.Contexts.Accounting;

public class Invoice
{
    [Key] public int Id { get; set; }
    public List<InvoiceLine> InvoiceLines { get; set; }
}