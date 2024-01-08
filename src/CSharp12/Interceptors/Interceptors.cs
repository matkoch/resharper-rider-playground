using System.Runtime.CompilerServices;

namespace CSharp12.Interceptors;

public static class Interceptors
{
    public static void M()
    {
        Console.WriteLine("original");
        Console.WriteLine("original");

        var p = new Person("Rick");
        p.SayHi();
        p.SayHi();
        p.SayHi();
    }

    [InterceptsLocation(
        // TODO: Update path using 'Copy Path/Reference' action
        filePath: "/Users/matt/code/resharper-rider-playground/src/CSharp12/Interceptors/Interceptors.cs",
        line: 10,
        column: 17)]
    public static void Intercept(string? message)
    {
        Console.WriteLine($"INTERCEPTED! Original message was '{message}'");
    }

    [InterceptsLocation(
        // TODO: Update path using 'Copy Path/Reference' action
        filePath: "/Users/matt/code/resharper-rider-playground/src/CSharp12/Interceptors/Interceptors.cs",
        line: 14,
        column: 11)]
    [InterceptsLocation(
        // TODO: Update path using 'Copy Path/Reference' action
        filePath: "/Users/matt/code/resharper-rider-playground/src/CSharp12/Interceptors/Interceptors.cs",
        line: 15,
        column: 11)]
    public static void Intercept2(this Person p)
    {
        Console.WriteLine($"INTERCEPTED! {p.Name} is busy");
    }

    public record Person(string Name)
    {
        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {Name}");
        }
    }
}
