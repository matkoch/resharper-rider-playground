// ReSharper disable ArrangeTypeMemberModifiers

namespace RSRD251;

file class CancellationTokenUsage
{
    async Task ProcessAllWorkItems(CancellationToken ct1)
    {
        while (!ct1.IsCancellationRequested)
        {
            using var cts1 = new CancellationTokenSource(millisecondsDelay: 3_000);
            await ExecuteWorkItemWithRetry(async (item, ct2) =>
            {
                var processed = await TryProcessWorkItem(item, ct1);
                if (processed)
                    return true;

                await Task.Delay(100, ct2);
                return false;
            }, retryCount: 3);
        }
    }

    private WorkItem GetNextWorkItem() => null!;
    private async Task<bool> TryProcessWorkItem(WorkItem workItem, CancellationToken cancellationToken) => default;

    private async Task ExecuteWorkItemWithRetry(Func<WorkItem, CancellationToken, Task<bool>> action, int retryCount)
    {
    }

    record WorkItem;
}
