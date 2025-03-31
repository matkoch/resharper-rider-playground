// ReSharper disable UseCollectionExpression

// ReSharper disable CollectionNeverUpdated.Local

namespace RSRD251;

file class TupleNames
{
    private readonly Dictionary<string, (DateTimeOffset Timestamp, bool IsValid)> _cache = new();

    public DateTimeOffset GetNextTimestamp(string tag)
    {
        return _cache.TryGetValue(tag, out var value)
            ? value.Item1
            : throw new InvalidOperationException();
    }
}
