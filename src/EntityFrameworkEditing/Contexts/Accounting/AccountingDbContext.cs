using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkEditing.Contexts.Accounting;

public class AccountingDbContext : DbContext
{
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceLine> InvoiceLines { get; set; }
    public DbSet<InvoiceLineComment> InvoiceLineComments { get; set; }
    public DbSet<Product> Products { get; set; }
}