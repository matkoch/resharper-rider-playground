namespace CSharp11;

public static class MultilineInterpolation
{
    public static void Start()
    {
        var allEvents = new[] { new { Name = "Foo", Date = DateTime.Today }, new { Name = "Bar", Date = DateTime.Today } };

        $"We welcome you to our {string.Join(", ", allEvents.Where(x => x.Date >= DateTime.Today).OrderBy(x => x.Name).Select(x => x.Name))} events.".Dump();

        $"We welcome you to our {
            string.Join(", ", allEvents
                .Where(x => x.Date >= DateTime.Today)
                .OrderBy(x => x.Name)
                .Select(x => x.Name))
        } events.".Dump();
    }
}
