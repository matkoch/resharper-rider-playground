using System.Diagnostics.CodeAnalysis;

// ReSharper disable FunctionRecursiveOnAllPaths
// ReSharper disable TailRecursiveCall
// ReSharper disable UnusedParameter.Local

namespace RSRD252;

file class ConstantExpected
{
    private static void M(
        [ConstantExpected(Min = 1000, Max = 9999)]
        int n)
    {
        M(1337);
        M(n); // transitive

        M(555); // below
        M(10000); // above
        M(1337 + new Random().Next()); // non-constant
    }

    void N([ConstantExpected(Min = 'm', Max = 'z')] char c)
    {
        N('a');
        N('n');
        N('z');
    }
}
