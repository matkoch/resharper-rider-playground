using EntityFrameworkEditing.Contexts.Lazy;

namespace EntityFrameworkEditing;

public class EfCoreNPlusOne
{
    public void Example()
    {
        using var db = new LazyAccountingDbContext();

        // Navigation: properties causing N+1
        // QF: Load required relations
        var invoices = db.Invoices
            .ToList();

        foreach (var invoice in invoices)
        {
            // QF: Load required relations
            foreach (var invoiceLine in invoice.InvoiceLines)
            {
                // QF: Load required relations
                var product = invoiceLine.Product;

                Console.WriteLine(product.Name + " - " + product.Price * invoiceLine.Amount);

                // QF: Load required relations
                foreach (var invoiceLineComment in invoiceLine.Comments)
                {
                    Console.WriteLine("  - " + invoiceLineComment.Value);
                }
            }
        }
    }
}