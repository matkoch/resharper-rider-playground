namespace CSharp12;

public class CollectionExpressions
{
    public static void M()
    {
        int[] array = [1, 2, 3];
        int[] array2 = [..array, 42];

        List<int> list = new() { 1, 2, 3 };
        list.Add(42);
        list.AddRange(array2);

        N(new() { 1, 2, 3 });

        int[] array1 = new int[0];
    }

    private static void N(List<int> list)
    {
        foreach (var i in list)
            Console.WriteLine(i);
    }
}
