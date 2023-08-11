namespace CodeEditing;

public class InlayHints
{
    public void M()
    {
        // TODO: add tuple name
        var dict = new List<(string FirstName, string LastName, DateTime?, bool Flagged)>();

        dict.Add(("Sasha", "Ivanova", DateTime.UnixEpoch, false));
        dict.Add(("Maarten", "Balliauw", null, true));
        dict.Add(("Rachel", "Appel", DateTime.Now, false));

        if (dict.First() is ("Maarten", _, _, true))
            Console.WriteLine("HELP!");
    }
}
