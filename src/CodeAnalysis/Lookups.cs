namespace CodeAnalysis;

public class Lookups
{
    private static readonly Dictionary<int, object> items = new();

    public static void M(int key, object value)
    {
        // QF: remove redundant lookup
        if (items.ContainsKey(key))
            items[key] = value;
        else
            items.Add(key, value);

        // QF: simplify with TryAdd
        if (!items.ContainsKey(key)) items.Add(key, value);
        if (!items.ContainsKey(key)) items[key] = value;
    }
}
