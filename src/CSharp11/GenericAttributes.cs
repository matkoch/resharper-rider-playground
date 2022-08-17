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

        public void Setup() => _context = Activator.CreateInstance<T>();
        public void Cleanup() => _context!.Dispose();
    }

    private class MyContext : IDisposable
    {
        public MyContext() => "Setup".Dump();
        public void Dispose() => "Cleanup".Dump();
    }
}

public static class MultilineInterpolation
{
    public static void Start()
    {
        var allEvents = new [] {new {Name = "Foo", Date = DateTime.Today}, new {Name = "Bar", Date = DateTime.Today}};

        $"We welcome you to our {allEvents.Where(x => x.Date >= DateTime.Today).OrderBy(x => x.Name).Select(x => x.Name).JoinComma()} events.".Dump();

        $"We welcome you to our {
            allEvents
                .Where(x => x.Date >= DateTime.Today)
                .OrderBy(x => x.Name)
                .Select(x => x.Name)
                .JoinComma()
        } events.".Dump();
    }
}
