using System.Collections.Immutable;
using System.Runtime.CompilerServices;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedVariable

namespace CSharp12;

public class CollectionExpressions
{
    // This piece of code is deep embedded in the business logic
    public static void M()
    {
        int[] array = [1, 2, 3];
        int[] array2 = [1, ..array, 42, ..Enumerable.Range(0, 10), 101];

        A(new[] { 1, 2, 3 }); // takes arrays
        L(new List<int> { 1, 2, 3 }); // takes lists
        H(new HashSet<int> { 1, 2, 3 }); // takes hashsets
        IA(ImmutableArray.Create(1, 2, 3)); // takes immutable arrays

        IA(ImmutableArray.CreateRange(array));
        IA(array.ToImmutableArray());

        A(new int[0]);
        L(new List<int>());
        A(Array.Empty<int>());
        // E(Enumerable.Empty<int>());
    }

    private static void Formatting()
    {
        // @formatter:initializer_braces end_of_line // end_of_line_no_space | next_line_shifted_2 | pico
        // @formatter:space_within_list_pattern_brackets true
        // @formatter:place_simple_list_pattern_on_single_line true
        // @formatter:keep_existing_list_patterns_arrangement false
        // @formatter:align_multiline_list_pattern true
        // @formatter:wrap_list_pattern chop_if_long // chop_always | simple_wrap
        // @formatter:max_array_initializer_elements_on_line 100001
        int[] numbers = [ 1, 2, 3 ];
    }

    private class Custom
    {
        private static void M()
        {
            (File file1, File file2) = (null!, null!);
            VirtualDirectory directory = [ file1, file2 ];
        }

        public class File;

        [CollectionBuilder(typeof(VirtualDirectory), "Create")]
        public class VirtualDirectory
        {
            public static VirtualDirectory Create(ReadOnlySpan<File> items) => null!;
            public IEnumerator<File> GetEnumerator() => null!;
        }
    }


    private static void Conversion()
    {
        int[] array = [ 1, 2 ];
        IList<int> list = [ 1, 2 ];
        IEnumerable<int> enumerable = [ 1, 2 ];

        // IReadOnlyCollection<int> readonlyCollection = [1, 2];
        // IReadOnlyList<int> readonlyList = [1, 2];
        // ICollection<int> collection = [1, 2];

        // Span<int> span = [1, 2];
        // ReadOnlySpan<int> readOnlySpan = [1, 2];

        // object[] array1 = [1]; // okay
        // object[] array2 = new[] { 1 }; // error
    }

    private static void L(List<int> list)
    {
    }

    private static void IA(ImmutableArray<int> list)
    {
    }

    private static void A(int[] list)
    {
    }

    private static void E(IEnumerable<int> enumerabale)
    {
    }

    private static void ROL(IReadOnlyList<int> list)
    {
    }

    private static void H(HashSet<int> hashSet)
    {
    }

    private static void S(Span<int> span)
    {
    }
}
