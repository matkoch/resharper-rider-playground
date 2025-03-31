// ReSharper disable ArrangeTypeMemberModifiers

namespace RSRD251;

file class LambdaParameters
{
    static Retriever<string, object> CreateRetriever(
        Dictionary<string, object> dictionary)
    {
        return (string key, out object value)
            => dictionary.TryGetValue(key, out value);
    }

    delegate bool Retriever<in TKey, TValue>(
        TKey key,
        out TValue value);
}
