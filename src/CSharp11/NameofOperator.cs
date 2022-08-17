using System.Runtime.CompilerServices;

namespace CSharp11;

public static class NameofOperator
{
    public const string Foo = "Foo";
    public const string Bar = "Bar";

    public static void Log(
        int number,
        [CallerArgumentExpression("number")] string? expression = null)
    {
        Console.WriteLine($"{expression} = {number}");
    }

    public static void Start() => Log(1030 + 307);
}
