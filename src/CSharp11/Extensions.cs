namespace CSharp11;

public static class Extensions
{
    public static T Dump<T>(this T obj)
    {
        var x = "";
        Console.WriteLine(obj!.ToString());
        return obj;
    }

    public static T[] Dump<T>(this IEnumerable<T> enumerable)
    {
        return enumerable.ToArray().Dump();
    }

    public static T[] Dump<T>(this T[] array)
    {
        Console.WriteLine(array.Select(x => x!.ToString())!.JoinComma());
        return array;
    }

    public static string JoinComma(this IEnumerable<string> values)
    {
        return string.Join(", ", values);
    }
}
