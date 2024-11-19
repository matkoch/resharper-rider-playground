// ReSharper disable UnusedType.Global

namespace RSRD243;

internal class LockObject
{
    private readonly object _syncRoot = new();

    public void M()
    {
        lock (_syncRoot)
        {
            // work
        }
    }
}
