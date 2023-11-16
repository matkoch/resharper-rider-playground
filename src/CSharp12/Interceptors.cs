using System.Runtime.CompilerServices;

namespace CSharp12
{
    public static class Interceptors
    {
        public static void M()
        {
            Console.WriteLine("original");
            Console.WriteLine("original");
        }

        [InterceptsLocation(
            // Update path using 'Copy Path/Reference' action
            filePath: "/Users/matt/code/resharper-rider-playground/src/CSharp12/Interceptors.cs",
            line: 9,
            column: 21)]
        public static void Intercept(string? message)
        {
            Console.WriteLine($"INTERCEPTED! Original message was '{message}'");
        }
    }
}

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    sealed class InterceptsLocationAttribute(string filePath, int line, int column) : Attribute
    {
    }
}
