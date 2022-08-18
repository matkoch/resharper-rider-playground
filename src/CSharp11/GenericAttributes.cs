using System.Diagnostics;

namespace CSharp11;

public static class GenericAttributes
{
    [Context<MyContext>]
    public static void Start()
    {
    }

    private class ContextAttribute<T> : Attribute
        where T : IDisposable
    {
        private T? _context;

        // Challenge: can we also not use reflection?
        public void Setup() => _context = Activator.CreateInstance<T>();
        public void Cleanup() => _context!.Dispose();
    }

    private class MyContext : IDisposable
    {
        public MyContext() => "Setup".Dump();
        public void Dispose() => "Cleanup".Dump();
    }
}
