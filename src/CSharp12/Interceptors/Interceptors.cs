using System.Runtime.CompilerServices;

namespace CSharp12.Interceptors;

public static class Interceptors
{
    public static void M()
    {
        Console.WriteLine("original");
        Console.WriteLine("original");
    }

    [InterceptsLocation(
        // TODO: Update path using 'Copy Path/Reference' action
        filePath: "/Users/matt/code/resharper-rider-playground/src/CSharp12/Interceptors/Interceptors.cs",
        line: 9,
        column: 17)]
    public static void Intercept(string? message)
    {
        Console.WriteLine($"INTERCEPTED! Original message was '{message}'");
    }
}
