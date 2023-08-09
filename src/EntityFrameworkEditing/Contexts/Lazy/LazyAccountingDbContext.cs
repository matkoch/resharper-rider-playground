using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkEditing.Contexts.Lazy;

public class LazyAccountingDbContext : DbContext
{
    public DbSet<LazyInvoice> Invoices { get; set; }
    public DbSet<LazyInvoiceLine> InvoiceLines { get; set; }
    public DbSet<LazyInvoiceLineComment> InvoiceLineComments { get; set; }
    public DbSet<LazyProduct> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }
}