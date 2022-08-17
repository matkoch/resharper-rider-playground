namespace CSharp11;

public static class ListPatterns
{
    private static bool IsSorted(int[] numbers)
    {
        return numbers switch
        {
            // Empty list is always sorted
            [] => true,

            // Single items are always sorted
            [_] => true,

            // If first and second of the current range are not sorted => false
            [var first, var second,  ..] when first > second => false,

            // If none of the above conditions are met, proceed with the rest
            [_, .. var rest] => IsSorted(rest),

            // Throw if numbers are null
            _ => throw new ArgumentNullException(nameof(numbers))
        };
    }

    public static void Start()
    {
        new[] { 1, 2, 3, 4, 10 }
            .Dump()
            .DumpIsSorted();

        new[] { 10, 2, 1, 3, 4 }
            .Dump()
            .DumpIsSorted();

        var nestedArray = new[] { new[] { 5 } };
        (nestedArray switch
        {
            [[]] => "nested array with zero elements",
            [ { Length: > 1 }] => "nested array with more than 1 element",
            [[ < 3]] => "nested array with single element lower than 3",
            _ => "default"
        }).Dump();
    }

    private static void DumpIsSorted(this int[] array)
    {
        Console.WriteLine($"... it's {(IsSorted(array) ? "sorted" : "not sorted")}");
    }
}
