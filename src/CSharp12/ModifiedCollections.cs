namespace CodeAnalysis;

public class ModifiedCollections
{
    public static void M(List<int> list)
    {
        foreach (var i in list)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                list.Add(1337);

            // some safe work
        }
    }
}
