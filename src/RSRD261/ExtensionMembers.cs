namespace RSRD261;

public class ExtensionMembers
{
    void M()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        var (median, min, max) = (
            list.GetMedianElement(),
            list.GetMinElement(),
            list.GetMaxElement());
    }
}

file static class ListExtensions
{
    public static T? GetMedianElement<T>(this List<T> list) =>
        list.Order().ElementAtOrDefault(list.Count / 2);

    extension<T>(List<T> list)
    {
        public T? GetMinElement() => list.Min();
    }

    extension<T>(List<T> list)
    {
        public T? GetMaxElement() => list.Max();
    }
}
