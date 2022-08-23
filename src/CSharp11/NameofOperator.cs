using System.Runtime.CompilerServices;

namespace CSharp11;

public static class NameofOperator
{
    // CA: capture constant name
    // Challenge: capture in whole file
    public const string Foo = "Foo";
    public const string Bar = "Bar";

    public static void Calculate(
        int number,
        [CallerArgumentExpression("number")] string? expression = null)
    {
        Console.WriteLine($"{expression} = {number}");
    }

    public static void Start() => Calculate(1030 + 307);
}
