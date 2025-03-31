using Microsoft.Extensions.Logging;

// ReSharper disable ArrangeTypeMemberModifiers

namespace RSRD251;

file class DuplicatedStatements(ILogger logger)
{
    void ProcessOrder(Order order)
    {
        var discount = GetDiscount(order.Customer);
        if (discount > 0)
        {
            ApplyDiscount(order, discount);
            SendEmail(order);
            QueuePaymentProcessing(order);
            return;
        }

        SendEmail(order);
        QueuePaymentProcessing(order);
    }

    private decimal GetDiscount(Customer customer)
        => ClassifyCustomer(customer) switch
        {
            CustomerType.VIP => 0.1m,
            CustomerType.Employee => 0.05m,
            CustomerType.New => 0.01m,
            CustomerType.Regular => 0m,
            CustomerType.Guest => 0m,
            _ => 0m
        };

    void ApplyDiscount(Order order, decimal discount)
    {
        if (IsBlackFridayActive())
            discount += 0.3m;
        else if (IsHolidayActive())
            discount += 0.3m;

        logger.LogDebug("{Order} gets {Discount} discount",
            order, discount);
    }

    bool IsBlackFridayActive() => false;
    bool IsHolidayActive() => false;
    decimal GetGetGlobalBonus() => 0.1m;

    void SendEmail(Order order)
    {
    }

    void QueuePaymentProcessing(Order order)
    {
    }

    CustomerType ClassifyCustomer(Customer customer) => default;

    record Order(Customer Customer);

    record Customer;

    enum CustomerType
    {
        VIP,
        Employee,
        New,
        Regular,
        Guest
    }
}
